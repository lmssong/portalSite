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
        /// 根据条件查询分页商机信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetweilanList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetweilanList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// 根据条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetweilanCount(string strwhere)
        {
            return dal.GetweilanCount(strwhere);
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
		public bool Exists(int WeiID)
		{
			return dal.Exists(WeiID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.WeiLanInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.WeiLanInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int WeiID)
		{
			
			return dal.Delete(WeiID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string WeiIDlist )
		{
			return dal.DeleteList(WeiIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.WeiLanInfo GetModel(int WeiID)
		{
			
			return dal.GetModel(WeiID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
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
		public List<Maticsoft.Model.WeiLanInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
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

