using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmean
{
    interface IKmean
    {
        List<Claster> clasters { get; set; }
        List<CPoint> points { get; set; }
        Claster this[int index] { get; set; }
        void AddClaster(Claster claster);
        void AddPoint(CPoint p);
    }
}
