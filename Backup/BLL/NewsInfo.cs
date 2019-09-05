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
        /// 根据条件查询分页新闻信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GeNewsList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GeNewsList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// 根据新闻条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetNewCount(string strwhere)
        {
            return dal.GetNewCount(strwhere);
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
		public bool Exists(int NewsID)
		{
			return dal.Exists(NewsID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.NewsInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.NewsInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NewsID)
		{
			
			return dal.Delete(NewsID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NewsIDlist )
		{
			return dal.DeleteList(NewsIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.NewsInfo GetModel(int NewsID)
		{
			
			return dal.GetModel(NewsID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
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
		public List<Maticsoft.Model.NewsInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
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

