using System;
using MetaShare.Common.Core.Daos;
using base_platform.Daos.Interfaces.basesrc;
using base_platform.Daos.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}

		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}

		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(Isys_resourceDao), new sys_resourceDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
