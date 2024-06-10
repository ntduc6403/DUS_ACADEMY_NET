using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProJect.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        
        public ActionResult Login(string username, string password)
        {
            
            if(username == "admin" && password == "manager") {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("IvalidLogin");
            }
        }
        
        public ActionResult IvalidLogin() { 
            return View();
        }
    }
}