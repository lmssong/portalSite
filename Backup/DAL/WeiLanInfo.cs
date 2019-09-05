using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// ���ݷ�����:WeiLanInfo
	/// </summary>
	public partial class WeiLanInfo
	{
		public WeiLanInfo()
		{}
		#region  Method
        /// <summary>
        /// ����������ѯ��ҳ�̻���Ϣ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet GetweilanList(int PageIndex, int PageSize, string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + PageSize + " * ");
            strSql.Append(" FROM WeiLanInfo ");
            strSql.Append(" where ");
            if (strwhere != "")
            {
                strSql.Append(strwhere + " and ");

            }
            strSql.Append("  WeiID not in (select top " + PageIndex + " WeiID from WeiLanInfo ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);

            }
            strSql.Append(" order by Fatime desc) order by Fatime desc");

            return DbHelperSQL.Query(strSql.ToString());
        }



        /// <summary>
        /// ����������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetweilanCount(string strwhere)
        {
            int count = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append(" FROM WeiLanInfo ");
            if (strwhere != "")
            {
                strSql.Append(" where " + strwhere);
            }

            count = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
            return count;
        }




		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("WeiID", "WeiLanInfo"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int WeiID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WeiLanInfo");
			strSql.Append(" where WeiID=@WeiID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WeiID", SqlDbType.Int,4)};
			parameters[0].Value = WeiID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Maticsoft.Model.WeiLanInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WeiLanInfo(");
			strSql.Append("WeiTitle,WeiKey,Fatime,Write,HitNum,Weicontent)");
			strSql.Append(" values (");
			strSql.Append("@WeiTitle,@WeiKey,@Fatime,@Write,@HitNum,@Weicontent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WeiTitle", SqlDbType.VarChar,200),
					new SqlParameter("@WeiKey", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@Weicontent", SqlDbType.Text)};
			parameters[0].Value = model.WeiTitle;
			parameters[1].Value = model.WeiKey;
			parameters[2].Value = model.Fatime;
			parameters[3].Value = model.Write;
			parameters[4].Value = model.HitNum;
			parameters[5].Value = model.Weicontent;

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
		public bool Update(Maticsoft.Model.WeiLanInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WeiLanInfo set ");
			strSql.Append("WeiTitle=@WeiTitle,");
			strSql.Append("WeiKey=@WeiKey,");
			strSql.Append("Fatime=@Fatime,");
			strSql.Append("Write=@Write,");
			strSql.Append("HitNum=@HitNum,");
			strSql.Append("Weicontent=@Weicontent");
			strSql.Append(" where WeiID=@WeiID");
			SqlParameter[] parameters = {
					new SqlParameter("@WeiID", SqlDbType.Int,4),
					new SqlParameter("@WeiTitle", SqlDbType.VarChar,200),
					new SqlParameter("@WeiKey", SqlDbType.VarChar,200),
					new SqlParameter("@Fatime", SqlDbType.DateTime),
					new SqlParameter("@Write", SqlDbType.VarChar,200),
					new SqlParameter("@HitNum", SqlDbType.Int,4),
					new SqlParameter("@Weicontent", SqlDbType.Text)};
			parameters[0].Value = model.WeiID;
			parameters[1].Value = model.WeiTitle;
			parameters[2].Value = model.WeiKey;
			parameters[3].Value = model.Fatime;
			parameters[4].Value = model.Write;
			parameters[5].Value = model.HitNum;
			parameters[6].Value = model.Weicontent;

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
		public bool Delete(int WeiID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WeiLanInfo ");
			strSql.Append(" where WeiID=@WeiID");
			SqlParameter[] parameters = {
					new SqlParameter("@WeiID", SqlDbType.Int,4)
};
			parameters[0].Value = WeiID;

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
		public bool DeleteList(string WeiIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WeiLanInfo ");
			strSql.Append(" where WeiID in ("+WeiIDlist + ")  ");
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
		public Maticsoft.Model.WeiLanInfo GetModel(int WeiID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 WeiID,WeiTitle,WeiKey,Fatime,Write,HitNum,Weicontent from WeiLanInfo ");
			strSql.Append(" where WeiID=@WeiID");
			SqlParameter[] parameters = {
					new SqlParameter("@WeiID", SqlDbType.Int,4)
};
			parameters[0].Value = WeiID;

			Maticsoft.Model.WeiLanInfo model=new Maticsoft.Model.WeiLanInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["WeiID"].ToString()!="")
				{
					model.WeiID=int.Parse(ds.Tables[0].Rows[0]["WeiID"].ToString());
				}
				model.WeiTitle=ds.Tables[0].Rows[0]["WeiTitle"].ToString();
				model.WeiKey=ds.Tables[0].Rows[0]["WeiKey"].ToString();
				if(ds.Tables[0].Rows[0]["Fatime"].ToString()!="")
				{
					model.Fatime=DateTime.Parse(ds.Tables[0].Rows[0]["Fatime"].ToString());
				}
				model.Write=ds.Tables[0].Rows[0]["Write"].ToString();
				if(ds.Tables[0].Rows[0]["HitNum"].ToString()!="")
				{
					model.HitNum=int.Parse(ds.Tables[0].Rows[0]["HitNum"].ToString());
				}
				model.Weicontent=ds.Tables[0].Rows[0]["Weicontent"].ToString();
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
			strSql.Append("select WeiID,WeiTitle,WeiKey,Fatime,Write,HitNum,Weicontent ");
			strSql.Append(" FROM WeiLanInfo ");
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
			strSql.Append(" WeiID,WeiTitle,WeiKey,Fatime,Write,HitNum,Weicontent ");
			strSql.Append(" FROM WeiLanInfo ");
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
			parameters[0].Value = "WeiLanInfo";
			parameters[1].Value = "WeiID";
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

