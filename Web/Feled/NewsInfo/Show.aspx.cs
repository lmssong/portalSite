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
namespace Maticsoft.Web.NewsInfo
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
					int NewsID=(Convert.ToInt32(strid));
					ShowInfo(NewsID);
				}
			}
		}
		
	private void ShowInfo(int NewsID)
	{
		Maticsoft.BLL.NewsInfo bll=new Maticsoft.BLL.NewsInfo();
		Maticsoft.Model.NewsInfo model=bll.GetModel(NewsID);
		this.lblNewsID.Text=model.NewsID.ToString();
		this.lblNewsTitle.Text=model.NewsTitle;
		this.lblNewsKey.Text=model.NewsKey;
		this.lblWrite.Text=model.Write;
		this.lblNewsTypeID.Text=model.NewsTypeID.ToString();
		this.lblFatime.Text=model.Fatime.ToString();
		this.lblImageURL.Text=model.ImageURL;
		this.lblHitNum.Text=model.HitNum.ToString();
		this.lblNewsContent.Text=model.NewsContent;

	}


    }
}
