using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NicheInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NicheInfo
	{
		public NicheInfo()
		{}
		#region Model
		private int _nicheid;
		private string _nichetitle;
		private string _nichekey;
		private DateTime? _fatime;
		private string _write;
		private string _imageurl;
		private int? _nichetypeid;
		private int? _hitnum;
		private string _nichecontent;
		/// <summary>
		/// 
		/// </summary>
		public int NicheID
		{
			set{ _nicheid=value;}
			get{return _nicheid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NicheTitle
		{
			set{ _nichetitle=value;}
			get{return _nichetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NicheKey
		{
			set{ _nichekey=value;}
			get{return _nichekey;}
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
		public int? NicheTypeID
		{
			set{ _nichetypeid=value;}
			get{return _nichetypeid;}
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
		public string NicheContent
		{
			set{ _nichecontent=value;}
			get{return _nichecontent;}
		}
		#endregion Model

	}
}

