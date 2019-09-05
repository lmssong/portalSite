using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ProductXing:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProductXing
	{
		public ProductXing()
		{}
		#region Model
		private int _proxingid;
		private int? _protypeid;
		private string _proxingtitle;
		/// <summary>
		/// 
		/// </summary>
		public int ProXingID
		{
			set{ _proxingid=value;}
			get{return _proxingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProTypeID
		{
			set{ _protypeid=value;}
			get{return _protypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProXingTitle
		{
			set{ _proxingtitle=value;}
			get{return _proxingtitle;}
		}
		#endregion Model

	}
}

