using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using base_platform.Entities.basesrc;
using MetaShare.Common.Core.Services;
using base_platform.Daos.Interfaces.basesrc;
using base_platform.Services.Interfaces.basesrc;

/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Services.basesrc
{
	public class sys_resourceService : Service<sys_resource>, Isys_resourceService
	{
		public sys_resourceService() : base(typeof (Isys_resourceDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
