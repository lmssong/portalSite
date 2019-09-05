using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:NewsInfo
	/// </summary>
	public partial class NewsInfo
	{
		public NewsInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GeNewsList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM NewsInfo ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  NewsID not in (select top " + PageIndex + " NewsID from NewsInfo ");
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
        public int GetNewCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM NewsInfo ");
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
		return DbHelperSQL.GetMaxID("NewsID", "NewsInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NewsID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NewsInfo");
			strSql.Append(" where NewsID=@NewsID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4)};
			parameters[0].Value = NewsID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.NewsInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NewsInfo(");
			strSql.Append("NewsTitle,NewsKey,Write,NewsTypeID,Fatime,ImageURL,HitNum,NewsContent)");
			strSql.Append(" values (");
			strSql.Append("@NewsTitle,@NewsKey,@Write,@NewsTypeID,@Fatime,@ImageURL,@HitNum,@NewsContent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,200),
					new SqlParameter("@NewsKey", SqlDbType.VarChar,200),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@NewsContent", SqlDbType.Text)};
			parameters[0].Value = model.NewsTitle;
			parameters[1].Value = model.NewsKey;
			parameters[2].Value = model.Write;
			parameters[3].Value = model.NewsTypeID;
			parameters[4].Value = model.Fatime;
			parameters[5].Value = model.ImageURL;
			parameters[6].Value = model.HitNum;
			parameters[7].Value = model.NewsContent;

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
		public bool Update(Maticsoft.Model.NewsInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NewsInfo set ");
			strSql.Append("NewsTitle=@NewsTitle,");
			strSql.Append("NewsKey=@NewsKey,");
			strSql.Append("Write=@Write,");
			strSql.Append("NewsTypeID=@NewsTypeID,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("HitNum=@HitNum,");
			strSql.Append("NewsContent=@NewsContent");
			strSql.Append(" where NewsID=@NewsID");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4),
					new SqlParameter("@NewsTitle", SqlDbType.VarChar,200),
					new SqlParameter("@NewsKey", SqlDbType.VarChar,200),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@NewsTypeID", SqlDbType.Int,4),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@NewsContent", SqlDbType.Text)};
			parameters[0].Value = model.NewsID;
			parameters[1].Value = model.NewsTitle;
			parameters[2].Value = model.NewsKey;
			parameters[3].Value = model.Write;
			parameters[4].Value = model.NewsTypeID;
			parameters[5].Value = model.Fatime;
			parameters[6].Value = model.ImageURL;
			parameters[7].Value = model.HitNum;
			parameters[8].Value = model.NewsContent;

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
		public bool Delete(int NewsID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewsInfo ");
			strSql.Append(" where NewsID=@NewsID");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsID;

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
		public bool DeleteList(string NewsIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewsInfo ");
			strSql.Append(" where NewsID in ("+NewsIDlist + ")  ");
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
		public Maticsoft.Model.NewsInfo GetModel(int NewsID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NewsID,NewsTitle,NewsKey,Write,NewsTypeID,Fatime,ImageURL,HitNum,NewsContent from NewsInfo ");
			strSql.Append(" where NewsID=@NewsID");
			SqlParameter[] parameters = {
					new SqlParameter("@NewsID", SqlDbType.Int,4)
};
			parameters[0].Value = NewsID;

			Maticsoft.Model.NewsInfo model=new Maticsoft.Model.NewsInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(ds.Tables[0].Rows[0]["NewsID"].ToString());
				}
				model.NewsTitle=ds.Tables[0].Rows[0]["NewsTitle"].ToString();
				model.NewsKey=ds.Tables[0].Rows[0]["NewsKey"].ToString();
				model.Write=ds.Tables[0].Rows[0]["Write"].ToString();
				if(ds.Tables[0].Rows[0]["NewsTypeID"].ToString()!="")
				{
					model.NewsTypeID=int.Parse(ds.Tables[0].Rows[0]["NewsTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				if(ds.Tables[0].Rows[0]["HitNum"].ToString()!="")
				{
					model.HitNum=int.Parse(ds.Tables[0].Rows[0]["HitNum"].ToString());
				}
				model.NewsContent=ds.Tables[0].Rows[0]["NewsContent"].ToString();
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
			strSql.Append("select NewsID,NewsTitle,NewsKey,Write,NewsTypeID,Fatime,ImageURL,HitNum,NewsContent ");
			strSql.Append(" FROM NewsInfo ");
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
			strSql.Append(" NewsID,NewsTitle,NewsKey,Write,NewsTypeID,Fatime,ImageURL,HitNum,NewsContent ");
			strSql.Append(" FROM NewsInfo ");
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
			parameters[0].Value = "NewsInfo";
			parameters[1].Value = "NewsID";
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

