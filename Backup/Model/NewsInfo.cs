using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NewsInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewsInfo
	{
		public NewsInfo()
		{}
		#region Model
		private int _newsid;
		private string _newstitle;
		private string _newskey;
		private string _write;
		private int? _newstypeid;
		private DateTime? _fatime;
		private string _imageurl;
		private int? _hitnum;
		private string _newscontent;
		/// <summary>
		/// 
		/// </summary>
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsTitle
		{
			set{ _newstitle=value;}
			get{return _newstitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsKey
		{
			set{ _newskey=value;}
			get{return _newskey;}
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
		public int? NewsTypeID
		{
			set{ _newstypeid=value;}
			get{return _newstypeid;}
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
		public int? HitNum
		{
			set{ _hitnum=value;}
			get{return _hitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsContent
		{
			set{ _newscontent=value;}
			get{return _newscontent;}
		}
		#endregion Model

	}
}

