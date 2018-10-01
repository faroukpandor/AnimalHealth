using AnimalHealth.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Domains
{
    public class Country : MainDomain
    {
        private string CountryName { set; get; }
        private string OfficialCode { get; set; }
    }
}
