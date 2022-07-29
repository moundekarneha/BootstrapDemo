using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ViewResult Login()
        {
            return View();
        }
    }
}