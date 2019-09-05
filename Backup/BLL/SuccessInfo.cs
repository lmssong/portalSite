using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// SuccessInfo
	/// </summary>
	public partial class SuccessInfo
	{
		private readonly Maticsoft.DAL.SuccessInfo dal=new Maticsoft.DAL.SuccessInfo();
		public SuccessInfo()
		{}
		#region  Method
        /// <summary>
        ///  ��óɹ�������Ϣ�ķ�ҳ
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getsuccessList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.getsuccessList(PageIndex, PageSize, strwhere);
        }
        /// <summary>
        ///  ��óɹ�������Ϣ�ķ�ҳ����
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getsuccessCount(string strwhere)
        {
            return dal.getsuccessCount(strwhere);
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
		public bool Exists(int SuccessID)
		{
			return dal.Exists(SuccessID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.SuccessInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.SuccessInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int SuccessID)
		{
			
			return dal.Delete(SuccessID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string SuccessIDlist )
		{
			return dal.DeleteList(SuccessIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.SuccessInfo GetModel(int SuccessID)
		{
			
			return dal.GetModel(SuccessID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.SuccessInfo GetModelByCache(int SuccessID)
		{
			
			string CacheKey = "SuccessInfoModel-" + SuccessID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SuccessID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.SuccessInfo)objModel;
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
		public List<Maticsoft.Model.SuccessInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.SuccessInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.SuccessInfo> modelList = new List<Maticsoft.Model.SuccessInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.SuccessInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.SuccessInfo();
					if(dt.Rows[n]["SuccessID"].ToString()!="")
					{
						model.SuccessID=int.Parse(dt.Rows[n]["SuccessID"].ToString());
					}
					model.SuccessTitle=dt.Rows[n]["SuccessTitle"].ToString();
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.Write=dt.Rows[n]["Write"].ToString();
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["HitNum"].ToString()!="")
					{
						model.HitNum=int.Parse(dt.Rows[n]["HitNum"].ToString());
					}
					model.SuccessContent=dt.Rows[n]["SuccessContent"].ToString();
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

