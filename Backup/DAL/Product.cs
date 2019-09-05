using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Product
	/// </summary>
	public partial class Product
	{
		public Product()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet getproList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM Product ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  ProID not in (select top " + PageIndex + " ProID from Product ");
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
        public int getproCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM Product ");
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
		return DbHelperSQL.GetMaxID("ProID", "Product"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ProID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Product");
			strSql.Append(" where ProID=@ProID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
			parameters[0].Value = ProID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Product(");
			strSql.Append("ProName,ProTypeID,ImageURL,ProXingID,Prochutime,Fatime,Toujian,HitNum,Procontent,ProMonery)");
			strSql.Append(" values (");
			strSql.Append("@ProName,@ProTypeID,@ImageURL,@ProXingID,@Prochutime,@Fatime,@Toujian,@HitNum,@Procontent,@ProMonery)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProName", SqlDbType.VarChar,200),
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@ProXingID", SqlDbType.Int,4),
					new SqlParameter("@Prochutime", SqlDbType.DateTime),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Toujian", SqlDbType.Int,4),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@Procontent", SqlDbType.Text),
					new SqlParameter("@ProMonery", SqlDbType.Text)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.ProTypeID;
			parameters[2].Value = model.ImageURL;
			parameters[3].Value = model.ProXingID;
			parameters[4].Value = model.Prochutime;
			parameters[5].Value = model.Fatime;
			parameters[6].Value = model.Toujian;
			parameters[7].Value = model.HitNum;
			parameters[8].Value = model.Procontent;
			parameters[9].Value = model.ProMonery;

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
		public bool Update(Maticsoft.Model.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Product set ");
			strSql.Append("ProName=@ProName,");
			strSql.Append("ProTypeID=@ProTypeID,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("ProXingID=@ProXingID,");
			strSql.Append("Prochutime=@Prochutime,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("Toujian=@Toujian,");
			strSql.Append("HitNum=@HitNum,");
			strSql.Append("Procontent=@Procontent,");
			strSql.Append("ProMonery=@ProMonery");
			strSql.Append(" where ProID=@ProID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4),
					new SqlParameter("@ProName", SqlDbType.VarChar,200),
					new SqlParameter("@ProTypeID", SqlDbType.Int,4),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@ProXingID", SqlDbType.Int,4),
					new SqlParameter("@Prochutime", SqlDbType.DateTime),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Toujian", SqlDbType.Int,4),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@Procontent", SqlDbType.Text),
					new SqlParameter("@ProMonery", SqlDbType.Text)};
			parameters[0].Value = model.ProID;
			parameters[1].Value = model.ProName;
			parameters[2].Value = model.ProTypeID;
			parameters[3].Value = model.ImageURL;
			parameters[4].Value = model.ProXingID;
			parameters[5].Value = model.Prochutime;
			parameters[6].Value = model.Fatime;
			parameters[7].Value = model.Toujian;
			parameters[8].Value = model.HitNum;
			parameters[9].Value = model.Procontent;
			parameters[10].Value = model.ProMonery;

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
		public bool Delete(int ProID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Product ");
			strSql.Append(" where ProID=@ProID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)
};
			parameters[0].Value = ProID;

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
		public bool DeleteList(string ProIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Product ");
			strSql.Append(" where ProID in ("+ProIDlist + ")  ");
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
		public Maticsoft.Model.Product GetModel(int ProID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProID,ProName,ProTypeID,ImageURL,ProXingID,Prochutime,Fatime,Toujian,HitNum,Procontent,ProMonery from Product ");
			strSql.Append(" where ProID=@ProID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)
};
			parameters[0].Value = ProID;

			Maticsoft.Model.Product model=new Maticsoft.Model.Product();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ProID"].ToString()!="")
				{
					model.ProID=int.Parse(ds.Tables[0].Rows[0]["ProID"].ToString());
				}
				model.ProName=ds.Tables[0].Rows[0]["ProName"].ToString();
				if(ds.Tables[0].Rows[0]["ProTypeID"].ToString()!="")
				{
					model.ProTypeID=int.Parse(ds.Tables[0].Rows[0]["ProTypeID"].ToString());
				}
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				if(ds.Tables[0].Rows[0]["ProXingID"].ToString()!="")
				{
					model.ProXingID=int.Parse(ds.Tables[0].Rows[0]["ProXingID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Prochutime"].ToString()!="")
				{
					model.Prochutime=DateTime.Parse(ds.Tables[0].Rows[0]["Prochutime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Toujian"].ToString()!="")
				{
					model.Toujian=int.Parse(ds.Tables[0].Rows[0]["Toujian"].ToString());
				}
				if(ds.Tables[0].Rows[0]["HitNum"].ToString()!="")
				{
					model.HitNum=int.Parse(ds.Tables[0].Rows[0]["HitNum"].ToString());
				}
				model.Procontent=ds.Tables[0].Rows[0]["Procontent"].ToString();
				model.ProMonery=ds.Tables[0].Rows[0]["ProMonery"].ToString();
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
			strSql.Append("select ProID,ProName,ProTypeID,ImageURL,ProXingID,Prochutime,Fatime,Toujian,HitNum,Procontent,ProMonery ");
			strSql.Append(" FROM Product ");
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
			strSql.Append(" ProID,ProName,ProTypeID,ImageURL,ProXingID,Prochutime,Fatime,Toujian,HitNum,Procontent,ProMonery ");
			strSql.Append(" FROM Product ");
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
			parameters[0].Value = "Product";
			parameters[1].Value = "ProID";
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

