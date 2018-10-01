using AnimalHealth.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Domains
{
    public class FederativeUnit : MainDomain
    {
        private string Name { set; get; }
        private string Initials { set; get; }
        private string OfficialCode { get; set; }

    }
}
