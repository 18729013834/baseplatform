﻿using System.Web.Http;/*add customized code between this region*/
/*add customized code between this region*/


namespace base_platform.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );/*add customized code between this region*/
/*add customized code between this region*/

        }
    }
}