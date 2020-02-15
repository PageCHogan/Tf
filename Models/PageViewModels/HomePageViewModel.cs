﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Triggerfish.Models.PageViewModels
{
    public class HomePageViewModel : BasePageViewModel
    {
        [Display(Name = "Addresses")]
        public List<AddressModel> AddressList { get; set; }
        
        public HomePageViewModel()
        {
            AddressList = new List<AddressModel>();
        }
    }
}