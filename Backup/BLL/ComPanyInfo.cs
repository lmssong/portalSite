using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// ComPanyInfo
	/// </summary>
	public partial class ComPanyInfo
	{
		private readonly Maticsoft.DAL.ComPanyInfo dal=new Maticsoft.DAL.ComPanyInfo();
		public ComPanyInfo()
		{ }
        #region  Method
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetgonggaoMaxID(int FenleiID)
        {
            return dal.GetgonggaoMaxID(FenleiID);
        }


        /// <summary>
        ///  获得环境发布信息的分页
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet gethuanjingList(int PageIndex, int PageSize, int FenleiID)
        {
            return dal.gethuanjingList(PageIndex, PageSize, FenleiID);
        }
        /// <summary>
        ///  获得环境发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int gethuanjingCount(int FenleiID)
        {
            return dal.gethuanjingCount(FenleiID);
        }


        /// <summary>
        /// 网站公告更新一条数据
        /// </summary>
        public bool getupdate(Maticsoft.Model.ComPanyInfo model)
        {
            return dal.getupdate(model);
        }



        /// <summary>
        /// 网站公告得到一个对象实体
        /// </summary>
        public Maticsoft.Model.ComPanyInfo GetgonggaoModel(int FenleiID)
        {

            return dal.GetgonggaoModel(FenleiID);
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
        public bool Exists(int FenleiID)
		{
            return dal.Exists(FenleiID);
		}
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool getfenleiExists(int FenleiID)
        {
            return dal.getfenleiExists(FenleiID);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.ComPanyInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.ComPanyInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int XianshiID)
		{
			
			return dal.Delete(XianshiID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string XianshiIDlist )
		{
			return dal.DeleteList(XianshiIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.ComPanyInfo GetModel(int XianshiID)
		{
			
			return dal.GetModel(XianshiID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.ComPanyInfo GetModelByCache(int XianshiID)
		{
			
			string CacheKey = "ComPanyInfoModel-" + XianshiID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(XianshiID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.ComPanyInfo)objModel;
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
		public List<Maticsoft.Model.ComPanyInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.ComPanyInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.ComPanyInfo> modelList = new List<Maticsoft.Model.ComPanyInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.ComPanyInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.ComPanyInfo();
					if(dt.Rows[n]["XianshiID"].ToString()!="")
					{
						model.XianshiID=int.Parse(dt.Rows[n]["XianshiID"].ToString());
					}
					model.Gonggao=dt.Rows[n]["Gonggao"].ToString();
					if(dt.Rows[n]["GongTime"].ToString()!="")
					{
						model.GongTime=DateTime.Parse(dt.Rows[n]["GongTime"].ToString());
					}
					model.ImageURL=dt.Rows[n]["ImageURL"].ToString();
					if(dt.Rows[n]["FenleiID"].ToString()!="")
					{
						model.FenleiID=int.Parse(dt.Rows[n]["FenleiID"].ToString());
					}
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

