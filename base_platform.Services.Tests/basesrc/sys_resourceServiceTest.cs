using System;
using System.Collections.Generic;
using NUnit.Framework;
using base_platform.Entities.basesrc;
using base_platform.TestData.basesrc;
using base_platform.Services.Tests.Common;
using base_platform.Services.Interfaces.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Services.Tests.basesrc
{

	[TestFixture]
	public class sys_resourceServiceTest : CommonServiceTest<sys_resource, Isys_resourceService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<sys_resource> items = this.Service.SelectAll();
			Assert.AreEqual(sys_resourceTestData.sys_resourceCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			sys_resource itemTest = sys_resourceTestData.Createsys_resource1();

			List<sys_resource> find = this.Service.SelectBy(new sys_resource {url = itemTest.url}, new List<string> {"url"});
			Assert.IsNotNull(find);

			foreach (sys_resource item in find)
			{
				Assert.AreEqual(itemTest.url, item.url);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			sys_resource itemTest = sys_resourceTestData.Createsys_resource1();

			sys_resource find = this.Service.SelectById(new sys_resource {Id = itemTest.Id});
			Assert.IsNotNull(find);

			sys_resourceTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			sys_resource itemTest = sys_resourceTestData.Createsys_resource2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<sys_resource> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, sys_resourceTestData.sys_resourceCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			sys_resource itemTest = new sys_resource
			{
				url = string.Empty, 
				parent_id = 0, 
				Description = string.Empty, 
				tree_level = 0.0d, 
				deleted = false, 
				update_time = new DateTime(2017,12,28), 
				is_show = false, 
				icon_class = string.Empty, 
				update_user = string.Empty, 
				Name = string.Empty, 
				btn_type = 1.0m, 
				create_user = string.Empty, 
				remark = string.Empty, 
				create_time = new DateTime(2017,12,28), 
				type = string.Empty, 
				sort = 1.0m, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<sys_resource> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, sys_resourceTestData.sys_resourceCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			sys_resource itemTest = sys_resourceTestData.Createsys_resource1();

			sys_resource beforeUpdate = this.Service.SelectById(new sys_resource {Id = itemTest.Id});
			beforeUpdate.url = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			sys_resource afterUpdate = this.Service.SelectById(new sys_resource {Id = itemTest.Id});
			sys_resourceTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
