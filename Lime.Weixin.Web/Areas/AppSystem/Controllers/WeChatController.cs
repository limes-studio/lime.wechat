using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lime.Weixin.Web.Areas.AppSystem.Controllers
{
    public class WeChatController : Controller
    {
        //
        // GET: /AppSystem/WeChat/

        public ActionResult Index()
        {
            return Content("ddd");
        }

        public PartialViewResult Material()
        {
            return PartialView();
        }

    }
}
