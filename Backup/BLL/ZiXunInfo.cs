using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// ZiXunInfo
	/// </summary>
	public partial class ZiXunInfo
	{
		private readonly Maticsoft.DAL.ZiXunInfo dal=new Maticsoft.DAL.ZiXunInfo();
		public ZiXunInfo()
		{}
		#region  Method
        /// <summary>
        /// ����������ѯ��ҳ�̻���Ϣ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet GetzixunList(int PageIndex, int PageSize,string where)
        {
            return dal.GetzixunList(PageIndex, PageSize,where );
        }

        /// <summary>
        /// ����������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetzixunCount(string where)
        {
            return dal.GetzixunCount(where);
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
		public bool Exists(int zixunID)
		{
			return dal.Exists(zixunID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.ZiXunInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.ZiXunInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int zixunID)
		{
			
			return dal.Delete(zixunID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string zixunIDlist )
		{
			return dal.DeleteList(zixunIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.ZiXunInfo GetModel(int zixunID)
		{
			
			return dal.GetModel(zixunID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.ZiXunInfo GetModelByCache(int zixunID)
		{
			
			string CacheKey = "ZiXunInfoModel-" + zixunID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(zixunID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.ZiXunInfo)objModel;
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
		public List<Maticsoft.Model.ZiXunInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.ZiXunInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.ZiXunInfo> modelList = new List<Maticsoft.Model.ZiXunInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.ZiXunInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.ZiXunInfo();
					if(dt.Rows[n]["zixunID"].ToString()!="")
					{
						model.zixunID=int.Parse(dt.Rows[n]["zixunID"].ToString());
					}
					model.zixunTitle=dt.Rows[n]["zixunTitle"].ToString();
					if(dt.Rows[n]["zixuntime"].ToString()!="")
					{
						model.zixuntime=DateTime.Parse(dt.Rows[n]["zixuntime"].ToString());
					}
					model.zixuncontent=dt.Rows[n]["zixuncontent"].ToString();
					model.zixunUserName=dt.Rows[n]["zixunUserName"].ToString();
					model.zixunuserPhoto=dt.Rows[n]["zixunuserPhoto"].ToString();
					model.ZiXundaan=dt.Rows[n]["ZiXundaan"].ToString();
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

