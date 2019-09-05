using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:JobZiJianInfo
	/// </summary>
	public partial class JobZiJianInfo
	{
		public JobZiJianInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetzijianList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM JobZiJianInfo ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  JobInfoID not in (select top " + PageIndex + " JobInfoID from JobZiJianInfo ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);

            }
            strSql.Append(" order by datatime desc) order by datatime desc");

            return DbHelperSQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetzijianCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM JobZiJianInfo ");
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
		return DbHelperSQL.GetMaxID("JobInfoID", "JobZiJianInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JobInfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JobZiJianInfo");
			strSql.Append(" where JobInfoID=@JobInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@JobInfoID", SqlDbType.Int,4)};
			parameters[0].Value = JobInfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.JobZiJianInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JobZiJianInfo(");
			strSql.Append("Usersname,Sex,Xueli,datatime,Monery,Jiguan,Britday,Zhuanye,Jiaoyu,Jingyan,Pingjia,Jobtitle)");
			strSql.Append(" values (");
			strSql.Append("@Usersname,@Sex,@Xueli,@datatime,@Monery,@Jiguan,@Britday,@Zhuanye,@Jiaoyu,@Jingyan,@Pingjia,@Jobtitle)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Usersname", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Xueli", SqlDbType.VarChar,200),
					new SqlParameter("@datatime", SqlDbType.DateTime),
					new SqlParameter("@Monery", SqlDbType.VarChar,200),
					new SqlParameter("@Jiguan", SqlDbType.VarChar,200),
					new SqlParameter("@Britday", SqlDbType.DateTime),
					new SqlParameter("@Zhuanye", SqlDbType.VarChar,200),
					new SqlParameter("@Jiaoyu", SqlDbType.Text),
					new SqlParameter("@Jingyan", SqlDbType.Text),
					new SqlParameter("@Pingjia", SqlDbType.Text),
					new SqlParameter("@Jobtitle", SqlDbType.Text)};
			parameters[0].Value = model.Usersname;
			parameters[1].Value = model.Sex;
			parameters[2].Value = model.Xueli;
			parameters[3].Value = model.datatime;
			parameters[4].Value = model.Monery;
			parameters[5].Value = model.Jiguan;
			parameters[6].Value = model.Britday;
			parameters[7].Value = model.Zhuanye;
			parameters[8].Value = model.Jiaoyu;
			parameters[9].Value = model.Jingyan;
			parameters[10].Value = model.Pingjia;
			parameters[11].Value = model.Jobtitle;

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
		public bool Update(Maticsoft.Model.JobZiJianInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JobZiJianInfo set ");
			strSql.Append("Usersname=@Usersname,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Xueli=@Xueli,");
			strSql.Append("datatime=@datatime,");
			strSql.Append("Monery=@Monery,");
			strSql.Append("Jiguan=@Jiguan,");
			strSql.Append("Britday=@Britday,");
			strSql.Append("Zhuanye=@Zhuanye,");
			strSql.Append("Jiaoyu=@Jiaoyu,");
			strSql.Append("Jingyan=@Jingyan,");
			strSql.Append("Pingjia=@Pingjia,");
			strSql.Append("Jobtitle=@Jobtitle");
			strSql.Append(" where JobInfoID=@JobInfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobInfoID", SqlDbType.Int,4),
					new SqlParameter("@Usersname", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Xueli", SqlDbType.VarChar,200),
					new SqlParameter("@datatime", SqlDbType.DateTime),
					new SqlParameter("@Monery", SqlDbType.VarChar,200),
					new SqlParameter("@Jiguan", SqlDbType.VarChar,200),
					new SqlParameter("@Britday", SqlDbType.DateTime),
					new SqlParameter("@Zhuanye", SqlDbType.VarChar,200),
					new SqlParameter("@Jiaoyu", SqlDbType.Text),
					new SqlParameter("@Jingyan", SqlDbType.Text),
					new SqlParameter("@Pingjia", SqlDbType.Text),
					new SqlParameter("@Jobtitle", SqlDbType.Text)};
			parameters[0].Value = model.JobInfoID;
			parameters[1].Value = model.Usersname;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Xueli;
			parameters[4].Value = model.datatime;
			parameters[5].Value = model.Monery;
			parameters[6].Value = model.Jiguan;
			parameters[7].Value = model.Britday;
			parameters[8].Value = model.Zhuanye;
			parameters[9].Value = model.Jiaoyu;
			parameters[10].Value = model.Jingyan;
			parameters[11].Value = model.Pingjia;
			parameters[12].Value = model.Jobtitle;

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
		public bool Delete(int JobInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobZiJianInfo ");
			strSql.Append(" where JobInfoID=@JobInfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobInfoID", SqlDbType.Int,4)
};
			parameters[0].Value = JobInfoID;

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
		public bool DeleteList(string JobInfoIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobZiJianInfo ");
			strSql.Append(" where JobInfoID in ("+JobInfoIDlist + ")  ");
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
		public Maticsoft.Model.JobZiJianInfo GetModel(int JobInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JobInfoID,Usersname,Sex,Xueli,datatime,Monery,Jiguan,Britday,Zhuanye,Jiaoyu,Jingyan,Pingjia,Jobtitle from JobZiJianInfo ");
			strSql.Append(" where JobInfoID=@JobInfoID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobInfoID", SqlDbType.Int,4)
};
			parameters[0].Value = JobInfoID;

			Maticsoft.Model.JobZiJianInfo model=new Maticsoft.Model.JobZiJianInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["JobInfoID"].ToString()!="")
				{
					model.JobInfoID=int.Parse(ds.Tables[0].Rows[0]["JobInfoID"].ToString());
				}
				model.Usersname=ds.Tables[0].Rows[0]["Usersname"].ToString();
				if(ds.Tables[0].Rows[0]["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
				}
				model.Xueli=ds.Tables[0].Rows[0]["Xueli"].ToString();
				if(ds.Tables[0].Rows[0]["datatime"].ToString()!="")
				{
					model.datatime=DateTime.Parse(ds.Tables[0].Rows[0]["datatime"].ToString());
				}
				model.Monery=ds.Tables[0].Rows[0]["Monery"].ToString();
				model.Jiguan=ds.Tables[0].Rows[0]["Jiguan"].ToString();
				if(ds.Tables[0].Rows[0]["Britday"].ToString()!="")
				{
					model.Britday=DateTime.Parse(ds.Tables[0].Rows[0]["Britday"].ToString());
				}
				model.Zhuanye=ds.Tables[0].Rows[0]["Zhuanye"].ToString();
				model.Jiaoyu=ds.Tables[0].Rows[0]["Jiaoyu"].ToString();
				model.Jingyan=ds.Tables[0].Rows[0]["Jingyan"].ToString();
				model.Pingjia=ds.Tables[0].Rows[0]["Pingjia"].ToString();
				model.Jobtitle=ds.Tables[0].Rows[0]["Jobtitle"].ToString();
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
			strSql.Append("select JobInfoID,Usersname,Sex,Xueli,datatime,Monery,Jiguan,Britday,Zhuanye,Jiaoyu,Jingyan,Pingjia,Jobtitle ");
			strSql.Append(" FROM JobZiJianInfo ");
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
			strSql.Append(" JobInfoID,Usersname,Sex,Xueli,datatime,Monery,Jiguan,Britday,Zhuanye,Jiaoyu,Jingyan,Pingjia,Jobtitle ");
			strSql.Append(" FROM JobZiJianInfo ");
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
			parameters[0].Value = "JobZiJianInfo";
			parameters[1].Value = "JobInfoID";
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

