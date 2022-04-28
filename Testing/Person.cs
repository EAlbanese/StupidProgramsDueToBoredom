using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Person : ICloneable
    {
        public string Name { get; set; }

        public string Gener { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
