using System;
using System.Collections.Generic;
using System.Web.Mvc;
using base_platform.Entities.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Web.Models.basesrc
{
	public class sys_resourceModel: CommonModel<sys_resource>
	{
		public string url {get; set;}
		public int parent_id {get; set;}
		public double tree_level {get; set;}
		public bool deleted {get; set;}
		public DateTime update_time {get; set;}
		public bool is_show {get; set;}
		public string icon_class {get; set;}
		public string update_user {get; set;}
		public decimal btn_type {get; set;}
		public string create_user {get; set;}
		public string remark {get; set;}
		public DateTime create_time {get; set;}
		public string type {get; set;}
		public decimal sort {get; set;}

		public override void PopulateFrom(sys_resource entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.url = entity.url;
			this.parent_id = entity.parent_id;
			this.tree_level = entity.tree_level;
			this.deleted = entity.deleted;
			this.update_time = entity.update_time;
			this.is_show = entity.is_show;
			this.icon_class = entity.icon_class;
			this.update_user = entity.update_user;
			this.btn_type = entity.btn_type;
			this.create_user = entity.create_user;
			this.remark = entity.remark;
			this.create_time = entity.create_time;
			this.type = entity.type;
			this.sort = entity.sort;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(sys_resource entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.url = this.url;

			entity.parent_id = this.parent_id;

			entity.tree_level = this.tree_level;

			entity.deleted = this.deleted;

			entity.update_time = this.update_time;

			entity.is_show = this.is_show;

			entity.icon_class = this.icon_class;

			entity.update_user = this.update_user;

			entity.btn_type = this.btn_type;

			entity.create_user = this.create_user;

			entity.remark = this.remark;

			entity.create_time = this.create_time;

			entity.type = this.type;

			entity.sort = this.sort;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
