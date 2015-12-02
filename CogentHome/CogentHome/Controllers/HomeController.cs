using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CogentHome.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Contact(string name, string email, string message)
        //{
        //    if (string.IsNullOrEmpty(name)) return RedirectToAction("Index");
        //    if (string.IsNullOrEmpty(name)) return RedirectToAction("Index");




        //    string path = HttpContext.Server.MapPath("~/App_Data/message/" + new Guid().ToString() + ".txt"


        //    System.IO.File.WriteAllText(path, );
        //}
	}
}