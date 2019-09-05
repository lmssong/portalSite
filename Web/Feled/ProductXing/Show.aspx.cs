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
namespace Maticsoft.Web.ProductXing
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
					int ProXingID=(Convert.ToInt32(strid));
					ShowInfo(ProXingID);
				}
			}
		}
		
	private void ShowInfo(int ProXingID)
	{
		Maticsoft.BLL.ProductXing bll=new Maticsoft.BLL.ProductXing();
		Maticsoft.Model.ProductXing model=bll.GetModel(ProXingID);
		this.lblProXingID.Text=model.ProXingID.ToString();
		this.lblProTypeID.Text=model.ProTypeID.ToString();
		this.lblProXingTitle.Text=model.ProXingTitle;

	}


    }
}
