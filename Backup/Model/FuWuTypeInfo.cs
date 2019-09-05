using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// FuWuTypeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FuWuTypeInfo
	{
		public FuWuTypeInfo()
		{}
		#region Model
		private int _fuwutypeid;
		private string _fuwutypename;
		/// <summary>
		/// 
		/// </summary>
		public int FuwuTypeID
		{
			set{ _fuwutypeid=value;}
			get{return _fuwutypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FuwuTypeName
		{
			set{ _fuwutypename=value;}
			get{return _fuwutypename;}
		}
		#endregion Model

	}
}

