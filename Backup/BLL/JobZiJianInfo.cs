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
        /// ����������ѯ��ҳ�Լ���Ϣ(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="PageIndex">��ǰҳ��һ�������������ݵ�����</param>
        /// <param name="PageSize">ÿҳ�Ĵ�С</param>
        /// <param name="strwhere">��ѯ����</param>
        /// <returns>��ǰҳ���ݵļ���</returns>
        public DataSet GetzijianList(int PageIndex, int PageSize, string strwhere)
        {
            return dal.GetzijianList(PageIndex, PageSize, strwhere);
        }

        /// <summary>
        /// �����Լ�������ѯ�̻�����(��ѯView_NicheTrade)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetzijianCount(string strwhere)
        {
            return dal.GetzijianCount(strwhere);
        }



		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int JobInfoID)
		{
			return dal.Exists(JobInfoID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Maticsoft.Model.JobZiJianInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.JobZiJianInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int JobInfoID)
		{
			
			return dal.Delete(JobInfoID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string JobInfoIDlist )
		{
			return dal.DeleteList(JobInfoIDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.JobZiJianInfo GetModel(int JobInfoID)
		{
			
			return dal.GetModel(JobInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.JobZiJianInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

