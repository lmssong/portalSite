using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// JobInfo
	/// </summary>
	public partial class JobInfo
	{
		private readonly Maticsoft.DAL.JobInfo dal=new Maticsoft.DAL.JobInfo();
		public JobInfo()
		{}
		#region  Method
        /// <summary>
        ///  获得招聘发布发布信息的分页
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public DataSet getjobList(int PageIndex, int PageSize)
        {
            return dal.getjobList(PageIndex, PageSize);
        }
        /// <summary>
        ///  获得招聘资料发布信息的数量
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public int getjobcount()
        {
            return dal.getjobcount();
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
		public bool Exists(int JobID)
		{
			return dal.Exists(JobID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.JobInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.JobInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int JobID)
		{
			
			return dal.Delete(JobID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JobIDlist )
		{
			return dal.DeleteList(JobIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.JobInfo GetModel(int JobID)
		{
			
			return dal.GetModel(JobID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.JobInfo GetModelByCache(int JobID)
		{
			
			string CacheKey = "JobInfoModel-" + JobID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JobID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.JobInfo)objModel;
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
		public List<Maticsoft.Model.JobInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.JobInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.JobInfo> modelList = new List<Maticsoft.Model.JobInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.JobInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.JobInfo();
					if(dt.Rows[n]["JobID"].ToString()!="")
					{
						model.JobID=int.Parse(dt.Rows[n]["JobID"].ToString());
					}
					model.JobTitle=dt.Rows[n]["JobTitle"].ToString();
					model.Address=dt.Rows[n]["Address"].ToString();
					model.Nunber=dt.Rows[n]["Nunber"].ToString();
					if(dt.Rows[n]["Starttime"].ToString()!="")
					{
						model.Starttime=DateTime.Parse(dt.Rows[n]["Starttime"].ToString());
					}
					model.Duxiang=dt.Rows[n]["Duxiang"].ToString();
					model.Age=dt.Rows[n]["Age"].ToString();
					model.Xueli=dt.Rows[n]["Xueli"].ToString();
					model.Monery=dt.Rows[n]["Monery"].ToString();
					model.Zhuanye=dt.Rows[n]["Zhuanye"].ToString();
					if(dt.Rows[n]["Endtime"].ToString()!="")
					{
						model.Endtime=DateTime.Parse(dt.Rows[n]["Endtime"].ToString());
					}
					model.Miaoshu=dt.Rows[n]["Miaoshu"].ToString();
					model.Lianxi=dt.Rows[n]["Lianxi"].ToString();
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

