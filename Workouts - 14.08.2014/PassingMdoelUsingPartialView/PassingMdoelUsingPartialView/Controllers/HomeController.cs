using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassingMdoelUsingPartialView.Models;

namespace PassingMdoelUsingPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            Student aStudent = new Student();
            //aStudent.Name = "Rashedul Haque";
            //aStudent.Age = "25";
            //aStudent.Phone = "01717453143";
            return View(aStudent);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}