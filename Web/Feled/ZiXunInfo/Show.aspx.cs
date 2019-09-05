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
namespace Maticsoft.Web.ZiXunInfo
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
					int zixunID=(Convert.ToInt32(strid));
					ShowInfo(zixunID);
				}
			}
		}
		
	private void ShowInfo(int zixunID)
	{
		Maticsoft.BLL.ZiXunInfo bll=new Maticsoft.BLL.ZiXunInfo();
		Maticsoft.Model.ZiXunInfo model=bll.GetModel(zixunID);
		this.lblzixunID.Text=model.zixunID.ToString();
		this.lblzixunTitle.Text=model.zixunTitle;
		this.lblzixuntime.Text=model.zixuntime.ToString();
		this.lblzixuncontent.Text=model.zixuncontent;
		this.lblzixunUserName.Text=model.zixunUserName;
		this.lblzixunuserPhoto.Text=model.zixunuserPhoto;

	}


    }
}
