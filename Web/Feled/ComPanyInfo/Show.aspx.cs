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
namespace Maticsoft.Web.ComPanyInfo
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
					int XianshiID=(Convert.ToInt32(strid));
					ShowInfo(XianshiID);
				}
			}
		}
		
	private void ShowInfo(int XianshiID)
	{
		Maticsoft.BLL.ComPanyInfo bll=new Maticsoft.BLL.ComPanyInfo();
		Maticsoft.Model.ComPanyInfo model=bll.GetModel(XianshiID);
		this.lblXianshiID.Text=model.XianshiID.ToString();
		this.lblGonggao.Text=model.Gonggao;
		this.lblGongTime.Text=model.GongTime.ToString();
		this.lblImageURL.Text=model.ImageURL;
		this.lblFenleiID.Text=model.FenleiID.ToString();

	}


    }
}
