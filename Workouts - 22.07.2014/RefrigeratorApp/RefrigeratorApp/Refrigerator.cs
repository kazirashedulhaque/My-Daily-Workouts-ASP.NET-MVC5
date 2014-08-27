using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        public double capacity;
        public double currentWeight=0;
        public double remainingWeight;

        public void AddItems(int noOfItems, double weightPerUnit)
        {
            double itemsTobeAdded = weightPerUnit*noOfItems;
            if (currentWeight + itemsTobeAdded <= capacity)
            {
                currentWeight +=  noOfItems*weightPerUnit;
                remainingWeight = capacity - currentWeight;
            }
            else
            {
                throw new Exception("Overload...");
            }
            
        }
    }
}
