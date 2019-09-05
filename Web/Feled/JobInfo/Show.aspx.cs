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
namespace Maticsoft.Web.JobInfo
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
					int JobID=(Convert.ToInt32(strid));
					ShowInfo(JobID);
				}
			}
		}
		
	private void ShowInfo(int JobID)
	{
		Maticsoft.BLL.JobInfo bll=new Maticsoft.BLL.JobInfo();
		Maticsoft.Model.JobInfo model=bll.GetModel(JobID);
		this.lblJobID.Text=model.JobID.ToString();
		this.lblJobTitle.Text=model.JobTitle;
		this.lblAddress.Text=model.Address;
		this.lblNunber.Text=model.Nunber;
		this.lblStarttime.Text=model.Starttime.ToString();
		this.lblDuxiang.Text=model.Duxiang;
		this.lblAge.Text=model.Age;
		this.lblXueli.Text=model.Xueli;
		this.lblMonery.Text=model.Monery;
		this.lblZhuanye.Text=model.Zhuanye;
		this.lblEndtime.Text=model.Endtime.ToString();
		this.lblMiaoshu.Text=model.Miaoshu;
		this.lblLianxi.Text=model.Lianxi;

	}


    }
}
