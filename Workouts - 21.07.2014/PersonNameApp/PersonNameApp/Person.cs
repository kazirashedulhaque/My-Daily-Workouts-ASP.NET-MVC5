using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNameApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            
            this.MiddleName = middleName;
            
        }

        public Person(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person()
        {

        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
