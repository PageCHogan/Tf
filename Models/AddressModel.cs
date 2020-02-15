using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triggerfish.Models
{
    public class AddressModel
    {
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public AddressModel()
        {
            Address = null;
            PostalCode = null;
        }
    }
}
