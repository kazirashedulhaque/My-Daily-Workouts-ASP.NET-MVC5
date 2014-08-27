using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Number
    {
        public double firstNumber;
        public double secondNumber;


        public double AddNumber()
        {
            return firstNumber + secondNumber;
        }

        public double SubtractNumber()
        {
            return firstNumber - secondNumber;
        }

        public double MultiplyNumber()
        {
            return firstNumber * secondNumber;
        }

        public double DivideNumber()
        {
            return firstNumber / secondNumber;
        }

    }
}
