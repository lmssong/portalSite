using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// MemberInfo
	/// </summary>
	public partial class MemberInfo
	{
		private readonly Maticsoft.DAL.MemberInfo dal=new Maticsoft.DAL.MemberInfo();
		public MemberInfo()
		{}
		#region  Method
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.MemberInfo GetpassModel(string MemberName)
        {

            return dal.GetpassModel(MemberName);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool GetExists(string MemberName)
        {
            return dal.GetExists(MemberName);
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
		public bool Exists(int MemberID)
		{
			return dal.Exists(MemberID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.MemberInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.MemberInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MemberID)
		{
			
			return dal.Delete(MemberID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string MemberIDlist )
		{
			return dal.DeleteList(MemberIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.MemberInfo GetModel(int MemberID)
		{
			
			return dal.GetModel(MemberID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.MemberInfo GetModelByCache(int MemberID)
		{
			
			string CacheKey = "MemberInfoModel-" + MemberID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MemberID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.MemberInfo)objModel;
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
		public List<Maticsoft.Model.MemberInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.MemberInfo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.MemberInfo> modelList = new List<Maticsoft.Model.MemberInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.MemberInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.MemberInfo();
					if(dt.Rows[n]["MemberID"].ToString()!="")
					{
						model.MemberID=int.Parse(dt.Rows[n]["MemberID"].ToString());
					}
					model.MemberName=dt.Rows[n]["MemberName"].ToString();
					model.Password=dt.Rows[n]["Password"].ToString();
					if(dt.Rows[n]["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dt.Rows[n]["Sex"].ToString());
					}
					model.Linkphoto=dt.Rows[n]["Linkphoto"].ToString();
					model.Email=dt.Rows[n]["Email"].ToString();
					model.QQMSN=dt.Rows[n]["QQMSN"].ToString();
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

