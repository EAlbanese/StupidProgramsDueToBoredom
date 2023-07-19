using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingTest.AutoModel
{
    public class AutoLazyLoad : AutoBase
    {
        public Lazy<double> CurrentSpeedLazyLoad
        {
            get
            {
                return new Lazy<double>(CalculateCurrentSpeed);
            }
        }

        public AutoLazyLoad() : base()
        {

        }
    }
}
