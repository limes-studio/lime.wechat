using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lime.Weixin.Web.Areas.AppSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /AppSystem/Home/
        [HttpGet]
        [ActionName("Home")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
