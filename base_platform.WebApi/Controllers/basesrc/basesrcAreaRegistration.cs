using System.Web.Http;
using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.WebApi.Controllers.basesrc
{
	public class basesrcAreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.Routes.MapHttpRoute(
			name:"basesrc",
			routeTemplate:"basesrc/{controller}/{action}/{id}",
			defaults:new 
			{
				area = "basesrc",
				action = "Index",
				id = UrlParameter.Optional,
				namespaceName = new[] {"base_platform.WebApi.Controllers.basesrc"}
			});
		}

		public override string AreaName
		{
			get { return "basesrc"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
