using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CountryCityApp.Models
{
    public class Country
    {
        public int CountryId { set; get; }

        [Display(Name="Country Name")]
        public string Name { set; get; }

        [DataType(DataType.MultilineText)]
        public string About { set; get; }

        [Display(Name="No of Cities")]
        public int NoOfCities { get; private set; }
        public virtual List<City> Cities { set; get; }

    }
}