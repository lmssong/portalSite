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
        /// 根据留言查询分页(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetmessList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetmessList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// 根据留言条件查询 数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetmessCount(string strwhere)
        {
            return dal.GetmessCount(strwhere);
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
		public bool Exists(int MessID)
		{
			return dal.Exists(MessID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.MessageInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.MessageInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MessID)
		{
			
			return dal.Delete(MessID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string MessIDlist )
		{
			return dal.DeleteList(MessIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.MessageInfo GetModel(int MessID)
		{
			
			return dal.GetModel(MessID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
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
		public List<Maticsoft.Model.MessageInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
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

