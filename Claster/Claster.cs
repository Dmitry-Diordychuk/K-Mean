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
            Location.X = -1;
            Location.Y = -1;
        }
        public Claster(int x, int y)
        {
            Location.X = x;
            Location.Y = y;
        }

        public List<(CPoint,int?)> edges { get; set; } = new List<(CPoint,int?)>();

        public CPoint Location { get; set; } = new CPoint();
        public CPoint Centroid { get; set; } = new CPoint();

        public void SetClusterPoint(int x, int y)
        {
            Location.X = x;
            Location.Y = y;
        }

        public void SetClusterPoint(CPoint p)
        {
            Location = p;
        }

        public void AddEdge(int x, int y, int? dis)
        {
            edges.Add((new CPoint(x, y), dis));
        }

        public void AddEdge(CPoint p, int? dis)
        {
            edges.Add((p,dis));
        }

        public IEnumerator GetEnumerator()
        {
            return edges.GetEnumerator();
        }

        public void MoveToCentroid()
        {
            try
            {
                Location.X = Centroid.X;
                Location.Y = Centroid.Y;
                Centroid = null;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Centroid doesn't exist!");
            }
        }
    }
}
