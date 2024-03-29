using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tupian
	/// </summary>
	public partial class tupian
	{
		public tupian()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "tupian"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tupian");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tupian model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tupian(");
			strSql.Append("ImageURL1,ImageURL2,ImageURL3,ImageURL4)");
			strSql.Append(" values (");
			strSql.Append("@ImageURL1,@ImageURL2,@ImageURL3,@ImageURL4)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ImageURL1", SqlDbType.Text),
					new SqlParameter("@ImageURL2", SqlDbType.Text),
					new SqlParameter("@ImageURL3", SqlDbType.Text),
					new SqlParameter("@ImageURL4", SqlDbType.Text)};
			parameters[0].Value = model.ImageURL1;
			parameters[1].Value = model.ImageURL2;
			parameters[2].Value = model.ImageURL3;
			parameters[3].Value = model.ImageURL4;

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
		public bool Update(Maticsoft.Model.tupian model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tupian set ");
			strSql.Append("ImageURL1=@ImageURL1,");
			strSql.Append("ImageURL2=@ImageURL2,");
			strSql.Append("ImageURL3=@ImageURL3,");
			strSql.Append("ImageURL4=@ImageURL4");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@ImageURL1", SqlDbType.Text),
					new SqlParameter("@ImageURL2", SqlDbType.Text),
					new SqlParameter("@ImageURL3", SqlDbType.Text),
					new SqlParameter("@ImageURL4", SqlDbType.Text)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.ImageURL1;
			parameters[2].Value = model.ImageURL2;
			parameters[3].Value = model.ImageURL3;
			parameters[4].Value = model.ImageURL4;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tupian ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tupian ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public Maticsoft.Model.tupian GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ImageURL1,ImageURL2,ImageURL3,ImageURL4 from tupian ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			Maticsoft.Model.tupian model=new Maticsoft.Model.tupian();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.ImageURL1=ds.Tables[0].Rows[0]["ImageURL1"].ToString();
				model.ImageURL2=ds.Tables[0].Rows[0]["ImageURL2"].ToString();
				model.ImageURL3=ds.Tables[0].Rows[0]["ImageURL3"].ToString();
				model.ImageURL4=ds.Tables[0].Rows[0]["ImageURL4"].ToString();
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
			strSql.Append("select id,ImageURL1,ImageURL2,ImageURL3,ImageURL4 ");
			strSql.Append(" FROM tupian ");
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
			strSql.Append(" id,ImageURL1,ImageURL2,ImageURL3,ImageURL4 ");
			strSql.Append(" FROM tupian ");
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
			parameters[0].Value = "tupian";
			parameters[1].Value = "id";
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

