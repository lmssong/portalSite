using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NicheTypeInfo:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

