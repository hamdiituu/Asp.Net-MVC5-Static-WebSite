using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freelancerDotNetMvc.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [Route("contact")]
        public ActionResult Index()
        {
            ViewBag.contact = "active";
            return View();
        }
    }
}