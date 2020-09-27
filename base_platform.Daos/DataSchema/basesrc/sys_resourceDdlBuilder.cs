using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace base_platform.Daos.DataSchema.basesrc
{
	public class sys_resourceDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE sys_resource(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,url nvarchar(255),parent_id int,Description nvarchar(255),tree_level decimal(18,2),deleted bit,update_time datetime2,is_show bit,icon_class nvarchar(255),update_user nvarchar(255),name nvarchar(255),btn_type decimal(18,2),create_user nvarchar(255),remark nvarchar(255),create_time datetime2,type nvarchar(255),sort decimal(18,2),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE sys_resource";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'sys_resource'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
