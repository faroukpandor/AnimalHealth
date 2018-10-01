using AnimalHealth.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Domains
{
    public class City : MainDomain
    {
        private string Name { get; set; }
        private string OfficialCode { get; set; }
        private PostalCode PostalCodeStart { set; get; }
        private PostalCode PostalCodeEnd { set; get; }
    }
}
