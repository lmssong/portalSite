using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// WeiLanInfo
	/// </summary>
	public partial class WeiLanInfo
	{
		private readonly Maticsoft.DAL.WeiLanInfo dal=new Maticsoft.DAL.WeiLanInfo();
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
            return dal.GetweilanList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// ����������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetweilanCount(string strwhere)
        {
            return dal.GetweilanCount(strwhere);
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
		public bool Exists(int WeiID)
		{
			return dal.Exists(WeiID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.WeiLanInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.WeiLanInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int WeiID)
		{
			
			return dal.Delete(WeiID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string WeiIDlist )
		{
			return dal.DeleteList(WeiIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.WeiLanInfo GetModel(int WeiID)
		{
			
			return dal.GetModel(WeiID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.WeiLanInfo GetModelByCache(int WeiID)
		{
			
			string CacheKey = "WeiLanInfoModel-" + WeiID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(WeiID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.WeiLanInfo)objModel;
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
		public List<Maticsoft.Model.WeiLanInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.WeiLanInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.WeiLanInfo> modelList = new List<Maticsoft.Model.WeiLanInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.WeiLanInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.WeiLanInfo();
					if(dt.Rows[n]["WeiID"].ToString()!="")
					{
						model.WeiID=int.Parse(dt.Rows[n]["WeiID"].ToString());
					}
					model.WeiTitle=dt.Rows[n]["WeiTitle"].ToString();
					model.WeiKey=dt.Rows[n]["WeiKey"].ToString();
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.Write=dt.Rows[n]["Write"].ToString();
					if(dt.Rows[n]["HitNum"].ToString()!="")
					{
						model.HitNum=int.Parse(dt.Rows[n]["HitNum"].ToString());
					}
					model.Weicontent=dt.Rows[n]["Weicontent"].ToString();
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

