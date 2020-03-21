using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freelancerDotNetMvc.Controllers
{
    public class MastheadController : Controller
    {
        // GET: Masthead
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}