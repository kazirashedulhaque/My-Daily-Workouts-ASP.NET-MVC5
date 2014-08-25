using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMdApplication.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        [Display(Name = "Doctor's Name")]
        public string DoctorName { get; set; }

        [Display(Name = "Designation")]
        public string DoctorDesignation { get; set; }
        public List<Article> ArticleList { get; set; } 
    }
}