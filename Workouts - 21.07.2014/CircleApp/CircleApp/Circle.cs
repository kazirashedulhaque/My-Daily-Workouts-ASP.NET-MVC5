using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radius;

        public const double pi= 3.1413;

        public double ShowDiameter()
        {
            return 2 * radius;
        }

        public double ShowPerimeter()
        {

            return 2 * pi * radius;
        }

        public double ShowArea()
        {
            return pi * radius * radius;
        }
    }
}
