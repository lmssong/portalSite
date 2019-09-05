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
namespace Maticsoft.Web.FuWuTypeInfo
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
					int FuwuTypeID=(Convert.ToInt32(strid));
					ShowInfo(FuwuTypeID);
				}
			}
		}
		
	private void ShowInfo(int FuwuTypeID)
	{
		Maticsoft.BLL.FuWuTypeInfo bll=new Maticsoft.BLL.FuWuTypeInfo();
		Maticsoft.Model.FuWuTypeInfo model=bll.GetModel(FuwuTypeID);
		this.lblFuwuTypeID.Text=model.FuwuTypeID.ToString();
		this.lblFuwuTypeName.Text=model.FuwuTypeName;

	}


    }
}
