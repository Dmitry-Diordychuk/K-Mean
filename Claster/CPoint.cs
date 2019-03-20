using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kmean
{
    public class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CPoint()
        {
            X = -1;
            Y = -1;
        }
        public CPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static CPoint operator+ (CPoint a, CPoint b)
        {
            CPoint sum = new CPoint();
            sum.X = a.X + b.X;
            sum.Y = a.Y + b.Y;
            return sum;
        }
        public static CPoint operator/ (CPoint a, int b)
        {
            CPoint result = new CPoint(0,0);
            result.X = a.X / b;
            result.Y = a.Y / b;
            return result;
        }
        
        public Point ToPoint()
        {
            Point p = new Point();
            p.X = this.X;
            p.Y = this.Y;
            return p;
        }
    }
}
