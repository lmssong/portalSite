using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// DingProduct
	/// </summary>
	public partial class DingProduct
	{
		private readonly Maticsoft.DAL.DingProduct dal=new Maticsoft.DAL.DingProduct();
		public DingProduct()
		{}
		#region  Method
        /// <summary>
        /// ����������ѯ��ҳ�̻���Ϣ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet GetDingList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetDingList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// ����������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetDingCount(string strwhere)
        {
            return dal.GetDingCount(strwhere);
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
		public bool Exists(int DingID)
		{
			return dal.Exists(DingID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.DingProduct model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.DingProduct model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int DingID)
		{
			
			return dal.Delete(DingID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string DingIDlist )
		{
			return dal.DeleteList(DingIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.DingProduct GetModel(int DingID)
		{
			
			return dal.GetModel(DingID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.DingProduct GetModelByCache(int DingID)
		{
			
			string CacheKey = "DingProductModel-" + DingID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DingID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.DingProduct)objModel;
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
		public List<Maticsoft.Model.DingProduct> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.DingProduct> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.DingProduct> modelList = new List<Maticsoft.Model.DingProduct>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.DingProduct model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.DingProduct();
					if(dt.Rows[n]["DingID"].ToString()!="")
					{
						model.DingID=int.Parse(dt.Rows[n]["DingID"].ToString());
					}
					model.ProName=dt.Rows[n]["ProName"].ToString();
					if(dt.Rows[n]["ProXingID"].ToString()!="")
					{
						model.ProXingID=int.Parse(dt.Rows[n]["ProXingID"].ToString());
					}
					if(dt.Rows[n]["ProTypeID"].ToString()!="")
					{
						model.ProTypeID=int.Parse(dt.Rows[n]["ProTypeID"].ToString());
					}
					model.DingNum=dt.Rows[n]["DingNum"].ToString();
					model.DingAddress=dt.Rows[n]["DingAddress"].ToString();
					model.LinkPhoto=dt.Rows[n]["LinkPhoto"].ToString();
					model.DingEmail=dt.Rows[n]["DingEmail"].ToString();
					if(dt.Rows[n]["DingSex"].ToString()!="")
					{
						model.DingSex=int.Parse(dt.Rows[n]["DingSex"].ToString());
					}
					model.UsersName=dt.Rows[n]["UsersName"].ToString();
					if(dt.Rows[n]["Dingtime"].ToString()!="")
					{
						model.Dingtime=DateTime.Parse(dt.Rows[n]["Dingtime"].ToString());
					}
					model.Dingcontent=dt.Rows[n]["Dingcontent"].ToString();
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

