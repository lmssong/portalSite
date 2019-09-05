using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// SuccessInfo
	/// </summary>
	public partial class SuccessInfo
	{
		private readonly Maticsoft.DAL.SuccessInfo dal=new Maticsoft.DAL.SuccessInfo();
		public SuccessInfo()
		{}
		#region  Method
        /// <summary>
        ///  获得成功案例信息的分页
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getsuccessList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.getsuccessList(PageIndex, PageSize, strwhere);
        }
        /// <summary>
        ///  获得成功案例信息的分页数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getsuccessCount(string strwhere)
        {
            return dal.getsuccessCount(strwhere);
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
		public bool Exists(int SuccessID)
		{
			return dal.Exists(SuccessID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.SuccessInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.SuccessInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SuccessID)
		{
			
			return dal.Delete(SuccessID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SuccessIDlist )
		{
			return dal.DeleteList(SuccessIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.SuccessInfo GetModel(int SuccessID)
		{
			
			return dal.GetModel(SuccessID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.SuccessInfo GetModelByCache(int SuccessID)
		{
			
			string CacheKey = "SuccessInfoModel-" + SuccessID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SuccessID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.SuccessInfo)objModel;
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
		public List<Maticsoft.Model.SuccessInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.SuccessInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.SuccessInfo> modelList = new List<Maticsoft.Model.SuccessInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.SuccessInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.SuccessInfo();
					if(dt.Rows[n]["SuccessID"].ToString()!="")
					{
						model.SuccessID=int.Parse(dt.Rows[n]["SuccessID"].ToString());
					}
					model.SuccessTitle=dt.Rows[n]["SuccessTitle"].ToString();
					if(dt.Rows[n]["Fatime"].ToString()!="")
					{
						model.Fatime=DateTime.Parse(dt.Rows[n]["Fatime"].ToString());
					}
					model.Write=dt.Rows[n]["Write"].ToString();
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["HitNum"].ToString()!="")
					{
						model.HitNum=int.Parse(dt.Rows[n]["HitNum"].ToString());
					}
					model.SuccessContent=dt.Rows[n]["SuccessContent"].ToString();
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

