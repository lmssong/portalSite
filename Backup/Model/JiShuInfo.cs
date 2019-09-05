using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// JiShuInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JiShuInfo
	{
		public JiShuInfo()
		{}
		#region Model
		private int _jishuid;
		private string _jishutitle;
		private string _jishunum;
		private DateTime? _fatime;
		private string _jishutype;
		private string _imageurl;
		private string _jishupath;
		private string _jishucontent;
		/// <summary>
		/// 
		/// </summary>
		public int JishuID
		{
			set{ _jishuid=value;}
			get{return _jishuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JishuTitle
		{
			set{ _jishutitle=value;}
			get{return _jishutitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JishuNum
		{
			set{ _jishunum=value;}
			get{return _jishunum;}
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
		public string jishuType
		{
			set{ _jishutype=value;}
			get{return _jishutype;}
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
		public string JishuPath
		{
			set{ _jishupath=value;}
			get{return _jishupath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Jishucontent
		{
			set{ _jishucontent=value;}
			get{return _jishucontent;}
		}
		#endregion Model

	}
}

