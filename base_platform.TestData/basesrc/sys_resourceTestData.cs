using System;
using System.Collections.Generic;
using NUnit.Framework;
using base_platform.Entities.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.TestData.basesrc
{
	public class sys_resourceTestData
	{
		public const int sys_resourceCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<sys_resource> Createsys_resource()
		{
			return new List<sys_resource>
			{
				Createsys_resource1(),
				Createsys_resource2(),
				Createsys_resource3(),
			};
		}

		 public static sys_resource Createsys_resource1()
		{
			return new sys_resource
			{
					Id = 1, 
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
		}
		 public static sys_resource Createsys_resource2()
		{
			return new sys_resource
			{
					Id = 2, 
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
		}
		 public static sys_resource Createsys_resource3()
		{
			return new sys_resource
			{
					Id = 3, 
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
		}
		public static void AssertAreEqual(sys_resource expected, sys_resource actual)
		{
			Assert.AreEqual(expected.url, actual.url);
			Assert.AreEqual(expected.parent_id, actual.parent_id);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.tree_level, actual.tree_level);
			Assert.AreEqual(expected.deleted, actual.deleted);
			Assert.AreEqual(expected.update_time, actual.update_time);
			Assert.AreEqual(expected.is_show, actual.is_show);
			Assert.AreEqual(expected.icon_class, actual.icon_class);
			Assert.AreEqual(expected.update_user, actual.update_user);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.btn_type, actual.btn_type);
			Assert.AreEqual(expected.create_user, actual.create_user);
			Assert.AreEqual(expected.remark, actual.remark);
			Assert.AreEqual(expected.create_time, actual.create_time);
			Assert.AreEqual(expected.type, actual.type);
			Assert.AreEqual(expected.sort, actual.sort);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
