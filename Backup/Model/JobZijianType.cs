using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// JobZijianType:实体类(属性说明自动提取数据库字段的描述信息)
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

