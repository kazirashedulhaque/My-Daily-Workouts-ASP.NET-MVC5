using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using PartialViewPassingModel.Models;


namespace PartialViewPassingModel.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext db = new ProductDbContext();
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product aProduct)
        {
            if (aProduct != null)
            {
                db.Products.Add(aProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
