using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ProductType
	/// </summary>
	public partial class ProductType
	{
		public ProductType()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ProTypeID", "ProductType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ProTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProductType");
			strSql.Append(" where ProTypeID=@ProTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProTypeID", SqlDbType.Int,4)};
			parameters[0].Value = ProTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.ProductType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ProductType(");
			strSql.Append("ProTypeTitle)");
			strSql.Append(" values (");
			strSql.Append("@ProTypeTitle)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProTypeTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ProTypeTitle;

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
		public bool Update(Maticsoft.Model.ProductType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ProductType set ");
			strSql.Append("ProTypeTitle=@ProTypeTitle");
			strSql.Append(" where ProTypeID=@ProTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@ProTypeTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ProTypeID;
			parameters[1].Value = model.ProTypeTitle;

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
		public bool Delete(int ProTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ProductType ");
			strSql.Append(" where ProTypeID=@ProTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = ProTypeID;

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
		public bool DeleteList(string ProTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ProductType ");
			strSql.Append(" where ProTypeID in ("+ProTypeIDlist + ")  ");
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
		public Maticsoft.Model.ProductType GetModel(int ProTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProTypeID,ProTypeTitle from ProductType ");
			strSql.Append(" where ProTypeID=@ProTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = ProTypeID;

			Maticsoft.Model.ProductType model=new Maticsoft.Model.ProductType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ProTypeID"].ToString()!="")
				{
					model.ProTypeID=int.Parse(ds.Tables[0].Rows[0]["ProTypeID"].ToString());
				}
				model.ProTypeTitle=ds.Tables[0].Rows[0]["ProTypeTitle"].ToString();
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
			strSql.Append("select ProTypeID,ProTypeTitle ");
			strSql.Append(" FROM ProductType ");
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
			strSql.Append(" ProTypeID,ProTypeTitle ");
			strSql.Append(" FROM ProductType ");
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
			parameters[0].Value = "ProductType";
			parameters[1].Value = "ProTypeID";
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

