using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// FuWuInfo
	/// </summary>
	public partial class FuWuInfo
	{
		private readonly Maticsoft.DAL.FuWuInfo dal=new Maticsoft.DAL.FuWuInfo();
		public FuWuInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetfuwuList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetfuwuList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetfuwuCount(string strwhere)
        {
            return dal.GetfuwuCount(strwhere);
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
		public bool Exists(int fuwuID)
		{
			return dal.Exists(fuwuID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.FuWuInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.FuWuInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int fuwuID)
		{
			
			return dal.Delete(fuwuID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string fuwuIDlist )
		{
			return dal.DeleteList(fuwuIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.FuWuInfo GetModel(int fuwuID)
		{
			
			return dal.GetModel(fuwuID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.FuWuInfo GetModelByCache(int fuwuID)
		{
			
			string CacheKey = "FuWuInfoModel-" + fuwuID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(fuwuID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.FuWuInfo)objModel;
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
		public List<Maticsoft.Model.FuWuInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.FuWuInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.FuWuInfo> modelList = new List<Maticsoft.Model.FuWuInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.FuWuInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.FuWuInfo();
					if(dt.Rows[n]["fuwuID"].ToString()!="")
					{
						model.fuwuID=int.Parse(dt.Rows[n]["fuwuID"].ToString());
					}
					model.fuwuTitle=dt.Rows[n]["fuwuTitle"].ToString();
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["FuwuTypeID"].ToString()!="")
					{
						model.FuwuTypeID=int.Parse(dt.Rows[n]["FuwuTypeID"].ToString());
					}
					model.Write=dt.Rows[n]["Write"].ToString();
					model.Fuwucontent=dt.Rows[n]["Fuwucontent"].ToString();
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

