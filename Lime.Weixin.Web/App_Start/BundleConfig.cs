using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Lime.Weixin.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bootstrap").Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/adminLteJs").Include("~/admin-lte/js/app.min.js"));

            bundles.Add(new ScriptBundle("~/compatibility").Include("~/Scripts/respond.min.js",
                "~/Scripts/html5shiv.min.js"
                ));

            bundles.Add(new StyleBundle("~/adminLteStyle").Include(
                "~/Content/bootstrap.min.css",
               // "~/Content/css/font-awesome.min.css",
                "~/admin-lte/css/AdminLTE.min.css",
                "~/admin-lte/css/skins/skin-blue.min.css",
                "~/Content/css/ionicons.min.css"
          ));
            // Code removed for clarity.
        }
    }
}