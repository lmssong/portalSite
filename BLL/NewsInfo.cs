using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// NewsInfo
	/// </summary>
	public partial class NewsInfo
	{
		private readonly Maticsoft.DAL.NewsInfo dal=new Maticsoft.DAL.NewsInfo();
		public NewsInfo()
		{}
		#region  Method
        /// <summary>
        /// ����������ѯ��ҳ������Ϣ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet GeNewsList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GeNewsList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// ��������������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetNewCount(string strwhere)
        {
            return dal.GetNewCount(strwhere);
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
		public bool Exists(int NewsID)
		{
			return dal.Exists(NewsID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.NewsInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.NewsInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int NewsID)
		{
			
			return dal.Delete(NewsID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string NewsIDlist )
		{
			return dal.DeleteList(NewsIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.NewsInfo GetModel(int NewsID)
		{
			
			return dal.GetModel(NewsID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.NewsInfo GetModelByCache(int NewsID)
		{
			
			string CacheKey = "NewsInfoModel-" + NewsID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NewsID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.NewsInfo)objModel;
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
		public List<Maticsoft.Model.NewsInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.NewsInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.NewsInfo> modelList = new List<Maticsoft.Model.NewsInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.NewsInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.NewsInfo();
					if(dt.Rows[n]["NewsID"].ToString()!="")
					{
						model.NewsID=int.Parse(dt.Rows[n]["NewsID"].ToString());
					}
					model.NewsTitle=dt.Rows[n]["NewsTitle"].ToString();
					model.NewsKey=dt.Rows[n]["NewsKey"].ToString();
					model.Write=dt.Rows[n]["Write"].ToString();
					if(dt.Rows[n]["NewsTypeID"].ToString()!="")
					{
						model.NewsTypeID=int.Parse(dt.Rows[n]["NewsTypeID"].ToString());
					}
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["HitNum"].ToString()!="")
					{
						model.HitNum=int.Parse(dt.Rows[n]["HitNum"].ToString());
					}
					model.NewsContent=dt.Rows[n]["NewsContent"].ToString();
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

