using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NicheTypeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NicheTypeInfo
	{
		public NicheTypeInfo()
		{}
		#region Model
		private int _nichetypeid;
		private string _nichetypetitle;
		/// <summary>
		/// 
		/// </summary>
		public int NicheTypeID
		{
			set{ _nichetypeid=value;}
			get{return _nichetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NicheTypeTitle
		{
			set{ _nichetypetitle=value;}
			get{return _nichetypetitle;}
		}
		#endregion Model

	}
}

