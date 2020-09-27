using System.Web.Mvc;
using System.Web.Routing;/*add customized code between this region*/
/*add customized code between this region*/


namespace base_platform.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",defaults: new { controller = "sys_resource", action = "Index", id = UrlParameter.Optional },
				namespaces:new[]  {"base_platform.Web.Controllers.basesrc"});
				/*add customized code between this region*/
				/*add customized code between this region*/
				
        }
    }
}