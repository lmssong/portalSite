using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// Product
	/// </summary>
	public partial class Product
	{
		private readonly Maticsoft.DAL.Product dal=new Maticsoft.DAL.Product();
		public Product()
		{}
		#region  Method
        /// <summary>
        /// ����������ѯ��ҳ�̻���Ϣ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet getproList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.getproList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// ����������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int getproCount(string strwhere)
        {
            return dal.getproCount(strwhere);
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
		public bool Exists(int ProID)
		{
			return dal.Exists(ProID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.Product model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.Product model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int ProID)
		{
			
			return dal.Delete(ProID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string ProIDlist )
		{
			return dal.DeleteList(ProIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.Product GetModel(int ProID)
		{
			
			return dal.GetModel(ProID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.Product GetModelByCache(int ProID)
		{
			
			string CacheKey = "ProductModel-" + ProID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ProID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.Product)objModel;
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
		public List<Maticsoft.Model.Product> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.Product> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.Product> modelList = new List<Maticsoft.Model.Product>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.Product model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.Product();
					if(dt.Rows[n]["ProID"].ToString()!="")
					{
						model.ProID=int.Parse(dt.Rows[n]["ProID"].ToString());
					}
					model.ProName=dt.Rows[n]["ProName"].ToString();
					if(dt.Rows[n]["ProTypeID"].ToString()!="")
					{
						model.ProTypeID=int.Parse(dt.Rows[n]["ProTypeID"].ToString());
					}
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["ProXingID"].ToString()!="")
					{
						model.ProXingID=int.Parse(dt.Rows[n]["ProXingID"].ToString());
					}
					if(dt.Rows[n]["Prochutime"].ToString()!="")
					{
						model.Prochutime=DateTime.Parse(dt.Rows[n]["Prochutime"].ToString());
					}
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					if(dt.Rows[n]["Toujian"].ToString()!="")
					{
						model.Toujian=int.Parse(dt.Rows[n]["Toujian"].ToString());
					}
					if(dt.Rows[n]["HitNum"].ToString()!="")
					{
						model.HitNum=int.Parse(dt.Rows[n]["HitNum"].ToString());
					}
					model.Procontent=dt.Rows[n]["Procontent"].ToString();
					model.ProMonery=dt.Rows[n]["ProMonery"].ToString();
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

