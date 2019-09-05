using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// JiShuInfo
	/// </summary>
	public partial class JiShuInfo
	{
		private readonly Maticsoft.DAL.JiShuInfo dal=new Maticsoft.DAL.JiShuInfo();
		public JiShuInfo()
		{}
		#region  Method
        /// <summary>
        ///  ������Ϸ���������Ϣ�ķ�ҳ
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getjishuList(int PageIndex, int PageSize )
        {
            return dal.getjishuList(PageIndex, PageSize );
        }
        /// <summary>
        ///  ��ü������Ϸ�����Ϣ������
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getjishucount()
        {
            return dal.getjishucount();
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
		public bool Exists(int JishuID)
		{
			return dal.Exists(JishuID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.JiShuInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.JiShuInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int JishuID)
		{
			
			return dal.Delete(JishuID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string JishuIDlist )
		{
			return dal.DeleteList(JishuIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.JiShuInfo GetModel(int JishuID)
		{
			
			return dal.GetModel(JishuID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.JiShuInfo GetModelByCache(int JishuID)
		{
			
			string CacheKey = "JiShuInfoModel-" + JishuID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JishuID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.JiShuInfo)objModel;
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
		public List<Maticsoft.Model.JiShuInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.JiShuInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.JiShuInfo> modelList = new List<Maticsoft.Model.JiShuInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.JiShuInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.JiShuInfo();
					if(dt.Rows[n]["JishuID"].ToString()!="")
					{
						model.JishuID=int.Parse(dt.Rows[n]["JishuID"].ToString());
					}
					model.JishuTitle=dt.Rows[n]["JishuTitle"].ToString();
					model.JishuNum=dt.Rows[n]["JishuNum"].ToString();
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.jishuType=dt.Rows[n]["jishuType"].ToString();
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					model.JishuPath=dt.Rows[n]["JishuPath"].ToString();
					model.Jishucontent=dt.Rows[n]["Jishucontent"].ToString();
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

