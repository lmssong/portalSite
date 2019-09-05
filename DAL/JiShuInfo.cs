using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:JiShuInfo
	/// </summary>
	public partial class JiShuInfo
	{
		public JiShuInfo()
		{}
		#region  Method
        /// <summary>
        ///  获得技术发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getjishuList(int PageIndex, int PageSize)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select top " + PageSize + " * ");
            strsql.Append(" from JiShuInfo ");
            strsql.Append(" where  ");
            strsql.Append("  JishuID not in ( select top " + PageIndex + " JishuID from JiShuInfo  ");
            strsql.Append(" order by Fatime desc) order by Fatime desc ");
            return DbHelperSQL.Query(strsql.ToString());

        }

        /// <summary>
        ///  获得技术发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getjishucount()
        {
            int count = 0;
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select count(*) ");
            strsql.Append(" from JiShuInfo ");
            count = Convert.ToInt32(DbHelperSQL.GetSingle(strsql.ToString()));
            return count;
        }
		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("JishuID", "JiShuInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int JishuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JiShuInfo");
			strSql.Append(" where JishuID=@JishuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@JishuID", SqlDbType.Int,4)};
			parameters[0].Value = JishuID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.JiShuInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JiShuInfo(");
			strSql.Append("JishuTitle,JishuNum,Fatime,jishuType,ImageURL,JishuPath,Jishucontent)");
			strSql.Append(" values (");
			strSql.Append("@JishuTitle,@JishuNum,@Fatime,@jishuType,@ImageURL,@JishuPath,@Jishucontent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@JishuTitle", SqlDbType.VarChar,200),
					new SqlParameter("@JishuNum", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@jishuType", SqlDbType.VarChar,200),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@JishuPath", SqlDbType.Text),
					new SqlParameter("@Jishucontent", SqlDbType.Text)};
			parameters[0].Value = model.JishuTitle;
			parameters[1].Value = model.JishuNum;
			parameters[2].Value = model.Fatime;
			parameters[3].Value = model.jishuType;
			parameters[4].Value = model.ImageURL;
			parameters[5].Value = model.JishuPath;
			parameters[6].Value = model.Jishucontent;

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
		public bool Update(Maticsoft.Model.JiShuInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JiShuInfo set ");
			strSql.Append("JishuTitle=@JishuTitle,");
			strSql.Append("JishuNum=@JishuNum,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("jishuType=@jishuType,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("JishuPath=@JishuPath,");
			strSql.Append("Jishucontent=@Jishucontent");
			strSql.Append(" where JishuID=@JishuID");
			SqlParameter[] parameters = {
					new SqlParameter("@JishuID", SqlDbType.Int,4),
					new SqlParameter("@JishuTitle", SqlDbType.VarChar,200),
					new SqlParameter("@JishuNum", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@jishuType", SqlDbType.VarChar,200),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@JishuPath", SqlDbType.Text),
					new SqlParameter("@Jishucontent", SqlDbType.Text)};
			parameters[0].Value = model.JishuID;
			parameters[1].Value = model.JishuTitle;
			parameters[2].Value = model.JishuNum;
			parameters[3].Value = model.Fatime;
			parameters[4].Value = model.jishuType;
			parameters[5].Value = model.ImageURL;
			parameters[6].Value = model.JishuPath;
			parameters[7].Value = model.Jishucontent;

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
		public bool Delete(int JishuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JiShuInfo ");
			strSql.Append(" where JishuID=@JishuID");
			SqlParameter[] parameters = {
					new SqlParameter("@JishuID", SqlDbType.Int,4)
};
			parameters[0].Value = JishuID;

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
		public bool DeleteList(string JishuIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JiShuInfo ");
			strSql.Append(" where JishuID in ("+JishuIDlist + ")  ");
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
		public Maticsoft.Model.JiShuInfo GetModel(int JishuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 JishuID,JishuTitle,JishuNum,Fatime,jishuType,ImageURL,JishuPath,Jishucontent from JiShuInfo ");
			strSql.Append(" where JishuID=@JishuID");
			SqlParameter[] parameters = {
					new SqlParameter("@JishuID", SqlDbType.Int,4)
};
			parameters[0].Value = JishuID;

			Maticsoft.Model.JiShuInfo model=new Maticsoft.Model.JiShuInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["JishuID"].ToString()!="")
				{
					model.JishuID=int.Parse(ds.Tables[0].Rows[0]["JishuID"].ToString());
				}
				model.JishuTitle=ds.Tables[0].Rows[0]["JishuTitle"].ToString();
				model.JishuNum=ds.Tables[0].Rows[0]["JishuNum"].ToString();
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				model.jishuType=ds.Tables[0].Rows[0]["jishuType"].ToString();
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				model.JishuPath=ds.Tables[0].Rows[0]["JishuPath"].ToString();
				model.Jishucontent=ds.Tables[0].Rows[0]["Jishucontent"].ToString();
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
			strSql.Append("select JishuID,JishuTitle,JishuNum,Fatime,jishuType,ImageURL,JishuPath,Jishucontent ");
			strSql.Append(" FROM JiShuInfo ");
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
			strSql.Append(" JishuID,JishuTitle,JishuNum,Fatime,jishuType,ImageURL,JishuPath,Jishucontent ");
			strSql.Append(" FROM JiShuInfo ");
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
			parameters[0].Value = "JiShuInfo";
			parameters[1].Value = "JishuID";
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

