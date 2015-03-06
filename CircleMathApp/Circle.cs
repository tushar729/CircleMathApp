using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMathApp
{
    class Circle
    {
        private const double PI = 3.1416;

        public double GetDiameter(double radius)
        {
            return 2 * radius;
        }

        public double GetPerimeter(double radius)
        {
            return 2*PI*radius;
        }

        public double GetArea(double radius)
        {
            return PI*radius*radius;
        }
    }
}
