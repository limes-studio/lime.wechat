using System.Web.Mvc;

namespace Lime.Weixin.Web.Areas.AppSystem
{
    public class AppSystemAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AppSystem";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AppSystem_default",
                "AppSystem/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
