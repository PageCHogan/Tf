using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
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
        private const string TEST_DATA_PATH = "wwwroot/documents/addresses.json";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            HomePageViewModel viewModel = new HomePageViewModel();

            using (StreamReader reader = new StreamReader(TEST_DATA_PATH))
            {
                string json = reader.ReadToEnd();

                IEnumerable<AddressModel> addresses = await ProcessAddresses(JsonConvert.DeserializeObject<List<AddressModel>>(json));
                viewModel.AddressList = addresses.ToList();
            }

            if(viewModel.AddressList.Count > 0)
            {
                viewModel.PostcodeList.AddRange(viewModel.AddressList.Select(x => x.PostalCode).Distinct().OfType<string>());
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

        public async Task<IEnumerable<AddressModel>> ProcessAddresses(List<AddressModel> addresses)
        {
            List<Task<AddressModel>> taskList = new List<Task<AddressModel>>();

            if (addresses != null)
            {
                foreach (var address in addresses)
                {
                    // Uncomment to demonstrate async threading
                    // Thread.Sleep(1000);
                    taskList.Add(ExtractPostCodes(address));
                }
            }

            return await Task.WhenAll(taskList);
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

            return Task.FromResult(address);
        }
    }
}
