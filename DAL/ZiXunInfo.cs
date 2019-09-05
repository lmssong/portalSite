using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ZiXunInfo
	/// </summary>
	public partial class ZiXunInfo
	{
		public ZiXunInfo()
		{}
		#region  Method

        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetzixunList(int PageIndex, int PageSize,string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM ZiXunInfo ");
            strSql.Append(" where ");
            if (where != "")
            {
                strSql.Append(" " + where + "  and  ");
            }
            strSql.Append("  zixunID not in (select top " + PageIndex + " zixunID from ZiXunInfo ");
            if (where != "")
            {
                strSql.Append(" where  ZiXundaan is not null     ");
            }
            strSql.Append(" order by zixuntime desc) order by zixuntime desc");

            return DbHelperSQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetzixunCount(string where)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM ZiXunInfo ");
            if (where != "")
            {
                strSql.Append(" where  ZiXundaan is not null     ");
            }
            count = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
            return count;
        }



		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("zixunID", "ZiXunInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int zixunID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ZiXunInfo");
			strSql.Append(" where zixunID=@zixunID ");
			SqlParameter[] parameters = {
					new SqlParameter("@zixunID", SqlDbType.Int,4)};
			parameters[0].Value = zixunID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.ZiXunInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ZiXunInfo(");
			strSql.Append("zixunTitle,zixuntime,zixuncontent,zixunUserName,zixunuserPhoto,ZiXundaan)");
			strSql.Append(" values (");
			strSql.Append("@zixunTitle,@zixuntime,@zixuncontent,@zixunUserName,@zixunuserPhoto,@ZiXundaan)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@zixunTitle", SqlDbType.VarChar,200),
					new SqlParameter("@zixuntime", SqlDbType.DateTime),
					new SqlParameter("@zixuncontent", SqlDbType.Text),
					new SqlParameter("@zixunUserName", SqlDbType.VarChar,200),
					new SqlParameter("@zixunuserPhoto", SqlDbType.VarChar,200),
					new SqlParameter("@ZiXundaan", SqlDbType.Text)};
			parameters[0].Value = model.zixunTitle;
			parameters[1].Value = model.zixuntime;
			parameters[2].Value = model.zixuncontent;
			parameters[3].Value = model.zixunUserName;
			parameters[4].Value = model.zixunuserPhoto;
			parameters[5].Value = model.ZiXundaan;

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
		public bool Update(Maticsoft.Model.ZiXunInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ZiXunInfo set ");
			strSql.Append("zixunTitle=@zixunTitle,");
			strSql.Append("zixuntime=@zixuntime,");
			strSql.Append("zixuncontent=@zixuncontent,");
			strSql.Append("zixunUserName=@zixunUserName,");
			strSql.Append("zixunuserPhoto=@zixunuserPhoto,");
			strSql.Append("ZiXundaan=@ZiXundaan");
			strSql.Append(" where zixunID=@zixunID");
			SqlParameter[] parameters = {
					new SqlParameter("@zixunID", SqlDbType.Int,4),
					new SqlParameter("@zixunTitle", SqlDbType.VarChar,200),
					new SqlParameter("@zixuntime", SqlDbType.DateTime),
					new SqlParameter("@zixuncontent", SqlDbType.Text),
					new SqlParameter("@zixunUserName", SqlDbType.VarChar,200),
					new SqlParameter("@zixunuserPhoto", SqlDbType.VarChar,200),
					new SqlParameter("@ZiXundaan", SqlDbType.Text)};
			parameters[0].Value = model.zixunID;
			parameters[1].Value = model.zixunTitle;
			parameters[2].Value = model.zixuntime;
			parameters[3].Value = model.zixuncontent;
			parameters[4].Value = model.zixunUserName;
			parameters[5].Value = model.zixunuserPhoto;
			parameters[6].Value = model.ZiXundaan;

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
		public bool Delete(int zixunID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZiXunInfo ");
			strSql.Append(" where zixunID=@zixunID");
			SqlParameter[] parameters = {
					new SqlParameter("@zixunID", SqlDbType.Int,4)
};
			parameters[0].Value = zixunID;

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
		public bool DeleteList(string zixunIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ZiXunInfo ");
			strSql.Append(" where zixunID in ("+zixunIDlist + ")  ");
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
		public Maticsoft.Model.ZiXunInfo GetModel(int zixunID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 zixunID,zixunTitle,zixuntime,zixuncontent,zixunUserName,zixunuserPhoto,ZiXundaan from ZiXunInfo ");
			strSql.Append(" where zixunID=@zixunID");
			SqlParameter[] parameters = {
					new SqlParameter("@zixunID", SqlDbType.Int,4)
};
			parameters[0].Value = zixunID;

			Maticsoft.Model.ZiXunInfo model=new Maticsoft.Model.ZiXunInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["zixunID"].ToString()!="")
				{
					model.zixunID=int.Parse(ds.Tables[0].Rows[0]["zixunID"].ToString());
				}
				model.zixunTitle=ds.Tables[0].Rows[0]["zixunTitle"].ToString();
				if(ds.Tables[0].Rows[0]["zixuntime"].ToString()!="")
				{
					model.zixuntime=DateTime.Parse(ds.Tables[0].Rows[0]["zixuntime"].ToString());
				}
				model.zixuncontent=ds.Tables[0].Rows[0]["zixuncontent"].ToString();
				model.zixunUserName=ds.Tables[0].Rows[0]["zixunUserName"].ToString();
				model.zixunuserPhoto=ds.Tables[0].Rows[0]["zixunuserPhoto"].ToString();
				model.ZiXundaan=ds.Tables[0].Rows[0]["ZiXundaan"].ToString();
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
			strSql.Append("select zixunID,zixunTitle,zixuntime,zixuncontent,zixunUserName,zixunuserPhoto,ZiXundaan ");
			strSql.Append(" FROM ZiXunInfo ");
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
			strSql.Append(" zixunID,zixunTitle,zixuntime,zixuncontent,zixunUserName,zixunuserPhoto,ZiXundaan ");
			strSql.Append(" FROM ZiXunInfo ");
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
			parameters[0].Value = "ZiXunInfo";
			parameters[1].Value = "zixunID";
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

