using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:MessageInfo
	/// </summary>
	public partial class MessageInfo
	{
		public MessageInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetmessList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM MessageInfo ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  MessID not in (select top " + PageIndex + " MessID from MessageInfo ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);

            }
            strSql.Append(" order by DateTime desc) order by DateTime desc");

            return DbHelperSQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetmessCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM MessageInfo ");
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
		return DbHelperSQL.GetMaxID("MessID", "MessageInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MessID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MessageInfo");
			strSql.Append(" where MessID=@MessID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MessID", SqlDbType.Int,4)};
			parameters[0].Value = MessID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.MessageInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MessageInfo(");
			strSql.Append("MessTitle,Username,Sex,DateTime,Address,Linkphoto,Email,Messcontent)");
			strSql.Append(" values (");
			strSql.Append("@MessTitle,@Username,@Sex,@DateTime,@Address,@Linkphoto,@Email,@Messcontent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MessTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Username", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Linkphoto", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Messcontent", SqlDbType.Text)};
			parameters[0].Value = model.MessTitle;
			parameters[1].Value = model.Username;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.DateTime;
			parameters[4].Value = model.Address;
			parameters[5].Value = model.Linkphoto;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.Messcontent;

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
		public bool Update(Maticsoft.Model.MessageInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MessageInfo set ");
			strSql.Append("MessTitle=@MessTitle,");
			strSql.Append("Username=@Username,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("Address=@Address,");
			strSql.Append("Linkphoto=@Linkphoto,");
			strSql.Append("Email=@Email,");
			strSql.Append("Messcontent=@Messcontent");
			strSql.Append(" where MessID=@MessID");
			SqlParameter[] parameters = {
					new SqlParameter("@MessID", SqlDbType.Int,4),
					new SqlParameter("@MessTitle", SqlDbType.VarChar,200),
					new SqlParameter("@Username", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Linkphoto", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@Messcontent", SqlDbType.Text)};
			parameters[0].Value = model.MessID;
			parameters[1].Value = model.MessTitle;
			parameters[2].Value = model.Username;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.DateTime;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.Linkphoto;
			parameters[7].Value = model.Email;
			parameters[8].Value = model.Messcontent;

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
		public bool Delete(int MessID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MessageInfo ");
			strSql.Append(" where MessID=@MessID");
			SqlParameter[] parameters = {
					new SqlParameter("@MessID", SqlDbType.Int,4)
};
			parameters[0].Value = MessID;

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
		public bool DeleteList(string MessIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MessageInfo ");
			strSql.Append(" where MessID in ("+MessIDlist + ")  ");
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
		public Maticsoft.Model.MessageInfo GetModel(int MessID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MessID,MessTitle,Username,Sex,DateTime,Address,Linkphoto,Email,Messcontent from MessageInfo ");
			strSql.Append(" where MessID=@MessID");
			SqlParameter[] parameters = {
					new SqlParameter("@MessID", SqlDbType.Int,4)
};
			parameters[0].Value = MessID;

			Maticsoft.Model.MessageInfo model=new Maticsoft.Model.MessageInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["MessID"].ToString()!="")
				{
					model.MessID=int.Parse(ds.Tables[0].Rows[0]["MessID"].ToString());
				}
				model.MessTitle=ds.Tables[0].Rows[0]["MessTitle"].ToString();
				model.Username=ds.Tables[0].Rows[0]["Username"].ToString();
				if(ds.Tables[0].Rows[0]["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
				model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				model.Linkphoto=ds.Tables[0].Rows[0]["Linkphoto"].ToString();
				model.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				model.Messcontent=ds.Tables[0].Rows[0]["Messcontent"].ToString();
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
			strSql.Append("select MessID,MessTitle,Username,Sex,DateTime,Address,Linkphoto,Email,Messcontent ");
			strSql.Append(" FROM MessageInfo ");
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
			strSql.Append(" MessID,MessTitle,Username,Sex,DateTime,Address,Linkphoto,Email,Messcontent ");
			strSql.Append(" FROM MessageInfo ");
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
			parameters[0].Value = "MessageInfo";
			parameters[1].Value = "MessID";
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

