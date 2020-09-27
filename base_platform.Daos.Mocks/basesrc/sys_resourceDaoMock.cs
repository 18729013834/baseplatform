using MetaShare.Common.Core.Daos;
using base_platform.Entities.basesrc;
using base_platform.Daos.Interfaces.basesrc;
using base_platform.TestData.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Daos.Mocks.basesrc
{
	public class sys_resourceDaoMock : MockDao<sys_resource>, Isys_resourceDao
	{
		public sys_resourceDaoMock() : base(sys_resourceTestData.Createsys_resource())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
