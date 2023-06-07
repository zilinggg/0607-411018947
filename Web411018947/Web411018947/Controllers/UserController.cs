using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411018947.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music(string name, float? number)
        
        {
            var result = "";
        
            ViewBag.Name = name;
            ViewBag.Number = number;
            return View();
        }
    }
}