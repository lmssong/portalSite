using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// NicheInfo
	/// </summary>
	public partial class NicheInfo
	{
		private readonly Maticsoft.DAL.NicheInfo dal=new Maticsoft.DAL.NicheInfo();
		public NicheInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetnicheList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetnicheList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetnicheCount(string strwhere)
        {
            return dal.GetnicheCount(strwhere);
        }

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NicheID)
		{
			return dal.Exists(NicheID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.NicheInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.NicheInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NicheID)
		{
			
			return dal.Delete(NicheID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NicheIDlist )
		{
			return dal.DeleteList(NicheIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.NicheInfo GetModel(int NicheID)
		{
			
			return dal.GetModel(NicheID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.NicheInfo GetModelByCache(int NicheID)
		{
			
			string CacheKey = "NicheInfoModel-" + NicheID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NicheID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.NicheInfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.NicheInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.NicheInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.NicheInfo> modelList = new List<Maticsoft.Model.NicheInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.NicheInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.NicheInfo();
					if(dt.Rows[n]["NicheID"].ToString()!="")
					{
						model.NicheID=int.Parse(dt.Rows[n]["NicheID"].ToString());
					}
					model.NicheTitle=dt.Rows[n]["NicheTitle"].ToString();
					model.NicheKey=dt.Rows[n]["NicheKey"].ToString();
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.Write=dt.Rows[n]["Write"].ToString();
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["NicheTypeID"].ToString()!="")
					{
						model.NicheTypeID=int.Parse(dt.Rows[n]["NicheTypeID"].ToString());
					}
					if(dt.Rows[n]["HitNum"].ToString()!="")
					{
						model.HitNum=int.Parse(dt.Rows[n]["HitNum"].ToString());
					}
					model.NicheContent=dt.Rows[n]["NicheContent"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

