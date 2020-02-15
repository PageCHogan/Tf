using System;
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

        public IActionResult Index()
        {
            HomePageViewModel viewModel = new HomePageViewModel();

            using (StreamReader r = new StreamReader("wwwroot/documents/addresses.json"))
            {
                string json = r.ReadToEnd();
                List<AddressModel> items = JsonConvert.DeserializeObject<List<AddressModel>>(json);
                
                if(items != null)
                {
                    viewModel.AddressList = items;

                    //TODO: Call must be async
                    viewModel.AddressList.ForEach(o => ExtractPostCodes(o));
                }
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

        private AddressModel ExtractPostCodes(AddressModel address)
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

            return address;
        }
    }
}
