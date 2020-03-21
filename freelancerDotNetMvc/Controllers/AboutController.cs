using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freelancerDotNetMvc.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        [Route("about")]
        public ActionResult Index()
        {
            ViewBag.about = "active";
            return View();
        }
    }
}