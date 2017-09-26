using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filter.Filter;

namespace Filter.Controllers
{
    [Author]
    public class HomeController : Controller
    {
        // GET: Home
       // [OutputCache(Duration =10)]
       [OutputCache(CacheProfile = "Cache1Hour")]
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now;
            return View();
        }
        public ActionResult Yz()
        {
            return Content("登录后才可查看");
        }
    }
}