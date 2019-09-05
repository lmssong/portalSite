using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:FuWuInfo
	/// </summary>
	public partial class FuWuInfo
	{
		public FuWuInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetfuwuList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " fuwuID,fuwuTitle,Fatime,ImageURL,FuwuTypeID,Write,Fuwucontent ");
            strSql.Append(" FROM FuWuInfo ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  fuwuID not in (select top " + PageIndex + " fuwuID from FuWuInfo ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);

            }
            strSql.Append(" order by Fatime desc) order by Fatime desc");

            return DbHelperSQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetfuwuCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(fuwuID) ");
            strSql.Append(" FROM FuWuInfo ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);
            }

            count = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
            return count;
        }




		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("fuwuID", "FuWuInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int fuwuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FuWuInfo");
			strSql.Append(" where fuwuID=@fuwuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@fuwuID", SqlDbType.Int,4)};
			parameters[0].Value = fuwuID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.FuWuInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FuWuInfo(");
			strSql.Append("fuwuTitle,Fatime,ImageURL,FuwuTypeID,Write,Fuwucontent)");
			strSql.Append(" values (");
			strSql.Append("@fuwuTitle,@Fatime,@ImageURL,@FuwuTypeID,@Write,@Fuwucontent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@fuwuTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@FuwuTypeID", SqlDbType.Int,4),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@Fuwucontent", SqlDbType.Text)};
			parameters[0].Value = model.fuwuTitle;
			parameters[1].Value = model.Fatime;
			parameters[2].Value = model.ImageURL;
			parameters[3].Value = model.FuwuTypeID;
			parameters[4].Value = model.Write;
			parameters[5].Value = model.Fuwucontent;

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
		public bool Update(Maticsoft.Model.FuWuInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FuWuInfo set ");
			strSql.Append("fuwuTitle=@fuwuTitle,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("FuwuTypeID=@FuwuTypeID,");
			strSql.Append("Write=@Write,");
			strSql.Append("Fuwucontent=@Fuwucontent");
			strSql.Append(" where fuwuID=@fuwuID");
			SqlParameter[] parameters = {
					new SqlParameter("@fuwuID", SqlDbType.Int,4),
					new SqlParameter("@fuwuTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@FuwuTypeID", SqlDbType.Int,4),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@Fuwucontent", SqlDbType.Text)};
			parameters[0].Value = model.fuwuID;
			parameters[1].Value = model.fuwuTitle;
			parameters[2].Value = model.Fatime;
			parameters[3].Value = model.ImageURL;
			parameters[4].Value = model.FuwuTypeID;
			parameters[5].Value = model.Write;
			parameters[6].Value = model.Fuwucontent;

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
		public bool Delete(int fuwuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FuWuInfo ");
			strSql.Append(" where fuwuID=@fuwuID");
			SqlParameter[] parameters = {
					new SqlParameter("@fuwuID", SqlDbType.Int,4)
};
			parameters[0].Value = fuwuID;

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
		public bool DeleteList(string fuwuIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FuWuInfo ");
			strSql.Append(" where fuwuID in ("+fuwuIDlist + ")  ");
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
		public Maticsoft.Model.FuWuInfo GetModel(int fuwuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 fuwuID,fuwuTitle,Fatime,ImageURL,FuwuTypeID,Write,Fuwucontent from FuWuInfo ");
			strSql.Append(" where fuwuID=@fuwuID");
			SqlParameter[] parameters = {
					new SqlParameter("@fuwuID", SqlDbType.Int,4)
};
			parameters[0].Value = fuwuID;

			Maticsoft.Model.FuWuInfo model=new Maticsoft.Model.FuWuInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["fuwuID"].ToString()!="")
				{
					model.fuwuID=int.Parse(ds.Tables[0].Rows[0]["fuwuID"].ToString());
				}
				model.fuwuTitle=ds.Tables[0].Rows[0]["fuwuTitle"].ToString();
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				if(ds.Tables[0].Rows[0]["FuwuTypeID"].ToString()!="")
				{
					model.FuwuTypeID=int.Parse(ds.Tables[0].Rows[0]["FuwuTypeID"].ToString());
				}
				model.Write=ds.Tables[0].Rows[0]["Write"].ToString();
				model.Fuwucontent=ds.Tables[0].Rows[0]["Fuwucontent"].ToString();
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
			strSql.Append("select fuwuID,fuwuTitle,Fatime,ImageURL,FuwuTypeID,Write,Fuwucontent ");
			strSql.Append(" FROM FuWuInfo ");
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
			strSql.Append(" fuwuID,fuwuTitle,Fatime,ImageURL,FuwuTypeID,Write,Fuwucontent ");
			strSql.Append(" FROM FuWuInfo ");
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
			parameters[0].Value = "FuWuInfo";
			parameters[1].Value = "fuwuID";
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

