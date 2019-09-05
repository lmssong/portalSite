using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// DingProduct:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DingProduct
	{
		public DingProduct()
		{}
		#region Model
		private int _dingid;
		private string _proname;
		private int? _proxingid;
		private int? _protypeid;
		private string _dingnum;
		private string _dingaddress;
		private string _linkphoto;
		private string _dingemail;
		private int? _dingsex;
		private string _usersname;
		private DateTime? _dingtime;
		private string _dingcontent;
		/// <summary>
		/// 
		/// </summary>
		public int DingID
		{
			set{ _dingid=value;}
			get{return _dingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProName
		{
			set{ _proname=value;}
			get{return _proname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProXingID
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
		public string DingNum
		{
			set{ _dingnum=value;}
			get{return _dingnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DingAddress
		{
			set{ _dingaddress=value;}
			get{return _dingaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkPhoto
		{
			set{ _linkphoto=value;}
			get{return _linkphoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DingEmail
		{
			set{ _dingemail=value;}
			get{return _dingemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DingSex
		{
			set{ _dingsex=value;}
			get{return _dingsex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsersName
		{
			set{ _usersname=value;}
			get{return _usersname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Dingtime
		{
			set{ _dingtime=value;}
			get{return _dingtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Dingcontent
		{
			set{ _dingcontent=value;}
			get{return _dingcontent;}
		}
		#endregion Model

	}
}

