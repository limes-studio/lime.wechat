using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Lime.Image.Service
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            string temPath = string.Format(@"{0}\imagemagicTemp",HttpRuntime.AppDomainAppPath);
            if (!System.IO.Directory.Exists(temPath))
            {
                System.IO.Directory.CreateDirectory(temPath);
            }
            //MagickNET.Initialize(@"C:\Git\cimg");
            MagickNET.SetTempDirectory(temPath);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
