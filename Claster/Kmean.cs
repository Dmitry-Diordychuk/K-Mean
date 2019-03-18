using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmean
{
    class Kmean : IKmean, IEnumerable<Claster>
    {
        public Claster this[int index] { get => clasters[index]; set => clasters[index] = value; }

        public List<Claster> clasters { get; set; }
        public List<CPoint> points { get; set; }

        public void AddClaster(Claster claster)
        {
            clasters.Add(claster);
        }

        public void AddPoint(CPoint p)
        {
            points.Add(p);
        }

        public IEnumerator<Claster> GetEnumerator()
        {
            return clasters.GetEnumerator();
        }
        //Разница?
        IEnumerator IEnumerable.GetEnumerator()
        {
            return clasters.GetEnumerator();
        }
    }
}
