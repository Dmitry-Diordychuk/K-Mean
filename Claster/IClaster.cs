using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmean
{
    interface IClaster
    {
        CPoint curClaster { get; set; }
        List<CPoint> points { get; set; }
        CPoint this[int index] { get; set; }
        void AddPoint(int x, int y);
        void AddPoint(CPoint p);
        void SetClusterPoint(int x, int y);
        void SetClusterPoint(CPoint p);
    }
}
