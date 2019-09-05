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
namespace Maticsoft.Web.FuWuInfo
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
					int fuwuID=(Convert.ToInt32(strid));
					ShowInfo(fuwuID);
				}
			}
		}
		
	private void ShowInfo(int fuwuID)
	{
		Maticsoft.BLL.FuWuInfo bll=new Maticsoft.BLL.FuWuInfo();
		Maticsoft.Model.FuWuInfo model=bll.GetModel(fuwuID);
		this.lblfuwuID.Text=model.fuwuID.ToString();
		this.lblfuwuTitle.Text=model.fuwuTitle;
		this.lblFatime.Text=model.Fatime.ToString();
		this.lblFuwuTypeID.Text=model.FuwuTypeID.ToString();
		this.lblWrite.Text=model.Write;
		this.lblFuwucontent.Text=model.Fuwucontent;

	}


    }
}
