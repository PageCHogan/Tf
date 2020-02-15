﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Triggerfish.Models;
using Triggerfish.Models.PageViewModels;

namespace Triggerfish.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            HomePageViewModel viewModel = new HomePageViewModel();

            using (StreamReader r = new StreamReader("wwwroot/documents/addresses.json"))
            {
                string json = r.ReadToEnd();

                var a = await ProcessJson(JsonConvert.DeserializeObject<List<AddressModel>>(json));
                viewModel.AddressList = a.ToList();
            }

            return View(viewModel);
        }

        public IActionResult Demo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IEnumerable<AddressModel>> ProcessJson(List<AddressModel> addressModels)
        {
            List<Task<AddressModel>> listOfTasks = new List<Task<AddressModel>>();

            if (addressModels != null)
            {
                foreach (var address in addressModels)
                {
                    listOfTasks.Add(ExtractPostCodes(address));
                }
            }

            return await Task.WhenAll<AddressModel>(listOfTasks);
        }

        private Task<AddressModel> ExtractPostCodes(AddressModel address)
        {
            Regex regexComplex = new Regex(@"^(?:(?:[2-8]\d|9[0-7]|0?[28]|0?9(?=09))(?:\d{2}))$"); // Source - https://rgxdb.com/r/2Z7DWG3I
            char[] delim = { ' ', ',', ';', ':', '.', '|' };

            //TODO: Currently retreives first confirmed 4 digit number
            //  returning erronous postcode not found and street address is 4 digits.
            foreach (string token in address.Address.Split(delim).Reverse().ToList())
            {
                if (regexComplex.IsMatch(token) && string.IsNullOrEmpty(address.PostalCode))
                {
                    address.PostalCode = token;
                }
            }

            if (string.IsNullOrEmpty(address.PostalCode))
            {
                address.PostalCode = "No valid postcode found";
            }

            return Task.FromResult(address);
        }
    }
}
