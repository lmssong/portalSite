using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:SuccessInfo
	/// </summary>
	public partial class SuccessInfo
	{
		public SuccessInfo()
		{}
		#region  Method
        /// <summary>
        ///  获得环境发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getsuccessList(int PageIndex, int PageSize, string sytwhere)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select top " + PageSize + " * ");
            strsql.Append(" from SuccessInfo ");
            strsql.Append(" where  ");
            if (sytwhere != "")
            {
                strsql.Append(" " + sytwhere + " and  ");
            }
            strsql.Append(" SuccessID not in ( select top " + PageIndex + " SuccessID from SuccessInfo  ");
            if (sytwhere != "")
            {
                strsql.Append(" where "+sytwhere +" ");
            }
            strsql.Append(" order by Fatime desc) order by Fatime desc ");
            return DbHelperSQL.Query(strsql.ToString());

        }
        /// <summary>
        ///  获得环境发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getsuccessCount(string strwhere)
        {
            int count = 0;
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select count(*) ");
            strsql.Append(" from SuccessInfo ");
            if (strwhere  != "")
            {
                strsql.Append(" where "+strwhere +" ");
            }
           

            count = Convert.ToInt32(DbHelperSQL.GetSingle(strsql.ToString()));
            return count;
        }



		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SuccessID", "SuccessInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SuccessID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SuccessInfo");
			strSql.Append(" where SuccessID=@SuccessID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SuccessID", SqlDbType.Int,4)};
			parameters[0].Value = SuccessID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.SuccessInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SuccessInfo(");
			strSql.Append("SuccessTitle,Fatime,Write,ImageURL,HitNum,SuccessContent)");
			strSql.Append(" values (");
			strSql.Append("@SuccessTitle,@Fatime,@Write,@ImageURL,@HitNum,@SuccessContent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SuccessTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@SuccessContent", SqlDbType.Text)};
			parameters[0].Value = model.SuccessTitle;
			parameters[1].Value = model.Fatime;
			parameters[2].Value = model.Write;
			parameters[3].Value = model.ImageURL;
			parameters[4].Value = model.HitNum;
			parameters[5].Value = model.SuccessContent;

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
		public bool Update(Maticsoft.Model.SuccessInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SuccessInfo set ");
			strSql.Append("SuccessTitle=@SuccessTitle,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("Write=@Write,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("HitNum=@HitNum,");
			strSql.Append("SuccessContent=@SuccessContent");
			strSql.Append(" where SuccessID=@SuccessID");
			SqlParameter[] parameters = {
					new SqlParameter("@SuccessID", SqlDbType.Int,4),
					new SqlParameter("@SuccessTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@SuccessContent", SqlDbType.Text)};
			parameters[0].Value = model.SuccessID;
			parameters[1].Value = model.SuccessTitle;
			parameters[2].Value = model.Fatime;
			parameters[3].Value = model.Write;
			parameters[4].Value = model.ImageURL;
			parameters[5].Value = model.HitNum;
			parameters[6].Value = model.SuccessContent;

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
		public bool Delete(int SuccessID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SuccessInfo ");
			strSql.Append(" where SuccessID=@SuccessID");
			SqlParameter[] parameters = {
					new SqlParameter("@SuccessID", SqlDbType.Int,4)
};
			parameters[0].Value = SuccessID;

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
		public bool DeleteList(string SuccessIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SuccessInfo ");
			strSql.Append(" where SuccessID in ("+SuccessIDlist + ")  ");
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
		public Maticsoft.Model.SuccessInfo GetModel(int SuccessID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SuccessID,SuccessTitle,Fatime,Write,ImageURL,HitNum,SuccessContent from SuccessInfo ");
			strSql.Append(" where SuccessID=@SuccessID");
			SqlParameter[] parameters = {
					new SqlParameter("@SuccessID", SqlDbType.Int,4)
};
			parameters[0].Value = SuccessID;

			Maticsoft.Model.SuccessInfo model=new Maticsoft.Model.SuccessInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SuccessID"].ToString()!="")
				{
					model.SuccessID=int.Parse(ds.Tables[0].Rows[0]["SuccessID"].ToString());
				}
				model.SuccessTitle=ds.Tables[0].Rows[0]["SuccessTitle"].ToString();
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				model.Write=ds.Tables[0].Rows[0]["Write"].ToString();
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				if(ds.Tables[0].Rows[0]["HitNum"].ToString()!="")
				{
					model.HitNum=int.Parse(ds.Tables[0].Rows[0]["HitNum"].ToString());
				}
				model.SuccessContent=ds.Tables[0].Rows[0]["SuccessContent"].ToString();
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
			strSql.Append("select SuccessID,SuccessTitle,Fatime,Write,ImageURL,HitNum,SuccessContent ");
			strSql.Append(" FROM SuccessInfo ");
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
			strSql.Append(" SuccessID,SuccessTitle,Fatime,Write,ImageURL,HitNum,SuccessContent ");
			strSql.Append(" FROM SuccessInfo ");
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
			parameters[0].Value = "SuccessInfo";
			parameters[1].Value = "SuccessID";
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

