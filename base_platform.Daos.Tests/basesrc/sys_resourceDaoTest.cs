using System.Collections.Generic;
using NUnit.Framework;
using System;
using base_platform.Daos.Interfaces.basesrc;
using base_platform.Daos.DataSchema.basesrc;
using base_platform.TestData.basesrc;
using base_platform.Daos.Tests.Common;
using base_platform.Entities.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Daos.Tests.basesrc
{
	public class sys_resourceDaoTest : CommonDaoTest<sys_resource, Isys_resourceDao, sys_resourceDdlBuilder>
	{
		public sys_resourceDaoTest() : base(sys_resourceTestData.Createsys_resource())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(sys_resourceTestData.sys_resourceCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			sys_resource item = sys_resourceTestData.Createsys_resource1();
			sys_resource find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			sys_resourceTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			sys_resource item = new sys_resource
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
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			sys_resource find = this.Dao.SelectById(this.Context, item);
			sys_resourceTestData.AssertAreEqual(item, find);

			List<sys_resource> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(sys_resourceTestData.sys_resourceCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			sys_resource item = sys_resourceTestData.Createsys_resource1();
			sys_resource beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.url = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			sys_resource afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			sys_resourceTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			sys_resource item = sys_resourceTestData.Createsys_resource1();
			sys_resource beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			sys_resource afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<sys_resource> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(sys_resourceTestData.sys_resourceCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
