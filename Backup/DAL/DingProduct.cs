using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:DingProduct
	/// </summary>
	public partial class DingProduct
	{
		public DingProduct()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetDingList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM DingProduct ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  DingID not in (select top " + PageIndex + " DingID from DingProduct ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);

            }
            strSql.Append(" order by Dingtime desc) order by Dingtime desc");

            return DbHelperSQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetDingCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM DingProduct ");
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
		return DbHelperSQL.GetMaxID("DingID", "DingProduct"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DingID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DingProduct");
			strSql.Append(" where DingID=@DingID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DingID", SqlDbType.Int,4)};
			parameters[0].Value = DingID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.DingProduct model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DingProduct(");
			strSql.Append("ProName,ProXingID,ProTypeID,DingNum,DingAddress,LinkPhoto,DingEmail,DingSex,UsersName,Dingtime,Dingcontent)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@ProXingID,@ProTypeID,@DingNum,@DingAddress,@LinkPhoto,@DingEmail,@DingSex,@UsersName,@Dingtime,@Dingcontent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,200),
					new SqlParameter("@ProXingID", SqlDbType.Int,4),
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@DingNum", SqlDbType.VarChar,200),
					new SqlParameter("@DingAddress", SqlDbType.Text),
					new SqlParameter("@LinkPhoto", SqlDbType.VarChar,200),
					new SqlParameter("@DingEmail", SqlDbType.VarChar,200),
					new SqlParameter("@DingSex", SqlDbType.Int,4),
					new SqlParameter("@UsersName", SqlDbType.VarChar,200),
					new SqlParameter("@Dingtime", SqlDbType.DateTime),
					new SqlParameter("@Dingcontent", SqlDbType.Text)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.ProXingID;
			parameters[2].Value = model.ProTypeID;
			parameters[3].Value = model.DingNum;
			parameters[4].Value = model.DingAddress;
			parameters[5].Value = model.LinkPhoto;
			parameters[6].Value = model.DingEmail;
			parameters[7].Value = model.DingSex;
			parameters[8].Value = model.UsersName;
			parameters[9].Value = model.Dingtime;
			parameters[10].Value = model.Dingcontent;

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
		public bool Update(Maticsoft.Model.DingProduct model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DingProduct set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("ProXingID=@ProXingID,");
			strSql.Append("ProTypeID=@ProTypeID,");
			strSql.Append("DingNum=@DingNum,");
			strSql.Append("DingAddress=@DingAddress,");
			strSql.Append("LinkPhoto=@LinkPhoto,");
			strSql.Append("DingEmail=@DingEmail,");
			strSql.Append("DingSex=@DingSex,");
			strSql.Append("UsersName=@UsersName,");
			strSql.Append("Dingtime=@Dingtime,");
			strSql.Append("Dingcontent=@Dingcontent");
			strSql.Append(" where DingID=@DingID");
			SqlParameter[] parameters = {
					new SqlParameter("@DingID", SqlDbType.Int,4),
					new SqlParameter("@ProName", SqlDbType.VarChar,200),
					new SqlParameter("@ProXingID", SqlDbType.Int,4),
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@DingNum", SqlDbType.VarChar,200),
					new SqlParameter("@DingAddress", SqlDbType.Text),
					new SqlParameter("@LinkPhoto", SqlDbType.VarChar,200),
					new SqlParameter("@DingEmail", SqlDbType.VarChar,200),
					new SqlParameter("@DingSex", SqlDbType.Int,4),
					new SqlParameter("@UsersName", SqlDbType.VarChar,200),
					new SqlParameter("@Dingtime", SqlDbType.DateTime),
					new SqlParameter("@Dingcontent", SqlDbType.Text)};
			parameters[0].Value = model.DingID;
			parameters[1].Value = model.ProName;
			parameters[2].Value = model.ProXingID;
			parameters[3].Value = model.ProTypeID;
			parameters[4].Value = model.DingNum;
			parameters[5].Value = model.DingAddress;
			parameters[6].Value = model.LinkPhoto;
			parameters[7].Value = model.DingEmail;
			parameters[8].Value = model.DingSex;
			parameters[9].Value = model.UsersName;
			parameters[10].Value = model.Dingtime;
			parameters[11].Value = model.Dingcontent;

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
		public bool Delete(int DingID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DingProduct ");
			strSql.Append(" where DingID=@DingID");
			SqlParameter[] parameters = {
					new SqlParameter("@DingID", SqlDbType.Int,4)
};
			parameters[0].Value = DingID;

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
		public bool DeleteList(string DingIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DingProduct ");
			strSql.Append(" where DingID in ("+DingIDlist + ")  ");
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
		public Maticsoft.Model.DingProduct GetModel(int DingID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DingID,ProName,ProXingID,ProTypeID,DingNum,DingAddress,LinkPhoto,DingEmail,DingSex,UsersName,Dingtime,Dingcontent from DingProduct ");
			strSql.Append(" where DingID=@DingID");
			SqlParameter[] parameters = {
					new SqlParameter("@DingID", SqlDbType.Int,4)
};
			parameters[0].Value = DingID;

			Maticsoft.Model.DingProduct model=new Maticsoft.Model.DingProduct();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["DingID"].ToString()!="")
				{
					model.DingID=int.Parse(ds.Tables[0].Rows[0]["DingID"].ToString());
				}
				model.ProName=ds.Tables[0].Rows[0]["ProName"].ToString();
				if(ds.Tables[0].Rows[0]["ProXingID"].ToString()!="")
				{
					model.ProXingID=int.Parse(ds.Tables[0].Rows[0]["ProXingID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProTypeID"].ToString()!="")
				{
					model.ProTypeID=int.Parse(ds.Tables[0].Rows[0]["ProTypeID"].ToString());
				}
				model.DingNum=ds.Tables[0].Rows[0]["DingNum"].ToString();
				model.DingAddress=ds.Tables[0].Rows[0]["DingAddress"].ToString();
				model.LinkPhoto=ds.Tables[0].Rows[0]["LinkPhoto"].ToString();
				model.DingEmail=ds.Tables[0].Rows[0]["DingEmail"].ToString();
				if(ds.Tables[0].Rows[0]["DingSex"].ToString()!="")
				{
					model.DingSex=int.Parse(ds.Tables[0].Rows[0]["DingSex"].ToString());
				}
				model.UsersName=ds.Tables[0].Rows[0]["UsersName"].ToString();
				if(ds.Tables[0].Rows[0]["Dingtime"].ToString()!="")
				{
					model.Dingtime=DateTime.Parse(ds.Tables[0].Rows[0]["Dingtime"].ToString());
				}
				model.Dingcontent=ds.Tables[0].Rows[0]["Dingcontent"].ToString();
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
			strSql.Append("select DingID,ProName,ProXingID,ProTypeID,DingNum,DingAddress,LinkPhoto,DingEmail,DingSex,UsersName,Dingtime,Dingcontent ");
			strSql.Append(" FROM DingProduct ");
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
			strSql.Append(" DingID,ProName,ProXingID,ProTypeID,DingNum,DingAddress,LinkPhoto,DingEmail,DingSex,UsersName,Dingtime,Dingcontent ");
			strSql.Append(" FROM DingProduct ");
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
			parameters[0].Value = "DingProduct";
			parameters[1].Value = "DingID";
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

