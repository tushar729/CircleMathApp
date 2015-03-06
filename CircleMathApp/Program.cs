using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            Console.WriteLine("Please Enter Radius of the Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diameter of the circle: " + aCircle.GetDiameter(radius));
            Console.WriteLine("Perimeter of the circle: " + aCircle.GetPerimeter(radius));
            Console.WriteLine("Area of the circle: " + aCircle.GetArea(radius));
            Console.ReadKey();
        }
    }
}
