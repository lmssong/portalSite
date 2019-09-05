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
namespace Maticsoft.Web.ComPany
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
					int CompanyID=(Convert.ToInt32(strid));
					ShowInfo(CompanyID);
				}
			}
		}
		
	private void ShowInfo(int CompanyID)
	{
		Maticsoft.BLL.ComPany bll=new Maticsoft.BLL.ComPany();
		Maticsoft.Model.ComPany model=bll.GetModel(CompanyID);
		this.lblCompanyID.Text=model.CompanyID.ToString();
		this.lblCompanyNames.Text=model.CompanyNames;
		this.lblCompanyType.Text=model.CompanyType;
		this.lblComAddress.Text=model.ComAddress;
		this.lblComFax.Text=model.ComFax;
		this.lblComPhoto.Text=model.ComPhoto;
		this.lblComEmail.Text=model.ComEmail;
		this.lblQQ.Text=model.QQ;
		this.lblComwangzhi.Text=model.Comwangzhi;

	}


    }
}
