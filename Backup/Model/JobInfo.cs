using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// JobInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JobInfo
	{
		public JobInfo()
		{}
		#region Model
		private int _jobid;
		private string _jobtitle;
		private string _address;
		private string _nunber;
		private DateTime? _starttime;
		private string _duxiang;
		private string _age;
		private string _xueli;
		private string _monery;
		private string _zhuanye;
		private DateTime? _endtime;
		private string _miaoshu;
		private string _lianxi;
		/// <summary>
		/// 
		/// </summary>
		public int JobID
		{
			set{ _jobid=value;}
			get{return _jobid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobTitle
		{
			set{ _jobtitle=value;}
			get{return _jobtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nunber
		{
			set{ _nunber=value;}
			get{return _nunber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Starttime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Duxiang
		{
			set{ _duxiang=value;}
			get{return _duxiang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Age
		{
			set{ _age=value;}
			get{return _age;}
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
		public string Monery
		{
			set{ _monery=value;}
			get{return _monery;}
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
		public DateTime? Endtime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Miaoshu
		{
			set{ _miaoshu=value;}
			get{return _miaoshu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Lianxi
		{
			set{ _lianxi=value;}
			get{return _lianxi;}
		}
		#endregion Model

	}
}

