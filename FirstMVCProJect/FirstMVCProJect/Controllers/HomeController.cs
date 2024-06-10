using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProJect.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public  ActionResult FirstAction()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View("OurProduct");
        }
        public ActionResult Contact() {
            return View();
        }
        public ActionResult GetEmpName(int Emid)
        {
            var employees = new[]
            {
                new { Emid = 1, EmName = "Duc", Salary = 8000 },
                new { Emid = 2, EmName = "Duc2", Salary = 7000 },
                new { Emid = 3, EmName = "Duc3", Salary = 6000 },

            };
            string matchEmName = null;
            foreach (var item in employees)
            {
                if(item.Emid == Emid)
                {
                    matchEmName = item.EmName;
                }
            }
            //return new ContentResult() { Content = matchEmName, ContentType = "text/plain" };
            return Content(matchEmName, "text/plain");
        }
        public ActionResult EmpFBPage(int Emid) {
            var employees = new[]
            {
                new { Emid = 1, EmName = "Duc", Salary = 8000 },
                new { Emid = 2, EmName = "Duc2", Salary = 7000 },
                new { Emid = 3, EmName = "Duc3", Salary = 6000 },

            };
            string fbUrl = null;
            foreach(var item in employees)
            {
                if(item.Emid == Emid)
                {
                     fbUrl = "https://www.facebook.com/emp" + Emid;
                }
            }
            if( fbUrl == null)
            {
                return Content("invalid ID");
            }else
            {
                return Redirect(fbUrl);
            }

        }
        public ActionResult EmDetail()

        {
            //viewbag lay du lieu doi tuong tu controller

            ViewBag.EmId = 101;
            ViewBag.Name = "DUc";
            ViewBag.Salary = 5000;
            ViewBag.Gender = "M";
            ViewBag.Year = 2019;
            ViewBag.Positions = new List<string> { "Security", "Technician", "Manager" };
            return View();
        }
    }
}