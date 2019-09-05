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
        ///  获得资料发布发布信息的分页
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getjishuList(int PageIndex, int PageSize )
        {
            return dal.getjishuList(PageIndex, PageSize );
        }
        /// <summary>
        ///  获得技术资料发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getjishucount()
        {
            return dal.getjishucount();
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
		public bool Exists(int JishuID)
		{
			return dal.Exists(JishuID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.JiShuInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.JiShuInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JishuID)
		{
			
			return dal.Delete(JishuID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JishuIDlist )
		{
			return dal.DeleteList(JishuIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.JiShuInfo GetModel(int JishuID)
		{
			
			return dal.GetModel(JishuID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
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
		public List<Maticsoft.Model.JiShuInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
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

