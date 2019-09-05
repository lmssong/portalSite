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
namespace Maticsoft.Web.NewsTypeInfo
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
					int NewsTypeID=(Convert.ToInt32(strid));
					ShowInfo(NewsTypeID);
				}
			}
		}
		
	private void ShowInfo(int NewsTypeID)
	{
		Maticsoft.BLL.NewsTypeInfo bll=new Maticsoft.BLL.NewsTypeInfo();
		Maticsoft.Model.NewsTypeInfo model=bll.GetModel(NewsTypeID);
		this.lblNewsTypeID.Text=model.NewsTypeID.ToString();
		this.lblNewsTypeTitle.Text=model.NewsTypeTitle;

	}


    }
}
