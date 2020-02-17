using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylancer.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public Email Email { get; set; }

        public Phone Phone { get; set; }
    }
}
