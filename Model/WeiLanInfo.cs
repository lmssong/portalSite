using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// WeiLanInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WeiLanInfo
	{
		public WeiLanInfo()
		{}
		#region Model
		private int _weiid;
		private string _weititle;
		private string _weikey;
		private DateTime? _fatime;
		private string _write;
		private int? _hitnum;
		private string _weicontent;
		/// <summary>
		/// 
		/// </summary>
		public int WeiID
		{
			set{ _weiid=value;}
			get{return _weiid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeiTitle
		{
			set{ _weititle=value;}
			get{return _weititle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeiKey
		{
			set{ _weikey=value;}
			get{return _weikey;}
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
		public int? HitNum
		{
			set{ _hitnum=value;}
			get{return _hitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Weicontent
		{
			set{ _weicontent=value;}
			get{return _weicontent;}
		}
		#endregion Model

	}
}

