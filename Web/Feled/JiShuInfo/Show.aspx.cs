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
namespace Maticsoft.Web.JiShuInfo
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
					int JishuID=(Convert.ToInt32(strid));
					ShowInfo(JishuID);
				}
			}
		}
		
	private void ShowInfo(int JishuID)
	{
		Maticsoft.BLL.JiShuInfo bll=new Maticsoft.BLL.JiShuInfo();
		Maticsoft.Model.JiShuInfo model=bll.GetModel(JishuID);
		this.lblJishuID.Text=model.JishuID.ToString();
		this.lblJishuTitle.Text=model.JishuTitle;
		this.lblJishuNum.Text=model.JishuNum;
		this.lblFatime.Text=model.Fatime.ToString();
		this.lbljishuType.Text=model.jishuType;
		this.lblImageURL.Text=model.ImageURL;
		this.lblJishuPath.Text=model.JishuPath;

	}


    }
}
