using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// FuWuInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FuWuInfo
	{
		public FuWuInfo()
		{}
		#region Model
		private int _fuwuid;
		private string _fuwutitle;
		private DateTime? _fatime;
		private string _imageurl;
		private int? _fuwutypeid;
		private string _write;
		private string _fuwucontent;
		/// <summary>
		/// 
		/// </summary>
		public int fuwuID
		{
			set{ _fuwuid=value;}
			get{return _fuwuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fuwuTitle
		{
			set{ _fuwutitle=value;}
			get{return _fuwutitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Fatime
		{
			set{ _fatime=value;}
			get{return _fatime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageURL
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FuwuTypeID
		{
			set{ _fuwutypeid=value;}
			get{return _fuwutypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Write
		{
			set{ _write=value;}
			get{return _write;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Fuwucontent
		{
			set{ _fuwucontent=value;}
			get{return _fuwucontent;}
		}
		#endregion Model

	}
}

