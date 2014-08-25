using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CountryCityApp.Models;

namespace CountryCityApp.Controllers
{
    public class CountryController : Controller
    {
        private CountryDbContext db = new CountryDbContext();

        public ActionResult Search(string searchBy, string searchCountryTextBox, int? searchCountryList)
        {
            List<Country> countryList = new List<Country>();

            if (searchBy == "Name")
            {
                countryList = db.Countries.Where(c => c.Name.Contains(searchCountryTextBox)).ToList();
            }
            else if (searchBy == "List")
            {
                countryList = db.Countries.Where(c => c.CountryId == searchCountryList).ToList();
            }
            ViewBag.searchCountryList = new SelectList(db.Countries, "CountryId", "Name");
            return View(countryList);
        }

        // GET: /Country/
        public ActionResult Index()
        {
            var countries = db.Countries.Include(country => country.Cities);
            ViewBag.Drop = new SelectList(db.Countries, "CountryId", "Name");
            return View(countries.ToList());
        }


        // GET: /Country/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // GET: /Country/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Country/Create
        [HttpPost]
        public ActionResult Create([Bind(Include="CountryId,Name,About")] Country country)
        {
            if (ModelState.IsValid)
            {
                db.Countries.Add(country);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: /Country/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: /Country/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CountryId,Name,About")] Country country)
        {
            if (ModelState.IsValid)
            {
                db.Entry(country).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        // GET: /Country/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: /Country/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = db.Countries.Find(id);
            db.Countries.Remove(country);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
