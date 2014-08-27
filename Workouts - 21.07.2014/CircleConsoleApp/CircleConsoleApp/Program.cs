using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            aCircle.radius = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine(aCircle.ShowDiameter(aCircle.radius));
            Console.WriteLine(aCircle.ShowPerimeter(aCircle.radius));
            Console.WriteLine(aCircle.ShowArea(aCircle.radius));
            Console.ReadKey();


        }
    }
}
