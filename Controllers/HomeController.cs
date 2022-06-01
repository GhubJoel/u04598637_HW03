using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace u04598637_HW03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(HttpPostedFileBase files, string radioresult)
        {
            var result = Request.Form["radioresult"];
            

                var fileName = Path.GetFileName(files.FileName);


                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);


                files.SaveAs(path);

            return null;

        }

        public ActionResult Files()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Images()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Videos()
        {
            ViewBag.Message = "Your Videos page.";

            return View();
        }
        public ActionResult Aboutme()
        {
            ViewBag.Message = "Your About me page.";

            return View();
        }


    }
}