using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ZiXunInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZiXunInfo
	{
		public ZiXunInfo()
		{}
		#region Model
		private int _zixunid;
		private string _zixuntitle;
		private DateTime? _zixuntime;
		private string _zixuncontent;
		private string _zixunusername;
		private string _zixunuserphoto;
		private string _zixundaan;
		/// <summary>
		/// 
		/// </summary>
		public int zixunID
		{
			set{ _zixunid=value;}
			get{return _zixunid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zixunTitle
		{
			set{ _zixuntitle=value;}
			get{return _zixuntitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? zixuntime
		{
			set{ _zixuntime=value;}
			get{return _zixuntime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zixuncontent
		{
			set{ _zixuncontent=value;}
			get{return _zixuncontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zixunUserName
		{
			set{ _zixunusername=value;}
			get{return _zixunusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zixunuserPhoto
		{
			set{ _zixunuserphoto=value;}
			get{return _zixunuserphoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZiXundaan
		{
			set{ _zixundaan=value;}
			get{return _zixundaan;}
		}
		#endregion Model

	}
}

