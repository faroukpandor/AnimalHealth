using AnimalHealth.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Domains
{
    public class PostalCode : MainDomain
    {
        private int Code { set; get; }
        private Country Country { set; get; }
        private FederativeUnit FederativeUnit { set; get; }
        private City City { set; get; }
        private string District { set; get; }
    }
}
