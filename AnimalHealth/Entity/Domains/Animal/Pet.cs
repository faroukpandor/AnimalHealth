using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Entity.Domains.Animal
{
    public class Pet : MainDomain
    {
        private Mammal Mammal { set; get; }
    }
}
