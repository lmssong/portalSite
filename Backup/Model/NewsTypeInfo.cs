using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NewsTypeInfo:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class NewsTypeInfo
	{
		public NewsTypeInfo()
		{}
		#region Model
		private int _newstypeid;
		private string _newstypetitle;
		/// <summary>
		/// 
		/// </summary>
		public int NewsTypeID
		{
			set{ _newstypeid=value;}
			get{return _newstypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsTypeTitle
		{
			set{ _newstypetitle=value;}
			get{return _newstypetitle;}
		}
		#endregion Model

	}
}

