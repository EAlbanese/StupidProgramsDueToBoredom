using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingTest.AutoModel
{
    public abstract class AutoBase
    {
        public IList<GPSPoint> GPSPoints { get; set; }

        public double CalculateCurrentSpeed()
        {
            if (GPSPoints.Count < 2) throw new Exception("Not enough GPSPoints.");

            var calcPoints = GPSPoints.OrderByDescending(x => x.Recorded).Take(2).ToList();
            var mPerS = (calcPoints[0].Y - calcPoints[1].Y) / (calcPoints[0].Recorded - calcPoints[1].Recorded).TotalSeconds;
            return mPerS;
        }

        public AutoBase()
        {
            GPSPoints = new List<GPSPoint>();
        }
    }
}
