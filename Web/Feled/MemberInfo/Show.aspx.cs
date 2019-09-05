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
namespace Maticsoft.Web.MemberInfo
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
					int MemberID=(Convert.ToInt32(strid));
					ShowInfo(MemberID);
				}
			}
		}
		
	private void ShowInfo(int MemberID)
	{
		Maticsoft.BLL.MemberInfo bll=new Maticsoft.BLL.MemberInfo();
		Maticsoft.Model.MemberInfo model=bll.GetModel(MemberID);
		this.lblMemberID.Text=model.MemberID.ToString();
		this.lblMemberName.Text=model.MemberName;
		this.lblPassword.Text=model.Password;
		this.lblSex.Text=model.Sex?"ÊÇ":"·ñ";
		this.lblLinkphoto.Text=model.Linkphoto;
		this.lblEmail.Text=model.Email;
		this.lblQQMSN.Text=model.QQMSN;

	}


    }
}
