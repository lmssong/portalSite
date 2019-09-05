using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// ComPany
	/// </summary>
	public partial class ComPany
	{
		private readonly Maticsoft.DAL.ComPany dal=new Maticsoft.DAL.ComPany();
		public ComPany()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int CompanyID)
		{
			return dal.Exists(CompanyID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.ComPany model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.ComPany model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int CompanyID)
		{
			
			return dal.Delete(CompanyID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string CompanyIDlist )
		{
			return dal.DeleteList(CompanyIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.ComPany GetModel(int CompanyID)
		{
			
			return dal.GetModel(CompanyID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.ComPany GetModelByCache(int CompanyID)
		{
			
			string CacheKey = "ComPanyModel-" + CompanyID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CompanyID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.ComPany)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.ComPany> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.ComPany> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.ComPany> modelList = new List<Maticsoft.Model.ComPany>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.ComPany model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.ComPany();
					if(dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					model.CompanyNames=dt.Rows[n]["CompanyNames"].ToString();
					model.CompanyType=dt.Rows[n]["CompanyType"].ToString();
					model.Fanren=dt.Rows[n]["Fanren"].ToString();
					model.ComAddress=dt.Rows[n]["ComAddress"].ToString();
					model.ComFax=dt.Rows[n]["ComFax"].ToString();
					model.ComPhoto=dt.Rows[n]["ComPhoto"].ToString();
					model.ComEmail=dt.Rows[n]["ComEmail"].ToString();
					model.QQ=dt.Rows[n]["QQ"].ToString();
					model.Comwangzhi=dt.Rows[n]["Comwangzhi"].ToString();
					model.comconten=dt.Rows[n]["comconten"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

