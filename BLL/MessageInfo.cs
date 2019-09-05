using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// MessageInfo
	/// </summary>
	public partial class MessageInfo
	{
		private readonly Maticsoft.DAL.MessageInfo dal=new Maticsoft.DAL.MessageInfo();
		public MessageInfo()
		{}
		#region  Method
        /// <summary>
        /// �������Բ�ѯ��ҳ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet GetmessList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetmessList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// ��������������ѯ ����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetmessCount(string strwhere)
        {
            return dal.GetmessCount(strwhere);
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
		public bool Exists(int MessID)
		{
			return dal.Exists(MessID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.MessageInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.MessageInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int MessID)
		{
			
			return dal.Delete(MessID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string MessIDlist )
		{
			return dal.DeleteList(MessIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.MessageInfo GetModel(int MessID)
		{
			
			return dal.GetModel(MessID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.MessageInfo GetModelByCache(int MessID)
		{
			
			string CacheKey = "MessageInfoModel-" + MessID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MessID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.MessageInfo)objModel;
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
		public List<Maticsoft.Model.MessageInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.MessageInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.MessageInfo> modelList = new List<Maticsoft.Model.MessageInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.MessageInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.MessageInfo();
					if(dt.Rows[n]["MessID"].ToString()!="")
					{
						model.MessID=int.Parse(dt.Rows[n]["MessID"].ToString());
					}
					model.MessTitle=dt.Rows[n]["MessTitle"].ToString();
					model.Username=dt.Rows[n]["Username"].ToString();
					if(dt.Rows[n]["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dt.Rows[n]["Sex"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					model.Address=dt.Rows[n]["Address"].ToString();
					model.Linkphoto=dt.Rows[n]["Linkphoto"].ToString();
					model.Email=dt.Rows[n]["Email"].ToString();
					model.Messcontent=dt.Rows[n]["Messcontent"].ToString();
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

