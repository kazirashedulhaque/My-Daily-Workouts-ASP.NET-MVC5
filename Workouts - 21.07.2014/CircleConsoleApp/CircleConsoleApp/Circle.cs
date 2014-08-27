using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp
{
    class Circle
    {
        public double radius;
        public const double pi = 3.1413;

        public double ShowDiameter(double radius)
        {
            
            return 2 * radius;
        }

        public double ShowPerimeter(double radius)
        {

            return 2 * pi * radius;
        }

        public double ShowArea(double radius)
        {
            return pi * radius * radius;
        }
    }
}
