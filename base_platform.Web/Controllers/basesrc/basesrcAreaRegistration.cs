using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Web.Controllers.basesrc
{
	public class basesrcAreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			"basesrc",
			"basesrc/{controller}/{action}/{id}",
			new {action = "Index", id = UrlParameter.Optional},
			namespaces:new[]  {"base_platform.Web.Controllers.basesrc"});
		}

		public override string AreaName
		{
			get { return "basesrc"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
