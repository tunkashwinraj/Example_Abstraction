using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone(); // OK as all fields are either
        } // value or string type (which behaves as a value type)

    }

}
