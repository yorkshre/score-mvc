using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepMuzycznyMVC;

namespace SklepMuzyczny.Controllers
{
    public class GatunekController : Controller
    {
        private szkolaEntities db = new szkolaEntities();

        //
        // GET: /Gatunek/

        public ActionResult Index()
        {
            return View(db.gatuneks.ToList());
        }

        //
        // GET: /Gatunek/Details/5

        public ActionResult Details(int id = 0)
        {
            gatunek gatunek = db.gatuneks.Find(id);
            if (gatunek == null)
            {
                return HttpNotFound();
            }
            return View(gatunek);
        }

        //
        // GET: /Gatunek/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Gatunek/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(gatunek gatunek)
        {
            if (ModelState.IsValid)
            {
                db.gatuneks.Add(gatunek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gatunek);
        }

        //
        // GET: /Gatunek/Edit/5

        public ActionResult Edit(int id = 0)
        {
            gatunek gatunek = db.gatuneks.Find(id);
            if (gatunek == null)
            {
                return HttpNotFound();
            }
            return View(gatunek);
        }

        //
        // POST: /Gatunek/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(gatunek gatunek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gatunek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gatunek);
        }

        //
        // GET: /Gatunek/Delete/5

        public ActionResult Delete(int id = 0)
        {
            gatunek gatunek = db.gatunek.Find(id);
            if (gatunek == null)
            {
                return HttpNotFound();
            }
            return View(gatunek);
        }

        //
        // POST: /Gatunek/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            gatunek gatunek = db.gatuneks.Find(id);
            db.gatuneks.Remove(gatunek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}