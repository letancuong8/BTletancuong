using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    class Point
    {
        #region Properties
        public int x { get; set; }

        public int y { get; set; }
        #endregion

        #region Constructors
        public Point()
        {
            x = 0; y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        #endregion

        #region Overloading
        /// <summary>
        /// Khoàng cách từ điểm hiện tại đến góc tọa độ 0(0, 0)
        /// </summary>
        /// <returns>Khoảng cách đến 0</returns>
        public double Distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }

        public double Dis2Point(Point p)
        {
            var delX = x - p.x;
            var delY = x - p.y;
            double d = Math.Sqrt(Math.Pow(delX, 2) + Math.Pow(delY, 2));
            return d;
        }
        #endregion

        #region Overriding
        public override string ToString()
        {
            var rs =  $"Toa do cua diem la ({x},{y})";
            return rs;
        }
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point o = obj as Point;
                if (o.x == x && o.y == y)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        #endregion
    }
}
