using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// ProductType:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class ProductType
	{
		public ProductType()
		{}
		#region Model
		private int _protypeid;
		private string _protypetitle;
		/// <summary>
		/// 
		/// </summary>
		public int ProTypeID
		{
			set{ _protypeid=value;}
			get{return _protypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProTypeTitle
		{
			set{ _protypetitle=value;}
			get{return _protypetitle;}
		}
		#endregion Model

	}
}

