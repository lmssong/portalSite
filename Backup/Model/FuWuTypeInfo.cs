using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// FuWuTypeInfo:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

