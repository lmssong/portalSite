using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:JobZijianType
	/// </summary>
	public partial class JobZijianType
	{
		public JobZijianType()
		{}
		#region  Method
       



		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JobZijianType");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.JobZijianType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JobZijianType(");
			strSql.Append("JobTitleName)");
			strSql.Append(" values (");
			strSql.Append("@JobTitleName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@JobTitleName", SqlDbType.VarChar,200)};
			parameters[0].Value = model.JobTitleName;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.JobZijianType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JobZijianType set ");
			strSql.Append("JobTitleName=@JobTitleName");
			strSql.Append(" where JobTitleID=@JobTitleID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobTitleID", SqlDbType.Int,4),
					new SqlParameter("@JobTitleName", SqlDbType.VarChar,200)};
			parameters[0].Value = model.JobTitleID;
			parameters[1].Value = model.JobTitleName;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JobTitleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobZijianType ");
			strSql.Append(" where JobTitleID=@JobTitleID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobTitleID", SqlDbType.Int,4)
};
			parameters[0].Value = JobTitleID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JobTitleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobZijianType ");
			strSql.Append(" where JobTitleID in ("+JobTitleIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.JobZijianType GetModel(int JobTitleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JobTitleID,JobTitleName from JobZijianType ");
			strSql.Append(" where JobTitleID=@JobTitleID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobTitleID", SqlDbType.Int,4)
};
			parameters[0].Value = JobTitleID;

			Maticsoft.Model.JobZijianType model=new Maticsoft.Model.JobZijianType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["JobTitleID"].ToString()!="")
				{
					model.JobTitleID=int.Parse(ds.Tables[0].Rows[0]["JobTitleID"].ToString());
				}
				model.JobTitleName=ds.Tables[0].Rows[0]["JobTitleName"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select JobTitleID,JobTitleName ");
			strSql.Append(" FROM JobZijianType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" JobTitleID,JobTitleName ");
			strSql.Append(" FROM JobZijianType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "JobZijianType";
			parameters[1].Value = "JobTitleID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

