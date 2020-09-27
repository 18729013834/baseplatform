using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using base_platform.Daos.Interfaces.basesrc;
using base_platform.Entities.basesrc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Daos.basesrc
{
	public class sys_resourceDao : CommonObjectDao<sys_resource>, Isys_resourceDao
	{
		public class sys_resourceSqlBuilder : ObjectSqlBuilder
		{
			public sys_resourceSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"sys_resource")
			{
				this.SqlInsert = "INSERT INTO sys_resource (icon_class,create_user,remark,sort,parent_id,is_show,btn_type,create_time,url,update_user,update_time,tree_level,type,deleted," + this.SqlBaseFieldInsertFront + ") VALUES (@icon_class,@create_user,@remark,@sort,@parent_id,@is_show,@btn_type,@create_time,@url,@update_user,@update_time,@tree_level,@type,@deleted," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE sys_resource SET icon_class=@icon_class,create_user=@create_user,remark=@remark,sort=@sort,parent_id=@parent_id,is_show=@is_show,btn_type=@btn_type,create_time=@create_time,url=@url,update_user=@update_user,update_time=@update_time,tree_level=@tree_level,type=@type,deleted=@deleted," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class sys_resourceResultHandler : CommonObjectResultHandler<sys_resource>
		{
			public override void GetColumnValues(IDataReader reader, sys_resource item)
			{
				base.GetColumnValues(reader, item);
				int ordinalurl = reader.GetOrdinal("url");
				item.url = reader.IsDBNull(ordinalurl) ? null : reader.GetString(ordinalurl);
				int ordinalparent_id = reader.GetOrdinal("parent_id");
				item.parent_id = reader.IsDBNull(ordinalparent_id) ? 0 : reader.GetInt32(ordinalparent_id);
				int ordinaltree_level = reader.GetOrdinal("tree_level");
				item.tree_level =  reader.IsDBNull(ordinaltree_level) ? 0 : reader.GetDouble(ordinaltree_level);
				int ordinaldeleted = reader.GetOrdinal("deleted");
				item.deleted = !reader.IsDBNull(ordinaldeleted) && reader.GetBoolean(ordinaldeleted);
				int ordinalupdate_time = reader.GetOrdinal("update_time");
				item.update_time = reader.IsDBNull(ordinalupdate_time) ? DateTime.MinValue : reader.GetDateTime(ordinalupdate_time);
				int ordinalis_show = reader.GetOrdinal("is_show");
				item.is_show = !reader.IsDBNull(ordinalis_show) && reader.GetBoolean(ordinalis_show);
				int ordinalicon_class = reader.GetOrdinal("icon_class");
				item.icon_class = reader.IsDBNull(ordinalicon_class) ? null : reader.GetString(ordinalicon_class);
				int ordinalupdate_user = reader.GetOrdinal("update_user");
				item.update_user = reader.IsDBNull(ordinalupdate_user) ? null : reader.GetString(ordinalupdate_user);
				int ordinalbtn_type = reader.GetOrdinal("btn_type");
				item.btn_type = reader.IsDBNull(ordinalbtn_type) ? decimal.MinValue : reader.GetDecimal(ordinalbtn_type);
				int ordinalcreate_user = reader.GetOrdinal("create_user");
				item.create_user = reader.IsDBNull(ordinalcreate_user) ? null : reader.GetString(ordinalcreate_user);
				int ordinalremark = reader.GetOrdinal("remark");
				item.remark = reader.IsDBNull(ordinalremark) ? null : reader.GetString(ordinalremark);
				int ordinalcreate_time = reader.GetOrdinal("create_time");
				item.create_time = reader.IsDBNull(ordinalcreate_time) ? DateTime.MinValue : reader.GetDateTime(ordinalcreate_time);
				int ordinaltype = reader.GetOrdinal("type");
				item.type = reader.IsDBNull(ordinaltype) ? null : reader.GetString(ordinaltype);
				int ordinalsort = reader.GetOrdinal("sort");
				item.sort = reader.IsDBNull(ordinalsort) ? decimal.MinValue : reader.GetDecimal(ordinalsort);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, sys_resource item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "url", item.url ?? (object) DBNull.Value);
				context.AddParameter(command, "parent_id", item.parent_id);
				context.AddParameter(command, "tree_level", item.tree_level);
				context.AddParameter(command, "deleted", item.deleted);
				context.AddParameter(command, "update_time", item.update_time == DateTime.MinValue ? (object)DBNull.Value : item.update_time);
				context.AddParameter(command, "is_show", item.is_show);
				context.AddParameter(command, "icon_class", item.icon_class ?? (object) DBNull.Value);
				context.AddParameter(command, "update_user", item.update_user ?? (object) DBNull.Value);
				context.AddParameter(command, "btn_type", item.btn_type);
				context.AddParameter(command, "create_user", item.create_user ?? (object) DBNull.Value);
				context.AddParameter(command, "remark", item.remark ?? (object) DBNull.Value);
				context.AddParameter(command, "create_time", item.create_time == DateTime.MinValue ? (object)DBNull.Value : item.create_time);
				context.AddParameter(command, "type", item.type ?? (object) DBNull.Value);
				context.AddParameter(command, "sort", item.sort);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public sys_resourceDao(SqlDialect sqlDialect) : base(new sys_resourceSqlBuilder(sqlDialect), new sys_resourceResultHandler())
		{
		}

		public sys_resourceDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new sys_resourceSqlBuilder(sqlDialect), new sys_resourceResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
