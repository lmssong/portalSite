using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ComPany
	/// </summary>
	public partial class ComPany
	{
		public ComPany()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CompanyID", "ComPany"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CompanyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ComPany");
			strSql.Append(" where CompanyID=@CompanyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
			parameters[0].Value = CompanyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.ComPany model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ComPany(");
			strSql.Append("CompanyNames,CompanyType,Fanren,ComAddress,ComFax,ComPhoto,ComEmail,QQ,Comwangzhi,comconten)");
			strSql.Append(" values (");
			strSql.Append("@CompanyNames,@CompanyType,@Fanren,@ComAddress,@ComFax,@ComPhoto,@ComEmail,@QQ,@Comwangzhi,@comconten)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyNames", SqlDbType.VarChar,200),
					new SqlParameter("@CompanyType", SqlDbType.VarChar,200),
					new SqlParameter("@Fanren", SqlDbType.VarChar,200),
					new SqlParameter("@ComAddress", SqlDbType.Text),
					new SqlParameter("@ComFax", SqlDbType.VarChar,200),
					new SqlParameter("@ComPhoto", SqlDbType.VarChar,200),
					new SqlParameter("@ComEmail", SqlDbType.VarChar,200),
					new SqlParameter("@QQ", SqlDbType.VarChar,200),
					new SqlParameter("@Comwangzhi", SqlDbType.Text),
					new SqlParameter("@comconten", SqlDbType.Text)};
			parameters[0].Value = model.CompanyNames;
			parameters[1].Value = model.CompanyType;
			parameters[2].Value = model.Fanren;
			parameters[3].Value = model.ComAddress;
			parameters[4].Value = model.ComFax;
			parameters[5].Value = model.ComPhoto;
			parameters[6].Value = model.ComEmail;
			parameters[7].Value = model.QQ;
			parameters[8].Value = model.Comwangzhi;
			parameters[9].Value = model.comconten;

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
		public bool Update(Maticsoft.Model.ComPany model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ComPany set ");
			strSql.Append("CompanyNames=@CompanyNames,");
			strSql.Append("CompanyType=@CompanyType,");
			strSql.Append("Fanren=@Fanren,");
			strSql.Append("ComAddress=@ComAddress,");
			strSql.Append("ComFax=@ComFax,");
			strSql.Append("ComPhoto=@ComPhoto,");
			strSql.Append("ComEmail=@ComEmail,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("Comwangzhi=@Comwangzhi,");
			strSql.Append("comconten=@comconten");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@CompanyNames", SqlDbType.VarChar,200),
					new SqlParameter("@CompanyType", SqlDbType.VarChar,200),
					new SqlParameter("@Fanren", SqlDbType.VarChar,200),
					new SqlParameter("@ComAddress", SqlDbType.Text),
					new SqlParameter("@ComFax", SqlDbType.VarChar,200),
					new SqlParameter("@ComPhoto", SqlDbType.VarChar,200),
					new SqlParameter("@ComEmail", SqlDbType.VarChar,200),
					new SqlParameter("@QQ", SqlDbType.VarChar,200),
					new SqlParameter("@Comwangzhi", SqlDbType.Text),
					new SqlParameter("@comconten", SqlDbType.Text)};
			parameters[0].Value = model.CompanyID;
			parameters[1].Value = model.CompanyNames;
			parameters[2].Value = model.CompanyType;
			parameters[3].Value = model.Fanren;
			parameters[4].Value = model.ComAddress;
			parameters[5].Value = model.ComFax;
			parameters[6].Value = model.ComPhoto;
			parameters[7].Value = model.ComEmail;
			parameters[8].Value = model.QQ;
			parameters[9].Value = model.Comwangzhi;
			parameters[10].Value = model.comconten;

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
		public bool Delete(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ComPany ");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)
};
			parameters[0].Value = CompanyID;

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
		public bool DeleteList(string CompanyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ComPany ");
			strSql.Append(" where CompanyID in ("+CompanyIDlist + ")  ");
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
		public Maticsoft.Model.ComPany GetModel(int CompanyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyID,CompanyNames,CompanyType,Fanren,ComAddress,ComFax,ComPhoto,ComEmail,QQ,Comwangzhi,comconten from ComPany ");
			strSql.Append(" where CompanyID=@CompanyID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)
};
			parameters[0].Value = CompanyID;

			Maticsoft.Model.ComPany model=new Maticsoft.Model.ComPany();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
				}
				model.CompanyNames=ds.Tables[0].Rows[0]["CompanyNames"].ToString();
				model.CompanyType=ds.Tables[0].Rows[0]["CompanyType"].ToString();
				model.Fanren=ds.Tables[0].Rows[0]["Fanren"].ToString();
				model.ComAddress=ds.Tables[0].Rows[0]["ComAddress"].ToString();
				model.ComFax=ds.Tables[0].Rows[0]["ComFax"].ToString();
				model.ComPhoto=ds.Tables[0].Rows[0]["ComPhoto"].ToString();
				model.ComEmail=ds.Tables[0].Rows[0]["ComEmail"].ToString();
				model.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				model.Comwangzhi=ds.Tables[0].Rows[0]["Comwangzhi"].ToString();
				model.comconten=ds.Tables[0].Rows[0]["comconten"].ToString();
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
			strSql.Append("select CompanyID,CompanyNames,CompanyType,Fanren,ComAddress,ComFax,ComPhoto,ComEmail,QQ,Comwangzhi,comconten ");
			strSql.Append(" FROM ComPany ");
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
			strSql.Append(" CompanyID,CompanyNames,CompanyType,Fanren,ComAddress,ComFax,ComPhoto,ComEmail,QQ,Comwangzhi,comconten ");
			strSql.Append(" FROM ComPany ");
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
			parameters[0].Value = "ComPany";
			parameters[1].Value = "CompanyID";
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

