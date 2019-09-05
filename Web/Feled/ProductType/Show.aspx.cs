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
namespace Maticsoft.Web.ProductType
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
					int ProTypeID=(Convert.ToInt32(strid));
					ShowInfo(ProTypeID);
				}
			}
		}
		
	private void ShowInfo(int ProTypeID)
	{
		Maticsoft.BLL.ProductType bll=new Maticsoft.BLL.ProductType();
		Maticsoft.Model.ProductType model=bll.GetModel(ProTypeID);
		this.lblProTypeID.Text=model.ProTypeID.ToString();
		this.lblProTypeTitle.Text=model.ProTypeTitle;

	}


    }
}
