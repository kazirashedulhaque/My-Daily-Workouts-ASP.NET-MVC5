using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        public string name;
        public string regNo;
        public double speed;
        public double maxSpeed=0;
        public double minSpeed=9999999999999999999;
      

        public double MinSpeed(double currentSpeed,double currentMin)
        {
            if (currentMin > currentSpeed)
            {
                return currentSpeed;
            }
            else
            {
                return currentMin;
            }
        }

        public double MaxSpeed(double currentSpeed,double currentMax)
        {
            if (currentMax < currentSpeed)
            {
                return currentSpeed;
            }
            else
            {
                return currentMax;
            }
            
        }

        public string AverageSpeed(double totalSpeed,int counter)
        {
            return (totalSpeed/counter).ToString();
        }
    }
}
