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
            //MagickNET.Initialize(@"C:\Git\cimg");
            MagickNET.SetTempDirectory(@"C:\Git\cimg");

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
