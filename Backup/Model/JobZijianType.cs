using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// JobZijianType:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class JobZijianType
	{
		public JobZijianType()
		{}
		#region Model
		private int _jobtitleid;
		private string _jobtitlename;
		/// <summary>
		/// 
		/// </summary>
		public int JobTitleID
		{
			set{ _jobtitleid=value;}
			get{return _jobtitleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobTitleName
		{
			set{ _jobtitlename=value;}
			get{return _jobtitlename;}
		}
		#endregion Model

	}
}

