using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string exceptionMessage , string customMessage )
        {
            ViewBag.Error = exceptionMessage;

            ViewBag.Message = customMessage;

            return View();
        }
    }
}