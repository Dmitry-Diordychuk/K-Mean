using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmean
{
    interface IClaster
    {
        CPoint Location { get; set; }
        CPoint Centroid { get; set; }
        List<(CPoint,int?)> edges { get; set; }
        void AddEdge(int x, int y, int? dis);
        void AddEdge(CPoint p, int? dis);
        void SetClusterPoint(int x, int y);
        void SetClusterPoint(CPoint p);
    }
}
