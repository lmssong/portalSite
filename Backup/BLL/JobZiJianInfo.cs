using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// JobZiJianInfo
	/// </summary>
	public partial class JobZiJianInfo
	{
		private readonly Maticsoft.DAL.JobZiJianInfo dal=new Maticsoft.DAL.JobZiJianInfo();
		public JobZiJianInfo()
		{}
		#region  Method
        /// <summary>
        /// 根据条件查询分页自荐信息(查询View_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">当前页第一条数据在总数据的排行</param>
        /// <param name="PageSize">每页的大小</param>
        /// <param name="strwhere">查询条件</param>
        /// <returns>当前页数据的集合</returns>
        public DataSet GetzijianList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetzijianList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// 根据自荐条件查询商机数量(查询View_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetzijianCount(string strwhere)
        {
            return dal.GetzijianCount(strwhere);
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
		public bool Exists(int JobInfoID)
		{
			return dal.Exists(JobInfoID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.JobZiJianInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.JobZiJianInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JobInfoID)
		{
			
			return dal.Delete(JobInfoID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JobInfoIDlist )
		{
			return dal.DeleteList(JobInfoIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.JobZiJianInfo GetModel(int JobInfoID)
		{
			
			return dal.GetModel(JobInfoID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.JobZiJianInfo GetModelByCache(int JobInfoID)
		{
			
			string CacheKey = "JobZiJianInfoModel-" + JobInfoID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JobInfoID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.JobZiJianInfo)objModel;
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
		public List<Maticsoft.Model.JobZiJianInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.JobZiJianInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.JobZiJianInfo> modelList = new List<Maticsoft.Model.JobZiJianInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.JobZiJianInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.JobZiJianInfo();
					if(dt.Rows[n]["JobInfoID"].ToString()!="")
					{
						model.JobInfoID=int.Parse(dt.Rows[n]["JobInfoID"].ToString());
					}
					model.Usersname=dt.Rows[n]["Usersname"].ToString();
					if(dt.Rows[n]["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dt.Rows[n]["Sex"].ToString());
					}
					model.Xueli=dt.Rows[n]["Xueli"].ToString();
					if(dt.Rows[n]["datatime"].ToString()!="")
					{
						model.datatime=DateTime.Parse(dt.Rows[n]["datatime"].ToString());
					}
					model.Monery=dt.Rows[n]["Monery"].ToString();
					model.Jiguan=dt.Rows[n]["Jiguan"].ToString();
					if(dt.Rows[n]["Britday"].ToString()!="")
					{
						model.Britday=DateTime.Parse(dt.Rows[n]["Britday"].ToString());
					}
					model.Zhuanye=dt.Rows[n]["Zhuanye"].ToString();
					model.Jiaoyu=dt.Rows[n]["Jiaoyu"].ToString();
					model.Jingyan=dt.Rows[n]["Jingyan"].ToString();
					model.Pingjia=dt.Rows[n]["Pingjia"].ToString();
					model.Jobtitle=dt.Rows[n]["Jobtitle"].ToString();
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

