using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingTest.AutoModel
{
    public class Auto : AutoBase
    {
        public double CurrentSpeed => CalculateCurrentSpeed();

        public Auto() : base()
        {

        }
    }
}
