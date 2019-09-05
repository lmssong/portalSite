using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ComPany:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ComPany
	{
		public ComPany()
		{}
		#region Model
		private int _companyid;
		private string _companynames;
		private string _companytype;
		private string _fanren;
		private string _comaddress;
		private string _comfax;
		private string _comphoto;
		private string _comemail;
		private string _qq;
		private string _comwangzhi;
		private string _comconten;
		/// <summary>
		/// 
		/// </summary>
		public int CompanyID
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyNames
		{
			set{ _companynames=value;}
			get{return _companynames;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyType
		{
			set{ _companytype=value;}
			get{return _companytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Fanren
		{
			set{ _fanren=value;}
			get{return _fanren;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComAddress
		{
			set{ _comaddress=value;}
			get{return _comaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComFax
		{
			set{ _comfax=value;}
			get{return _comfax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComPhoto
		{
			set{ _comphoto=value;}
			get{return _comphoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComEmail
		{
			set{ _comemail=value;}
			get{return _comemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comwangzhi
		{
			set{ _comwangzhi=value;}
			get{return _comwangzhi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string comconten
		{
			set{ _comconten=value;}
			get{return _comconten;}
		}
		#endregion Model

	}
}

