using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:NicheTypeInfo
	/// </summary>
	public partial class NicheTypeInfo
	{
		public NicheTypeInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NicheTypeID", "NicheTypeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NicheTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NicheTypeInfo");
			strSql.Append(" where NicheTypeID=@NicheTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheTypeID", SqlDbType.Int,4)};
			parameters[0].Value = NicheTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.NicheTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NicheTypeInfo(");
			strSql.Append("NicheTypeTitle)");
			strSql.Append(" values (");
			strSql.Append("@NicheTypeTitle)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheTypeTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NicheTypeTitle;

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
		public bool Update(Maticsoft.Model.NicheTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NicheTypeInfo set ");
			strSql.Append("NicheTypeTitle=@NicheTypeTitle");
			strSql.Append(" where NicheTypeID=@NicheTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheTypeID", SqlDbType.Int,4),
					new SqlParameter("@NicheTypeTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NicheTypeID;
			parameters[1].Value = model.NicheTypeTitle;

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
		public bool Delete(int NicheTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NicheTypeInfo ");
			strSql.Append(" where NicheTypeID=@NicheTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = NicheTypeID;

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
		public bool DeleteList(string NicheTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NicheTypeInfo ");
			strSql.Append(" where NicheTypeID in ("+NicheTypeIDlist + ")  ");
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
		public Maticsoft.Model.NicheTypeInfo GetModel(int NicheTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NicheTypeID,NicheTypeTitle from NicheTypeInfo ");
			strSql.Append(" where NicheTypeID=@NicheTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = NicheTypeID;

			Maticsoft.Model.NicheTypeInfo model=new Maticsoft.Model.NicheTypeInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NicheTypeID"].ToString()!="")
				{
					model.NicheTypeID=int.Parse(ds.Tables[0].Rows[0]["NicheTypeID"].ToString());
				}
				model.NicheTypeTitle=ds.Tables[0].Rows[0]["NicheTypeTitle"].ToString();
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
			strSql.Append("select NicheTypeID,NicheTypeTitle ");
			strSql.Append(" FROM NicheTypeInfo ");
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
			strSql.Append(" NicheTypeID,NicheTypeTitle ");
			strSql.Append(" FROM NicheTypeInfo ");
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
			parameters[0].Value = "NicheTypeInfo";
			parameters[1].Value = "NicheTypeID";
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

