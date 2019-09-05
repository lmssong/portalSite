using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// ���ݷ�����:FuWuTypeInfo
	/// </summary>
	public partial class FuWuTypeInfo
	{
		public FuWuTypeInfo()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FuwuTypeID", "FuWuTypeInfo"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int FuwuTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FuWuTypeInfo");
			strSql.Append(" where FuwuTypeID=@FuwuTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FuwuTypeID", SqlDbType.Int,4)};
			parameters[0].Value = FuwuTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Maticsoft.Model.FuWuTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FuWuTypeInfo(");
			strSql.Append("FuwuTypeName)");
			strSql.Append(" values (");
			strSql.Append("@FuwuTypeName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FuwuTypeName", SqlDbType.VarChar,200)};
			parameters[0].Value = model.FuwuTypeName;

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
		public bool Update(Maticsoft.Model.FuWuTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FuWuTypeInfo set ");
			strSql.Append("FuwuTypeName=@FuwuTypeName");
			strSql.Append(" where FuwuTypeID=@FuwuTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@FuwuTypeID", SqlDbType.Int,4),
					new SqlParameter("@FuwuTypeName", SqlDbType.VarChar,200)};
			parameters[0].Value = model.FuwuTypeID;
			parameters[1].Value = model.FuwuTypeName;

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
		public bool Delete(int FuwuTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FuWuTypeInfo ");
			strSql.Append(" where FuwuTypeID=@FuwuTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@FuwuTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = FuwuTypeID;

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
		public bool DeleteList(string FuwuTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FuWuTypeInfo ");
			strSql.Append(" where FuwuTypeID in ("+FuwuTypeIDlist + ")  ");
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
		public Maticsoft.Model.FuWuTypeInfo GetModel(int FuwuTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FuwuTypeID,FuwuTypeName from FuWuTypeInfo ");
			strSql.Append(" where FuwuTypeID=@FuwuTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@FuwuTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = FuwuTypeID;

			Maticsoft.Model.FuWuTypeInfo model=new Maticsoft.Model.FuWuTypeInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FuwuTypeID"].ToString()!="")
				{
					model.FuwuTypeID=int.Parse(ds.Tables[0].Rows[0]["FuwuTypeID"].ToString());
				}
				model.FuwuTypeName=ds.Tables[0].Rows[0]["FuwuTypeName"].ToString();
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
			strSql.Append("select FuwuTypeID,FuwuTypeName ");
			strSql.Append(" FROM FuWuTypeInfo ");
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
			strSql.Append(" FuwuTypeID,FuwuTypeName ");
			strSql.Append(" FROM FuWuTypeInfo ");
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
			parameters[0].Value = "FuWuTypeInfo";
			parameters[1].Value = "FuwuTypeID";
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

