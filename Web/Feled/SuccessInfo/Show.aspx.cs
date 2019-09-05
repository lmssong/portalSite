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
namespace Maticsoft.Web.SuccessInfo
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
					int SuccessID=(Convert.ToInt32(strid));
					ShowInfo(SuccessID);
				}
			}
		}
		
	private void ShowInfo(int SuccessID)
	{
		Maticsoft.BLL.SuccessInfo bll=new Maticsoft.BLL.SuccessInfo();
		Maticsoft.Model.SuccessInfo model=bll.GetModel(SuccessID);
		this.lblSuccessID.Text=model.SuccessID.ToString();
		this.lblSuccessTitle.Text=model.SuccessTitle;
		this.lblFatime.Text=model.Fatime.ToString();
		this.lblWrite.Text=model.Write;
		this.lblImageURL.Text=model.ImageURL;
		this.lblHitNum.Text=model.HitNum.ToString();
		this.lblSuccessContent.Text=model.SuccessContent;

	}


    }
}
