using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:NicheInfo
	/// </summary>
	public partial class NicheInfo
	{
		public NicheInfo()
		{}
		#region  Method

        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetnicheList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM NicheInfo ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  NicheID not in (select top " + PageIndex + " NicheID from NicheInfo ");
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
        public int GetnicheCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM NicheInfo ");
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
		return DbHelperSQL.GetMaxID("NicheID", "NicheInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NicheID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NicheInfo");
			strSql.Append(" where NicheID=@NicheID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheID", SqlDbType.Int,4)};
			parameters[0].Value = NicheID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.NicheInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NicheInfo(");
			strSql.Append("NicheTitle,NicheKey,Fatime,Write,ImageURL,NicheTypeID,HitNum,NicheContent)");
			strSql.Append(" values (");
			strSql.Append("@NicheTitle,@NicheKey,@Fatime,@Write,@ImageURL,@NicheTypeID,@HitNum,@NicheContent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheTitle", SqlDbType.VarChar,200),
					new SqlParameter("@NicheKey", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@NicheTypeID", SqlDbType.Int,4),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@NicheContent", SqlDbType.Text)};
			parameters[0].Value = model.NicheTitle;
			parameters[1].Value = model.NicheKey;
			parameters[2].Value = model.Fatime;
			parameters[3].Value = model.Write;
			parameters[4].Value = model.ImageURL;
			parameters[5].Value = model.NicheTypeID;
			parameters[6].Value = model.HitNum;
			parameters[7].Value = model.NicheContent;

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
		public bool Update(Maticsoft.Model.NicheInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NicheInfo set ");
			strSql.Append("NicheTitle=@NicheTitle,");
			strSql.Append("NicheKey=@NicheKey,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("Write=@Write,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("NicheTypeID=@NicheTypeID,");
			strSql.Append("HitNum=@HitNum,");
			strSql.Append("NicheContent=@NicheContent");
			strSql.Append(" where NicheID=@NicheID");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheID", SqlDbType.Int,4),
					new SqlParameter("@NicheTitle", SqlDbType.VarChar,200),
					new SqlParameter("@NicheKey", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@NicheTypeID", SqlDbType.Int,4),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@NicheContent", SqlDbType.Text)};
			parameters[0].Value = model.NicheID;
			parameters[1].Value = model.NicheTitle;
			parameters[2].Value = model.NicheKey;
			parameters[3].Value = model.Fatime;
			parameters[4].Value = model.Write;
			parameters[5].Value = model.ImageURL;
			parameters[6].Value = model.NicheTypeID;
			parameters[7].Value = model.HitNum;
			parameters[8].Value = model.NicheContent;

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
		public bool Delete(int NicheID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NicheInfo ");
			strSql.Append(" where NicheID=@NicheID");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheID", SqlDbType.Int,4)
};
			parameters[0].Value = NicheID;

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
		public bool DeleteList(string NicheIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NicheInfo ");
			strSql.Append(" where NicheID in ("+NicheIDlist + ")  ");
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
		public Maticsoft.Model.NicheInfo GetModel(int NicheID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NicheID,NicheTitle,NicheKey,Fatime,Write,ImageURL,NicheTypeID,HitNum,NicheContent from NicheInfo ");
			strSql.Append(" where NicheID=@NicheID");
			SqlParameter[] parameters = {
					new SqlParameter("@NicheID", SqlDbType.Int,4)
};
			parameters[0].Value = NicheID;

			Maticsoft.Model.NicheInfo model=new Maticsoft.Model.NicheInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NicheID"].ToString()!="")
				{
					model.NicheID=int.Parse(ds.Tables[0].Rows[0]["NicheID"].ToString());
				}
				model.NicheTitle=ds.Tables[0].Rows[0]["NicheTitle"].ToString();
				model.NicheKey=ds.Tables[0].Rows[0]["NicheKey"].ToString();
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				model.Write=ds.Tables[0].Rows[0]["Write"].ToString();
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				if(ds.Tables[0].Rows[0]["NicheTypeID"].ToString()!="")
				{
					model.NicheTypeID=int.Parse(ds.Tables[0].Rows[0]["NicheTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["HitNum"].ToString()!="")
				{
					model.HitNum=int.Parse(ds.Tables[0].Rows[0]["HitNum"].ToString());
				}
				model.NicheContent=ds.Tables[0].Rows[0]["NicheContent"].ToString();
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
			strSql.Append("select NicheID,NicheTitle,NicheKey,Fatime,Write,ImageURL,NicheTypeID,HitNum,NicheContent ");
			strSql.Append(" FROM NicheInfo ");
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
			strSql.Append(" NicheID,NicheTitle,NicheKey,Fatime,Write,ImageURL,NicheTypeID,HitNum,NicheContent ");
			strSql.Append(" FROM NicheInfo ");
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
			parameters[0].Value = "NicheInfo";
			parameters[1].Value = "NicheID";
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

