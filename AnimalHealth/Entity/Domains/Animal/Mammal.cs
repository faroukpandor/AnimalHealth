using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Entity.Domains.Animal
{
    public class Mammal : MainDomain
    {
        private Species Species { set; get; }
        private DateTime BirthDate { set; get; }
    }
}
