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
namespace Maticsoft.Web.WeiLanInfo
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
					int WeiID=(Convert.ToInt32(strid));
					ShowInfo(WeiID);
				}
			}
		}
		
	private void ShowInfo(int WeiID)
	{
		Maticsoft.BLL.WeiLanInfo bll=new Maticsoft.BLL.WeiLanInfo();
		Maticsoft.Model.WeiLanInfo model=bll.GetModel(WeiID);
		this.lblWeiID.Text=model.WeiID.ToString();
		this.lblWeiTitle.Text=model.WeiTitle;
		this.lblWeiKey.Text=model.WeiKey;
		this.lblFatime.Text=model.Fatime.ToString();
		this.lblWrite.Text=model.Write;
		this.lblHitNum.Text=model.HitNum.ToString();
		this.lblWeicontent.Text=model.Weicontent;

	}


    }
}
