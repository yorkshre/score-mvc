using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Providers.Entities;

namespace SklepMuzyczny.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Register(User U)
        {
            if(ModelState.IsValid)
            {
                using(szkolaEntities se= new szkolaEntities())
                {
                    se.Add(U);
                    se.SaveChanges();
                }
            }
            return View(U);
        }
    }
}
