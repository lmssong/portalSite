using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:MemberInfo
	/// </summary>
	public partial class MemberInfo
	{
		public MemberInfo()
		{}
		#region  Method
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.MemberInfo GetpassModel(string MemberName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MemberID,MemberName,Password,Sex,Linkphoto,Email,QQMSN from MemberInfo ");
            strSql.Append(" where MemberName=@MemberName");
            SqlParameter[] parameters = {
					new SqlParameter("@MemberName", SqlDbType.VarChar ,200)
};
            parameters[0].Value = MemberName;

            Maticsoft.Model.MemberInfo model = new Maticsoft.Model.MemberInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["MemberID"].ToString() != "")
                {
                    model.MemberID = int.Parse(ds.Tables[0].Rows[0]["MemberID"].ToString());
                }
                model.MemberName = ds.Tables[0].Rows[0]["MemberName"].ToString();
                model.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                if (ds.Tables[0].Rows[0]["Sex"].ToString() != "")
                {
                    model.Sex = int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
                }
                model.Linkphoto = ds.Tables[0].Rows[0]["Linkphoto"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.QQMSN = ds.Tables[0].Rows[0]["QQMSN"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool GetExists(string  MemberName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MemberInfo");
            strSql.Append(" where MemberName=@MemberName ");
            SqlParameter[] parameters = {
					new SqlParameter("@MemberName", SqlDbType.VarChar ,200)};
            parameters[0].Value = MemberName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MemberID", "MemberInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MemberID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MemberInfo");
			strSql.Append(" where MemberID=@MemberID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4)};
			parameters[0].Value = MemberID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.MemberInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MemberInfo(");
			strSql.Append("MemberName,Password,Sex,Linkphoto,Email,QQMSN)");
			strSql.Append(" values (");
			strSql.Append("@MemberName,@Password,@Sex,@Linkphoto,@Email,@QQMSN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Linkphoto", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@QQMSN", SqlDbType.VarChar,200)};
			parameters[0].Value = model.MemberName;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Linkphoto;
			parameters[4].Value = model.Email;
			parameters[5].Value = model.QQMSN;

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
		public bool Update(Maticsoft.Model.MemberInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MemberInfo set ");
			strSql.Append("MemberName=@MemberName,");
			strSql.Append("Password=@Password,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Linkphoto=@Linkphoto,");
			strSql.Append("Email=@Email,");
			strSql.Append("QQMSN=@QQMSN");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4),
					new SqlParameter("@MemberName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@Sex", SqlDbType.Int,4),
					new SqlParameter("@Linkphoto", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,200),
					new SqlParameter("@QQMSN", SqlDbType.VarChar,200)};
			parameters[0].Value = model.MemberID;
			parameters[1].Value = model.MemberName;
			parameters[2].Value = model.Password;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.Linkphoto;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.QQMSN;

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
		public bool Delete(int MemberID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MemberInfo ");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4)
};
			parameters[0].Value = MemberID;

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
		public bool DeleteList(string MemberIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MemberInfo ");
			strSql.Append(" where MemberID in ("+MemberIDlist + ")  ");
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
		public Maticsoft.Model.MemberInfo GetModel(int MemberID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MemberID,MemberName,Password,Sex,Linkphoto,Email,QQMSN from MemberInfo ");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4)
};
			parameters[0].Value = MemberID;

			Maticsoft.Model.MemberInfo model=new Maticsoft.Model.MemberInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["MemberID"].ToString()!="")
				{
					model.MemberID=int.Parse(ds.Tables[0].Rows[0]["MemberID"].ToString());
				}
				model.MemberName=ds.Tables[0].Rows[0]["MemberName"].ToString();
				model.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				if(ds.Tables[0].Rows[0]["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
				}
				model.Linkphoto=ds.Tables[0].Rows[0]["Linkphoto"].ToString();
				model.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				model.QQMSN=ds.Tables[0].Rows[0]["QQMSN"].ToString();
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
			strSql.Append("select MemberID,MemberName,Password,Sex,Linkphoto,Email,QQMSN ");
			strSql.Append(" FROM MemberInfo ");
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
			strSql.Append(" MemberID,MemberName,Password,Sex,Linkphoto,Email,QQMSN ");
			strSql.Append(" FROM MemberInfo ");
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
			parameters[0].Value = "MemberInfo";
			parameters[1].Value = "MemberID";
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

