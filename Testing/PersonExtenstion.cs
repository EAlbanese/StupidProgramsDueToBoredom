using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public static class PersonExtenstion
    {
        public static void ChangeGenderToM(this Person p) {
            p.Gener = "M";
        }

    }
}
