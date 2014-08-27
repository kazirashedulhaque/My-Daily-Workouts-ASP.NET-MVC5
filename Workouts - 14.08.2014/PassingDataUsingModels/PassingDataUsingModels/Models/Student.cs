using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassingDataUsingModels.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }

        public Student()
        {
            Name = "Rashedul Haque";
            Phone = "01717453143";
            Age = "25";
        }
    }
}