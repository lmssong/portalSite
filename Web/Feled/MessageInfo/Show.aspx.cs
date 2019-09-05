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
namespace Maticsoft.Web.MessageInfo
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
					int MessID=(Convert.ToInt32(strid));
					ShowInfo(MessID);
				}
			}
		}
		
	private void ShowInfo(int MessID)
	{
		Maticsoft.BLL.MessageInfo bll=new Maticsoft.BLL.MessageInfo();
		Maticsoft.Model.MessageInfo model=bll.GetModel(MessID);
		this.lblMessID.Text=model.MessID.ToString();
		this.lblMessTitle.Text=model.MessTitle;
		this.lblUsername.Text=model.Username;
		this.lblSex.Text=model.Sex?"ÊÇ":"·ñ";
		this.lblAddress.Text=model.Address;
		this.lblLinkphoto.Text=model.Linkphoto;
		this.lblEmail.Text=model.Email;
		this.lblMesscontent.Text=model.Messcontent;

	}


    }
}
