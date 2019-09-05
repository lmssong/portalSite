using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// ���ݷ�����:ComPanyInfo
	/// </summary>
	public partial class ComPanyInfo
	{
		public ComPanyInfo()
		{}
		#region  Method
        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetgonggaoMaxID(int FenleiID)
        {
            return DbHelperSQL.GetgonggaoMaxID("XianshiID", "ComPanyInfo", FenleiID);
        }



        /// <summary>
        ///  ��û���������Ϣ������
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet gethuanjingList(int PageIndex, int PageSize, int FenleiID)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select top "+ PageSize +" * ");
            strsql.Append(" from ComPanyInfo ");
            strsql.Append(" where FenleiID=" + FenleiID + "  ");
            strsql.Append(" and XianshiID not in ( select top " + PageIndex + " XianshiID from ComPanyInfo  ");
            strsql.Append(" where FenleiID="+FenleiID+"  ");
            strsql.Append(" order by GongTime desc) order by GongTime desc ");
            return DbHelperSQL.Query(strsql.ToString());

        }
        /// <summary>
        ///  ��û���������Ϣ������
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int gethuanjingCount(int FenleiID )
        {
            int count = 0;
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select count(*) ");
            strsql.Append(" from ComPanyInfo ");
            strsql.Append(" where FenleiID=" + FenleiID + " ");
           
            count = Convert.ToInt32(DbHelperSQL.GetSingle(strsql.ToString()));
            return count;
        }


        /// <summary>
        /// ��վ�������һ������
        /// </summary>
        public bool getupdate(Maticsoft.Model.ComPanyInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ComPanyInfo set ");
            strSql.Append("Gonggao=@Gonggao,");
            strSql.Append("GongTime=@GongTime,"); 
            strSql.Append("FenleiID=@FenleiID");
            strSql.Append(" where FenleiID=@FenleiID");
            SqlParameter[] parameters = {
					new SqlParameter("@Gonggao", SqlDbType.Text),
					new SqlParameter("@GongTime", SqlDbType.DateTime), 
					new SqlParameter("@FenleiID", SqlDbType.Int,4)};
            parameters[0].Value = model.Gonggao;
            parameters[1].Value = model.GongTime; 
            parameters[2].Value = model.FenleiID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// ��վ����õ�һ������ʵ��
        /// </summary>
        public Maticsoft.Model.ComPanyInfo GetgonggaoModel(int FenleiID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 XianshiID,Gonggao,FenleiID from ComPanyInfo ");
            strSql.Append(" where FenleiID=@FenleiID");
            SqlParameter[] parameters = {
					new SqlParameter("@FenleiID", SqlDbType.Int,4)
};
            parameters[0].Value = FenleiID;

            Maticsoft.Model.ComPanyInfo model = new Maticsoft.Model.ComPanyInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["XianshiID"].ToString() != "")
                {
                    model.XianshiID = int.Parse(ds.Tables[0].Rows[0]["XianshiID"].ToString());
                }
                model.Gonggao = ds.Tables[0].Rows[0]["Gonggao"].ToString();
               
               
                if (ds.Tables[0].Rows[0]["FenleiID"].ToString() != "")
                {
                    model.FenleiID = int.Parse(ds.Tables[0].Rows[0]["FenleiID"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }






		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("XianshiID", "ComPanyInfo"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int FenleiID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ComPanyInfo");
            strSql.Append(" where FenleiID=@FenleiID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FenleiID", SqlDbType.Int,4)};
            parameters[0].Value = FenleiID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool getfenleiExists(int FenleiID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ComPanyInfo");
            strSql.Append(" where FenleiID=@FenleiID ");
            SqlParameter[] parameters = {
					new SqlParameter("@FenleiID", SqlDbType.Int,4)};
            parameters[0].Value = FenleiID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Maticsoft.Model.ComPanyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ComPanyInfo(");
			strSql.Append("Gonggao,GongTime,ImageURL,FenleiID)");
			strSql.Append(" values (");
			strSql.Append("@Gonggao,@GongTime,@ImageURL,@FenleiID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Gonggao", SqlDbType.Text),
					new SqlParameter("@GongTime", SqlDbType.DateTime),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@FenleiID", SqlDbType.Int,4)};
			parameters[0].Value = model.Gonggao;
			parameters[1].Value = model.GongTime;
			parameters[2].Value = model.ImageURL;
			parameters[3].Value = model.FenleiID;

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
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.ComPanyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ComPanyInfo set ");
			strSql.Append("Gonggao=@Gonggao,");
			strSql.Append("GongTime=@GongTime,");
			strSql.Append("ImageURL=@ImageURL,");
			strSql.Append("FenleiID=@FenleiID");
			strSql.Append(" where XianshiID=@XianshiID");
			SqlParameter[] parameters = {
					new SqlParameter("@XianshiID", SqlDbType.Int,4),
					new SqlParameter("@Gonggao", SqlDbType.Text),
					new SqlParameter("@GongTime", SqlDbType.DateTime),
					new SqlParameter("@ImageURL", SqlDbType.Text),
					new SqlParameter("@FenleiID", SqlDbType.Int,4)};
			parameters[0].Value = model.XianshiID;
			parameters[1].Value = model.Gonggao;
			parameters[2].Value = model.GongTime;
			parameters[3].Value = model.ImageURL;
			parameters[4].Value = model.FenleiID;

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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int XianshiID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ComPanyInfo ");
			strSql.Append(" where XianshiID=@XianshiID");
			SqlParameter[] parameters = {
					new SqlParameter("@XianshiID", SqlDbType.Int,4)
};
			parameters[0].Value = XianshiID;

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
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string XianshiIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ComPanyInfo ");
			strSql.Append(" where XianshiID in ("+XianshiIDlist + ")  ");
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
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.ComPanyInfo GetModel(int XianshiID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XianshiID,Gonggao,GongTime,ImageURL,FenleiID from ComPanyInfo ");
			strSql.Append(" where XianshiID=@XianshiID");
			SqlParameter[] parameters = {
					new SqlParameter("@XianshiID", SqlDbType.Int,4)
};
			parameters[0].Value = XianshiID;

			Maticsoft.Model.ComPanyInfo model=new Maticsoft.Model.ComPanyInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["XianshiID"].ToString()!="")
				{
					model.XianshiID=int.Parse(ds.Tables[0].Rows[0]["XianshiID"].ToString());
				}
				model.Gonggao=ds.Tables[0].Rows[0]["Gonggao"].ToString();
				if(ds.Tables[0].Rows[0]["GongTime"].ToString()!="")
				{
					model.GongTime=DateTime.Parse(ds.Tables[0].Rows[0]["GongTime"].ToString());
				}
				model.ImageURL=ds.Tables[0].Rows[0]["ImageURL"].ToString();
				if(ds.Tables[0].Rows[0]["FenleiID"].ToString()!="")
				{
					model.FenleiID=int.Parse(ds.Tables[0].Rows[0]["FenleiID"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XianshiID,Gonggao,GongTime,ImageURL,FenleiID ");
			strSql.Append(" FROM ComPanyInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" XianshiID,Gonggao,GongTime,ImageURL,FenleiID ");
			strSql.Append(" FROM ComPanyInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "ComPanyInfo";
			parameters[1].Value = "XianshiID";
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

