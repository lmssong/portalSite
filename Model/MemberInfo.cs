using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// MemberInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemberInfo
	{
		public MemberInfo()
		{}
		#region Model
		private int _memberid;
		private string _membername;
		private string _password;
		private int? _sex;
		private string _linkphoto;
		private string _email;
		private string _qqmsn;
		/// <summary>
		/// 
		/// </summary>
		public int MemberID
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberName
		{
			set{ _membername=value;}
			get{return _membername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
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
		public string Linkphoto
		{
			set{ _linkphoto=value;}
			get{return _linkphoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQMSN
		{
			set{ _qqmsn=value;}
			get{return _qqmsn;}
		}
		#endregion Model

	}
}

