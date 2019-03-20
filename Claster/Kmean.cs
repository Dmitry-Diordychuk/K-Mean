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
        public List<Claster> clasters { get; set; } = new List<Claster>();
        public List<CPoint> points { get; set; } = new List<CPoint>();

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

        public static void Partitioning(Kmean graph)
        {
            Claster nearestClaster = null;
            int tempDistance;
            int curDistance;
            foreach (CPoint point in graph.points)
            {
                tempDistance = -1;
                foreach (Claster claster in graph.clasters)
                {
                    curDistance = (int)Math.Sqrt(Math.Pow(Math.Abs(point.X - claster.Location.X), 2) + Math.Pow(Math.Abs(point.Y - claster.Location.Y), 2));
                    if (curDistance < tempDistance || tempDistance == -1)
                    {
                        nearestClaster = claster;
                        tempDistance = curDistance;
                    }
                }
                nearestClaster.AddEdge(point,tempDistance);
            }
        }

        public static void FindCentroid(Kmean graph)
        {
            foreach(Claster claster in graph.clasters)
            {
                CPoint result = new CPoint(0,0);
                int divider = 0;
                foreach(var edge in claster.edges)
                {
                    result += edge.Item1;
                    divider++;
                }
                if (divider != 0)
                {
                    result /= divider;
                }
                claster.Centroid = result;
            }
        }
        public static void AllMoveToCentroid(Kmean graph)
        {
            foreach(var claster in graph.clasters)
            {
                claster.MoveToCentroid();
                claster.edges.Clear();
            }
        }
    }
}
