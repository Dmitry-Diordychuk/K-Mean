using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmean
{
    public class Claster : IClaster, IEnumerable
    {
        public Claster()
        {
            curClaster.X = null;
            curClaster.Y = null;
        }
        public Claster(int x, int y)
        {
            curClaster.X = x;
            curClaster.Y = y;
        }

        public CPoint this[int index] { get => points[index]; set => points[index] = value; }

        public List<CPoint> points{ get; set; }

        public CPoint curClaster { get; set; }

        public void SetClusterPoint(int x, int y)
        {
            curClaster.X = x;
            curClaster.Y = y;
        }

        public void SetClusterPoint(CPoint p)
        {
            curClaster = p;
        }

        public void AddPoint(int x, int y)
        {
            points.Add(new CPoint(x, y));
        }

        public void AddPoint(CPoint p)
        {
            points.Add(p);
        }

        public IEnumerator GetEnumerator()
        {
            return points.GetEnumerator();
        }
    }
}
