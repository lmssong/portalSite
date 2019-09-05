using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NewsTypeInfo:实体类(属性说明自动提取数据库字段的描述信息)
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

