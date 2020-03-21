using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freelancerDotNetMvc.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        [Route("portfolio")]
        public ActionResult Index()
        {
            ViewBag.portfolio = "active";
            return View();
        }
    }
}