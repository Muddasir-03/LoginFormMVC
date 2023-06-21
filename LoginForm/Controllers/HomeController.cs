using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(login log)
        {
            if(log.UserName != null && log.Password !=null )
            {
                return View();
            }
            return View("Index");
        }
    }
}