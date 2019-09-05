using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.JobZiJianInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int JobInfoID=(Convert.ToInt32(strid));
					ShowInfo(JobInfoID);
				}
			}
		}
		
	private void ShowInfo(int JobInfoID)
	{
		Maticsoft.BLL.JobZiJianInfo bll=new Maticsoft.BLL.JobZiJianInfo();
		Maticsoft.Model.JobZiJianInfo model=bll.GetModel(JobInfoID);
		this.lblJobInfoID.Text=model.JobInfoID.ToString();
		this.lblUsersname.Text=model.Usersname;
		this.lblJobID.Text=model.JobID.ToString();
		this.lblSex.Text=model.Sex?"ÊÇ":"·ñ";
		this.lblXueli.Text=model.Xueli;
		this.lblJiguan.Text=model.Jiguan;
		this.lblBritday.Text=model.Britday.ToString();
		this.lblZhuanye.Text=model.Zhuanye;
		this.lblJiaoyu.Text=model.Jiaoyu;
		this.lblJingyan.Text=model.Jingyan;
		this.lblPingjia.Text=model.Pingjia;

	}


    }
}
