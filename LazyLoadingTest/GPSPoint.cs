using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingTest
{
    public class GPSPoint
    {
        public int X;
        public int Y;
        public DateTime Recorded;

        public GPSPoint(int x, int y, DateTime recorded)
        {
            X = x;
            Y = y;
            Recorded = recorded;
        }

        public GPSPoint()
        {

        }
    }
}
