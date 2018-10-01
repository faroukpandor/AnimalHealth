using AnimalHealth.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Domains
{
    public abstract class People : MainDomain
    {   
        private string Name { set; get; }
        private PostalCode PostalCode { set; get; }
    }
}
