using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// FuWuTypeInfo
	/// </summary>
	public partial class FuWuTypeInfo
	{
		private readonly Maticsoft.DAL.FuWuTypeInfo dal=new Maticsoft.DAL.FuWuTypeInfo();
		public FuWuTypeInfo()
		{}
		#region  Method

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
		public bool Exists(int FuwuTypeID)
		{
			return dal.Exists(FuwuTypeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.FuWuTypeInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.FuWuTypeInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int FuwuTypeID)
		{
			
			return dal.Delete(FuwuTypeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FuwuTypeIDlist )
		{
			return dal.DeleteList(FuwuTypeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.FuWuTypeInfo GetModel(int FuwuTypeID)
		{
			
			return dal.GetModel(FuwuTypeID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.FuWuTypeInfo GetModelByCache(int FuwuTypeID)
		{
			
			string CacheKey = "FuWuTypeInfoModel-" + FuwuTypeID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FuwuTypeID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.FuWuTypeInfo)objModel;
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
		public List<Maticsoft.Model.FuWuTypeInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.FuWuTypeInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.FuWuTypeInfo> modelList = new List<Maticsoft.Model.FuWuTypeInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.FuWuTypeInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.FuWuTypeInfo();
					if(dt.Rows[n]["FuwuTypeID"].ToString()!="")
					{
						model.FuwuTypeID=int.Parse(dt.Rows[n]["FuwuTypeID"].ToString());
					}
					model.FuwuTypeName=dt.Rows[n]["FuwuTypeName"].ToString();
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

