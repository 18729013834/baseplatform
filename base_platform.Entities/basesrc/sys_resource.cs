using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Entities.basesrc
{
	public class sys_resource : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public string url {get; set;}

		[DataMember]
		public int parent_id {get; set;}

		[DataMember]
		public double tree_level {get; set;}

		[DataMember]
		public bool deleted {get; set;}

		[DataMember]
		public DateTime update_time {get; set;}

		[DataMember]
		public bool is_show {get; set;}

		[DataMember]
		public string icon_class {get; set;}

		[DataMember]
		public string update_user {get; set;}

		[DataMember]
		public decimal btn_type {get; set;}

		[DataMember]
		public string create_user {get; set;}

		[DataMember]
		public string remark {get; set;}

		[DataMember]
		public DateTime create_time {get; set;}

		[DataMember]
		public string type {get; set;}

		[DataMember]
		public decimal sort {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
