using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMuzyczny.Controllers
{
    public class ZamówienieController : Controller
    {
        //
        // GET: /Koszyk/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Koszyk/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Koszyk/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Koszyk/Create

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
        // GET: /Koszyk/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Koszyk/Edit/5

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
        // GET: /Koszyk/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Koszyk/Delete/5

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
