using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ProductXing
	/// </summary>
	public partial class ProductXing
	{
		public ProductXing()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ProXingID", "ProductXing"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ProXingID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProductXing");
			strSql.Append(" where ProXingID=@ProXingID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProXingID", SqlDbType.Int,4)};
			parameters[0].Value = ProXingID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.ProductXing model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ProductXing(");
			strSql.Append("ProTypeID,ProXingTitle)");
			strSql.Append(" values (");
			strSql.Append("@ProTypeID,@ProXingTitle)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@ProXingTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ProTypeID;
			parameters[1].Value = model.ProXingTitle;

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
		public bool Update(Maticsoft.Model.ProductXing model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ProductXing set ");
			strSql.Append("ProTypeID=@ProTypeID,");
			strSql.Append("ProXingTitle=@ProXingTitle");
			strSql.Append(" where ProXingID=@ProXingID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProXingID", SqlDbType.Int,4),
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@ProXingTitle", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ProXingID;
			parameters[1].Value = model.ProTypeID;
			parameters[2].Value = model.ProXingTitle;

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
		public bool Delete(int ProXingID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ProductXing ");
			strSql.Append(" where ProXingID=@ProXingID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProXingID", SqlDbType.Int,4)
};
			parameters[0].Value = ProXingID;

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
		public bool DeleteList(string ProXingIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ProductXing ");
			strSql.Append(" where ProXingID in ("+ProXingIDlist + ")  ");
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
		public Maticsoft.Model.ProductXing GetModel(int ProXingID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProXingID,ProTypeID,ProXingTitle from ProductXing ");
			strSql.Append(" where ProXingID=@ProXingID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProXingID", SqlDbType.Int,4)
};
			parameters[0].Value = ProXingID;

			Maticsoft.Model.ProductXing model=new Maticsoft.Model.ProductXing();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ProXingID"].ToString()!="")
				{
					model.ProXingID=int.Parse(ds.Tables[0].Rows[0]["ProXingID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProTypeID"].ToString()!="")
				{
					model.ProTypeID=int.Parse(ds.Tables[0].Rows[0]["ProTypeID"].ToString());
				}
				model.ProXingTitle=ds.Tables[0].Rows[0]["ProXingTitle"].ToString();
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
			strSql.Append("select ProXingID,ProTypeID,ProXingTitle ");
			strSql.Append(" FROM ProductXing ");
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
			strSql.Append(" ProXingID,ProTypeID,ProXingTitle ");
			strSql.Append(" FROM ProductXing ");
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
			parameters[0].Value = "ProductXing";
			parameters[1].Value = "ProXingID";
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

