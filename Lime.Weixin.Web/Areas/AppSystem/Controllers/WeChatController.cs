using Lime.Weixin.MP.AdvancedAPIs;
using Lime.Weixin.MP.CommonAPIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lime.Weixin.Web.Areas.AppSystem.Controllers
{
    public class WeChatController : Controller
    {
        private static readonly String _appId = "";
        //
        // GET: /AppSystem/WeChat/

        public ActionResult Index()
        {
            return PartialView();
        }

        public PartialViewResult Material()
        {
           
            return PartialView();
        }
        public PartialViewResult CustomerMenu()
        {
            return PartialView();
        }
    }
}
