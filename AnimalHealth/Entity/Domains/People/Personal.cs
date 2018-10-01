using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHealth.Domains
{
    public class Personal : People
    {
        private Role Role { set; get; }
    }
}
