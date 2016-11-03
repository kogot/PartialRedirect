using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentManager()
        {
            return PartialView("NewStudent");
        }
        public ActionResult NewStudent()
        {
            return PartialView();
        }
        //
        // POST: 
        [HttpPost]
        public ActionResult NewStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index","Manage");
            }
            return null;
        }
    }
}