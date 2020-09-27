using System.Collections.Generic;
using base_platform.Services.Interfaces.basesrc;
using base_platform.Entities.basesrc;
using base_platform.Web.Models.basesrc;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using base_platform.Web.Models;

/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Web.Controllers.basesrc
{
	public class sys_resourceController:CommonController<sys_resource, Isys_resourceService, sys_resourceModel>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "basesrc_sys_resource";
		}


		protected override List<sys_resource> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<sys_resource> lists = this.Service.SelectBy(pagerSearchModel.Pager,new sys_resource { Name = pagerSearchModel.Name }, sys_resource => sys_resource.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
