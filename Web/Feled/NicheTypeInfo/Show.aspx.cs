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
namespace Maticsoft.Web.NicheTypeInfo
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
					int NicheTypeID=(Convert.ToInt32(strid));
					ShowInfo(NicheTypeID);
				}
			}
		}
		
	private void ShowInfo(int NicheTypeID)
	{
		Maticsoft.BLL.NicheTypeInfo bll=new Maticsoft.BLL.NicheTypeInfo();
		Maticsoft.Model.NicheTypeInfo model=bll.GetModel(NicheTypeID);
		this.lblNicheTypeID.Text=model.NicheTypeID.ToString();
		this.lblNicheTypeTitle.Text=model.NicheTypeTitle;

	}


    }
}
