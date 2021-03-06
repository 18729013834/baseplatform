﻿using System.Web.Mvc;/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Web
{
    public class AreaViewEngine:RazorViewEngine
    {
        public AreaViewEngine()
        {
            this.AreaViewLocationFormats = new[] {"~/Views/{2}/{1}/{0}.cshtml","~/Views/Shared/{0}.cshtml"};

            this.AreaMasterLocationFormats = new[] { "~/Views/Shared/{0}.cshtml" };

            this.AreaPartialViewLocationFormats = new[] { "~/Views/{2}/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" }; 

            this.ViewLocationFormats = new[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" }; 
            
            this.MasterLocationFormats = new[] { "~/Views/Shared/{0}.cshtml" };  
            
            this.PartialViewLocationFormats = new[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" }; /*add customized code between this region*/
/*add customized code between this region*/

        }
    }
}