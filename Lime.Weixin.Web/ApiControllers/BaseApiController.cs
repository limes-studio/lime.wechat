using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;

namespace Lime.Weixin.Web.ApiControllers
{
    public class BaseApiController : ApiController
    {
        private static readonly string _AppId = WebConfigurationManager.AppSettings["WeixinAppId"];
        private static readonly string _AppSecret = WebConfigurationManager.AppSettings["WeixinAppSecret"];

        public static class WeChatConfig
        {
            public static string AppId { get { return _AppId; } }
            public static  string AppSecret { get { return _AppSecret; } }



        }
    }
}