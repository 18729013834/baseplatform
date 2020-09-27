using MetaShare.Common.Core.Daos;
using base_platform.Daos.Interfaces.basesrc;
using base_platform.Daos.Mocks.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(Isys_resourceDao), new sys_resourceDaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
