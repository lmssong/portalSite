using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ComPanyInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ComPanyInfo
	{
		public ComPanyInfo()
		{}
		#region Model
		private int _xianshiid;
		private string _gonggao;
		private DateTime? _gongtime;
		private string _imageurl;
		private int? _fenleiid;
		/// <summary>
		/// 
		/// </summary>
		public int XianshiID
		{
			set{ _xianshiid=value;}
			get{return _xianshiid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gonggao
		{
			set{ _gonggao=value;}
			get{return _gonggao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GongTime
		{
			set{ _gongtime=value;}
			get{return _gongtime;}
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
		public int? FenleiID
		{
			set{ _fenleiid=value;}
			get{return _fenleiid;}
		}
		#endregion Model

	}
}

