using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMdApplication.Models
{
    public class ArticleDoctorContext:DbContext
    {
        public DbSet<Article> Articles { set; get; }
        public DbSet<Doctor> Doctors { set; get; } 
    }
}