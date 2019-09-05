using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:JobInfo
	/// </summary>
	public partial class JobInfo
	{
		public JobInfo()
		{}
		#region  Method
        /// <summary>
        ///  获得技术发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getjobList(int PageIndex, int PageSize)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select top " + PageSize + " * ");
            strsql.Append(" from JobInfo ");
            strsql.Append(" where  ");
            strsql.Append("  JobID not in ( select top " + PageIndex + " JobID from JobInfo  ");
            strsql.Append(" order by Starttime desc) order by Starttime desc ");
            return DbHelperSQL.Query(strsql.ToString());

        }
        /// <summary>
        ///  获得招聘发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getjobcount()
        {
            int count = 0;
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select count(*) ");
            strsql.Append(" from JobInfo ");
            count = Convert.ToInt32(DbHelperSQL.GetSingle(strsql.ToString()));
            return count;
        }


		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("JobID", "JobInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JobID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JobInfo");
			strSql.Append(" where JobID=@JobID ");
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4)};
			parameters[0].Value = JobID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.JobInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JobInfo(");
			strSql.Append("JobTitle,Address,Nunber,Starttime,Duxiang,Age,Xueli,Monery,Zhuanye,Endtime,Miaoshu,Lianxi)");
			strSql.Append(" values (");
			strSql.Append("@JobTitle,@Address,@Nunber,@Starttime,@Duxiang,@Age,@Xueli,@Monery,@Zhuanye,@Endtime,@Miaoshu,@Lianxi)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@JobTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Nunber", SqlDbType.VarChar,200),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@Duxiang", SqlDbType.VarChar,200),
					new SqlParameter("@Age", SqlDbType.VarChar,200),
					new SqlParameter("@Xueli", SqlDbType.VarChar,200),
					new SqlParameter("@Monery", SqlDbType.VarChar,200),
					new SqlParameter("@Zhuanye", SqlDbType.VarChar,200),
					new SqlParameter("@Endtime", SqlDbType.DateTime),
					new SqlParameter("@Miaoshu", SqlDbType.Text),
					new SqlParameter("@Lianxi", SqlDbType.Text)};
			parameters[0].Value = model.JobTitle;
			parameters[1].Value = model.Address;
			parameters[2].Value = model.Nunber;
			parameters[3].Value = model.Starttime;
			parameters[4].Value = model.Duxiang;
			parameters[5].Value = model.Age;
			parameters[6].Value = model.Xueli;
			parameters[7].Value = model.Monery;
			parameters[8].Value = model.Zhuanye;
			parameters[9].Value = model.Endtime;
			parameters[10].Value = model.Miaoshu;
			parameters[11].Value = model.Lianxi;

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
		public bool Update(Maticsoft.Model.JobInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JobInfo set ");
			strSql.Append("JobTitle=@JobTitle,");
			strSql.Append("Address=@Address,");
			strSql.Append("Nunber=@Nunber,");
			strSql.Append("Starttime=@Starttime,");
			strSql.Append("Duxiang=@Duxiang,");
			strSql.Append("Age=@Age,");
			strSql.Append("Xueli=@Xueli,");
			strSql.Append("Monery=@Monery,");
			strSql.Append("Zhuanye=@Zhuanye,");
			strSql.Append("Endtime=@Endtime,");
			strSql.Append("Miaoshu=@Miaoshu,");
			strSql.Append("Lianxi=@Lianxi");
			strSql.Append(" where JobID=@JobID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4),
					new SqlParameter("@JobTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Nunber", SqlDbType.VarChar,200),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@Duxiang", SqlDbType.VarChar,200),
					new SqlParameter("@Age", SqlDbType.VarChar,200),
					new SqlParameter("@Xueli", SqlDbType.VarChar,200),
					new SqlParameter("@Monery", SqlDbType.VarChar,200),
					new SqlParameter("@Zhuanye", SqlDbType.VarChar,200),
					new SqlParameter("@Endtime", SqlDbType.DateTime),
					new SqlParameter("@Miaoshu", SqlDbType.Text),
					new SqlParameter("@Lianxi", SqlDbType.Text)};
			parameters[0].Value = model.JobID;
			parameters[1].Value = model.JobTitle;
			parameters[2].Value = model.Address;
			parameters[3].Value = model.Nunber;
			parameters[4].Value = model.Starttime;
			parameters[5].Value = model.Duxiang;
			parameters[6].Value = model.Age;
			parameters[7].Value = model.Xueli;
			parameters[8].Value = model.Monery;
			parameters[9].Value = model.Zhuanye;
			parameters[10].Value = model.Endtime;
			parameters[11].Value = model.Miaoshu;
			parameters[12].Value = model.Lianxi;

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
		public bool Delete(int JobID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobInfo ");
			strSql.Append(" where JobID=@JobID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4)
};
			parameters[0].Value = JobID;

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
		public bool DeleteList(string JobIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JobInfo ");
			strSql.Append(" where JobID in ("+JobIDlist + ")  ");
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
		public Maticsoft.Model.JobInfo GetModel(int JobID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JobID,JobTitle,Address,Nunber,Starttime,Duxiang,Age,Xueli,Monery,Zhuanye,Endtime,Miaoshu,Lianxi from JobInfo ");
			strSql.Append(" where JobID=@JobID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobID", SqlDbType.Int,4)
};
			parameters[0].Value = JobID;

			Maticsoft.Model.JobInfo model=new Maticsoft.Model.JobInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["JobID"].ToString()!="")
				{
					model.JobID=int.Parse(ds.Tables[0].Rows[0]["JobID"].ToString());
				}
				model.JobTitle=ds.Tables[0].Rows[0]["JobTitle"].ToString();
				model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				model.Nunber=ds.Tables[0].Rows[0]["Nunber"].ToString();
				if(ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					model.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				model.Duxiang=ds.Tables[0].Rows[0]["Duxiang"].ToString();
				model.Age=ds.Tables[0].Rows[0]["Age"].ToString();
				model.Xueli=ds.Tables[0].Rows[0]["Xueli"].ToString();
				model.Monery=ds.Tables[0].Rows[0]["Monery"].ToString();
				model.Zhuanye=ds.Tables[0].Rows[0]["Zhuanye"].ToString();
				if(ds.Tables[0].Rows[0]["Endtime"].ToString()!="")
				{
					model.Endtime=DateTime.Parse(ds.Tables[0].Rows[0]["Endtime"].ToString());
				}
				model.Miaoshu=ds.Tables[0].Rows[0]["Miaoshu"].ToString();
				model.Lianxi=ds.Tables[0].Rows[0]["Lianxi"].ToString();
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
			strSql.Append("select JobID,JobTitle,Address,Nunber,Starttime,Duxiang,Age,Xueli,Monery,Zhuanye,Endtime,Miaoshu,Lianxi ");
			strSql.Append(" FROM JobInfo ");
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
			strSql.Append(" JobID,JobTitle,Address,Nunber,Starttime,Duxiang,Age,Xueli,Monery,Zhuanye,Endtime,Miaoshu,Lianxi ");
			strSql.Append(" FROM JobInfo ");
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
			parameters[0].Value = "JobInfo";
			parameters[1].Value = "JobID";
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

