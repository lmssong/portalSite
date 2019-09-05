using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// ComPany
	/// </summary>
	public partial class ComPany
	{
		private readonly Maticsoft.DAL.ComPany dal=new Maticsoft.DAL.ComPany();
		public ComPany()
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
		public bool Exists(int CompanyID)
		{
			return dal.Exists(CompanyID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.ComPany model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.ComPany model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CompanyID)
		{
			
			return dal.Delete(CompanyID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CompanyIDlist )
		{
			return dal.DeleteList(CompanyIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.ComPany GetModel(int CompanyID)
		{
			
			return dal.GetModel(CompanyID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.ComPany GetModelByCache(int CompanyID)
		{
			
			string CacheKey = "ComPanyModel-" + CompanyID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CompanyID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.ComPany)objModel;
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
		public List<Maticsoft.Model.ComPany> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.ComPany> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.ComPany> modelList = new List<Maticsoft.Model.ComPany>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.ComPany model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.ComPany();
					if(dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					model.CompanyNames=dt.Rows[n]["CompanyNames"].ToString();
					model.CompanyType=dt.Rows[n]["CompanyType"].ToString();
					model.Fanren=dt.Rows[n]["Fanren"].ToString();
					model.ComAddress=dt.Rows[n]["ComAddress"].ToString();
					model.ComFax=dt.Rows[n]["ComFax"].ToString();
					model.ComPhoto=dt.Rows[n]["ComPhoto"].ToString();
					model.ComEmail=dt.Rows[n]["ComEmail"].ToString();
					model.QQ=dt.Rows[n]["QQ"].ToString();
					model.Comwangzhi=dt.Rows[n]["Comwangzhi"].ToString();
					model.comconten=dt.Rows[n]["comconten"].ToString();
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

