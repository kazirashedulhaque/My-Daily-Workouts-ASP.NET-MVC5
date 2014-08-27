using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountApp
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public Account CustomerAccount { get; set; }

        public Customer(string customerName, string customerEmail):this()
        {
            this.CustomerName = customerName;
            this.CustomerEmail = customerEmail;
        }

        public Customer()
        {

        }
    }
}
