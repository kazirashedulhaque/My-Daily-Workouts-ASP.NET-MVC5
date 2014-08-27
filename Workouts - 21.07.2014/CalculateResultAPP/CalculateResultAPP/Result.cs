using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculateResultAPP
{
    class Result
    {
        public double physicsNumber;
        public double chemistryNumber;
        public double mathNumber;
        public double average;

        public double AverageCalculator()
        {
            return (physicsNumber + chemistryNumber + mathNumber)/3;
        }

    }
}
