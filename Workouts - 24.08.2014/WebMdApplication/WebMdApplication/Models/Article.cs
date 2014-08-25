using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMdApplication.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Display(Name = "Title")]
        public string ArticleTitle { get; set; }

        [Display(Name = "Content")]
        [DataType(DataType.MultilineText)]
        public string ArticleContent { get; set; }
        public string ImagePath { get; set; }
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

    }
}