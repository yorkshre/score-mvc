using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMuzyczny.Controllers
{
    public class HomeSklepController : Controller
    {
        //
        // GET: /HomeSklep/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HomeSklep/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /HomeSklep/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HomeSklep/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HomeSklep/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HomeSklep/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HomeSklep/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HomeSklep/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
