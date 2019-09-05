using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// MemberInfo
	/// </summary>
	public partial class MemberInfo
	{
		private readonly Maticsoft.DAL.MemberInfo dal=new Maticsoft.DAL.MemberInfo();
		public MemberInfo()
		{}
		#region  Method
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Maticsoft.Model.MemberInfo GetpassModel(string MemberName)
        {

            return dal.GetpassModel(MemberName);
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool GetExists(string MemberName)
        {
            return dal.GetExists(MemberName);
        }


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
		public bool Exists(int MemberID)
		{
			return dal.Exists(MemberID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.MemberInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.MemberInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int MemberID)
		{
			
			return dal.Delete(MemberID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string MemberIDlist )
		{
			return dal.DeleteList(MemberIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.MemberInfo GetModel(int MemberID)
		{
			
			return dal.GetModel(MemberID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.MemberInfo GetModelByCache(int MemberID)
		{
			
			string CacheKey = "MemberInfoModel-" + MemberID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MemberID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.MemberInfo)objModel;
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
		public List<Maticsoft.Model.MemberInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.MemberInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.MemberInfo> modelList = new List<Maticsoft.Model.MemberInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.MemberInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.MemberInfo();
					if(dt.Rows[n]["MemberID"].ToString()!="")
					{
						model.MemberID=int.Parse(dt.Rows[n]["MemberID"].ToString());
					}
					model.MemberName=dt.Rows[n]["MemberName"].ToString();
					model.Password=dt.Rows[n]["Password"].ToString();
					if(dt.Rows[n]["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dt.Rows[n]["Sex"].ToString());
					}
					model.Linkphoto=dt.Rows[n]["Linkphoto"].ToString();
					model.Email=dt.Rows[n]["Email"].ToString();
					model.QQMSN=dt.Rows[n]["QQMSN"].ToString();
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

