
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMuzyczny.Controllers
{
    public class TowarController : Controller
    {
        private szkolaEntities db = new szkolaEntities();

        //
        // GET: /Towar/

        public ActionResult Index()
        {
            var towars = db.towars.Include(t => t.gatunek).Include(t => t.wykonawca);
            return View(towars.ToList());
        }

        //
        // GET: /Towar/Details/5

        public ActionResult Details(int id = 0)
        {
            towar towar = db.towars.Find(id);
            if (towar == null)
            {
                return HttpNotFound();
            }
            return View(towar);
        }

        public ActionResult DetailsKlient(int id = 0)
        {
            towar towar = db.towars.Find(id);
            if (towar == null)
            {
                return HttpNotFound();
            }
            return View(towar);
        }
        //
        // GET: /Towar/Create

        public ActionResult Create()
        {
            ViewBag.idGatunku = new SelectList(db.gatuneks, "idGatunku", "Name");
            ViewBag.idWykonawcy = new SelectList(db.wykonawcas, "idWykonawcy", "Imie");
            return View();
        }

        //
        // POST: /Towar/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Exclude = "idTowaru")]towar towar)
        {
            if (ModelState.IsValid)
            {
                db.towars.Add(towar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idGatunku = new SelectList(db.gatuneks, "idGatunku", "Name", towar.idGatunku);
            ViewBag.idWykonawcy = new SelectList(db.wykonawcas, "idWykonawcy", "Imie", towar.idWykonawcy);
            return View(towar);
        }

        //
        // GET: /Towar/Edit/5

        public ActionResult Edit(int id = 0)
        {
            towar towar = db.towars.Find(id);
            if (towar == null)
            {
                return HttpNotFound();
            }
            ViewBag.idGatunku = new SelectList(db.gatuneks, "idGatunku", "Name", towar.idGatunku);
            ViewBag.idWykonawcy = new SelectList(db.wykonawcas, "idWykonawcy", "Imie", towar.idWykonawcy);
            return View(towar);
        }

        //
        // POST: /Towar/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(towar towar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(towar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idGatunku = new SelectList(db.gatuneks, "idGatunku", "Name", towar.idGatunku);
            ViewBag.idWykonawcy = new SelectList(db.wykonawcas, "idWykonawcy", "Imie", towar.idWykonawcy);
            return View(towar);
        }

        //
        // GET: /Towar/Delete/5

        public ActionResult Delete(int id = 0)
        {
            towar towar = db.towars.Find(id);

            if (towar == null)
            {
                return HttpNotFound();
            }
            return View(towar);
        }

        //
        // POST: /Towar/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            towar towar = db.towars.Find(id);
            db.towars.Remove(towar);
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