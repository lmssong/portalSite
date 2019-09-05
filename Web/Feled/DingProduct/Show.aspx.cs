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
namespace Maticsoft.Web.DingProduct
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
					int DingID=(Convert.ToInt32(strid));
					ShowInfo(DingID);
				}
			}
		}
		
	private void ShowInfo(int DingID)
	{
		Maticsoft.BLL.DingProduct bll=new Maticsoft.BLL.DingProduct();
		Maticsoft.Model.DingProduct model=bll.GetModel(DingID);
		this.lblDingID.Text=model.DingID.ToString();
		this.lblProName.Text=model.ProName;
		this.lblProXingID.Text=model.ProXingID.ToString();
		this.lblProTypeID.Text=model.ProTypeID.ToString();
		this.lblDingNum.Text=model.DingNum;
		this.lblDingAddress.Text=model.DingAddress;
		this.lblLinkPhoto.Text=model.LinkPhoto;
		this.lblDingEmail.Text=model.DingEmail;
		this.lblDingSex.Text=model.DingSex?"ÊÇ":"·ñ";
		this.lblUsersName.Text=model.UsersName;
		this.lblDingtime.Text=model.Dingtime.ToString();
		this.lblDingcontent.Text=model.Dingcontent;

	}


    }
}
