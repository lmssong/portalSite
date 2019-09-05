using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// SuccessInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SuccessInfo
	{
		public SuccessInfo()
		{}
		#region Model
		private int _successid;
		private string _successtitle;
		private DateTime? _fatime;
		private string _write;
		private string _imageurl;
		private int? _hitnum;
		private string _successcontent;
		/// <summary>
		/// 
		/// </summary>
		public int SuccessID
		{
			set{ _successid=value;}
			get{return _successid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuccessTitle
		{
			set{ _successtitle=value;}
			get{return _successtitle;}
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
		public string Write
		{
			set{ _write=value;}
			get{return _write;}
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
		public int? HitNum
		{
			set{ _hitnum=value;}
			get{return _hitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuccessContent
		{
			set{ _successcontent=value;}
			get{return _successcontent;}
		}
		#endregion Model

	}
}

