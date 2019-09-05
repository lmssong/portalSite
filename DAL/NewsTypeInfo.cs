using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:NewsTypeInfo
	/// </summary>
	public partial class NewsTypeInfo
	{
		public NewsTypeInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NewsTypeID", "NewsTypeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NewsTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NewsTypeInfo");
			strSql.Append(" where NewsTypeID=@NewsTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4)};
			parameters[0].Value = NewsTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.NewsTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NewsTypeInfo(");
			strSql.Append("NewsTypeTitle)");
			strSql.Append(" values (");
			strSql.Append("@NewsTypeTitle)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsTypeTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NewsTypeTitle;

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
		public bool Update(Maticsoft.Model.NewsTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NewsTypeInfo set ");
			strSql.Append("NewsTypeTitle=@NewsTypeTitle");
			strSql.Append(" where NewsTypeID=@NewsTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4),
					new SqlParameter("@NewsTypeTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NewsTypeID;
			parameters[1].Value = model.NewsTypeTitle;

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
		public bool Delete(int NewsTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewsTypeInfo ");
			strSql.Append(" where NewsTypeID=@NewsTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsTypeID;

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
		public bool DeleteList(string NewsTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewsTypeInfo ");
			strSql.Append(" where NewsTypeID in ("+NewsTypeIDlist + ")  ");
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
		public Maticsoft.Model.NewsTypeInfo GetModel(int NewsTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NewsTypeID,NewsTypeTitle from NewsTypeInfo ");
			strSql.Append(" where NewsTypeID=@NewsTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsTypeID;

			Maticsoft.Model.NewsTypeInfo model=new Maticsoft.Model.NewsTypeInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NewsTypeID"].ToString()!="")
				{
					model.NewsTypeID=int.Parse(ds.Tables[0].Rows[0]["NewsTypeID"].ToString());
				}
				model.NewsTypeTitle=ds.Tables[0].Rows[0]["NewsTypeTitle"].ToString();
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
			strSql.Append("select NewsTypeID,NewsTypeTitle ");
			strSql.Append(" FROM NewsTypeInfo ");
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
			strSql.Append(" NewsTypeID,NewsTypeTitle ");
			strSql.Append(" FROM NewsTypeInfo ");
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
			parameters[0].Value = "NewsTypeInfo";
			parameters[1].Value = "NewsTypeID";
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

