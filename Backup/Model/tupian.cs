using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tupian:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tupian
	{
		public tupian()
		{}
		#region Model
		private int _id;
		private string _imageurl1;
		private string _imageurl2;
		private string _imageurl3;
		private string _imageurl4;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageURL1
		{
			set{ _imageurl1=value;}
			get{return _imageurl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageURL2
		{
			set{ _imageurl2=value;}
			get{return _imageurl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageURL3
		{
			set{ _imageurl3=value;}
			get{return _imageurl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageURL4
		{
			set{ _imageurl4=value;}
			get{return _imageurl4;}
		}
		#endregion Model

	}
}

