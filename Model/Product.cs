using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Product
	{
		public Product()
		{}
		#region Model
		private int _proid;
		private string _proname;
		private int? _protypeid;
		private string _imageurl;
		private int? _proxingid;
		private DateTime? _prochutime;
		private DateTime? _fatime;
		private int? _toujian;
		private int? _hitnum;
		private string _procontent;
		private string _promonery;
		/// <summary>
		/// 
		/// </summary>
		public int ProID
		{
			set{ _proid=value;}
			get{return _proid;}
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
		public int? ProTypeID
		{
			set{ _protypeid=value;}
			get{return _protypeid;}
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
		public int? ProXingID
		{
			set{ _proxingid=value;}
			get{return _proxingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Prochutime
		{
			set{ _prochutime=value;}
			get{return _prochutime;}
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
		public int? Toujian
		{
			set{ _toujian=value;}
			get{return _toujian;}
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
		public string Procontent
		{
			set{ _procontent=value;}
			get{return _procontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProMonery
		{
			set{ _promonery=value;}
			get{return _promonery;}
		}
		#endregion Model

	}
}

