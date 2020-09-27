using MetaShare.Common.Core.CommonService;
using base_platform.Services.Interfaces.basesrc;
using base_platform.Services.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(Isys_resourceService), new sys_resourceService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
