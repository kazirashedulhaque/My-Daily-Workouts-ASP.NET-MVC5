using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

    }
}