using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkWithModelInMvc.Models
{
    public class Product
    {
        [Key]
        public int ProductId { set; get; }
        public string Name { set; get; }

        [Display(Name="Product's Unit Price")]
        public int UnitPrice { set; get; }
        public int Quantity { set; get; }
    }
}