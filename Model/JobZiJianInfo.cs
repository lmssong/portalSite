using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// JobZiJianInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JobZiJianInfo
	{
		public JobZiJianInfo()
		{}
		#region Model
		private int _jobinfoid;
		private string _usersname;
		private int? _sex;
		private string _xueli;
		private DateTime? _datatime;
		private string _monery;
		private string _jiguan;
		private DateTime? _britday;
		private string _zhuanye;
		private string _jiaoyu;
		private string _jingyan;
		private string _pingjia;
		private string _jobtitle;
		/// <summary>
		/// 
		/// </summary>
		public int JobInfoID
		{
			set{ _jobinfoid=value;}
			get{return _jobinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Usersname
		{
			set{ _usersname=value;}
			get{return _usersname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Xueli
		{
			set{ _xueli=value;}
			get{return _xueli;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? datatime
		{
			set{ _datatime=value;}
			get{return _datatime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Monery
		{
			set{ _monery=value;}
			get{return _monery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Jiguan
		{
			set{ _jiguan=value;}
			get{return _jiguan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Britday
		{
			set{ _britday=value;}
			get{return _britday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Zhuanye
		{
			set{ _zhuanye=value;}
			get{return _zhuanye;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Jiaoyu
		{
			set{ _jiaoyu=value;}
			get{return _jiaoyu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Jingyan
		{
			set{ _jingyan=value;}
			get{return _jingyan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pingjia
		{
			set{ _pingjia=value;}
			get{return _pingjia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Jobtitle
		{
			set{ _jobtitle=value;}
			get{return _jobtitle;}
		}
		#endregion Model

	}
}

