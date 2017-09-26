using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string user,string pass)
        {
            if (user == "123" && pass == "123")
            {
                Session["user"] = user;
                return RedirectToAction("index", "Home");
            }
            return Content("登录失败");
        }
    }
}