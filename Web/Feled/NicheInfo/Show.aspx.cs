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
namespace Maticsoft.Web.NicheInfo
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
					int NicheID=(Convert.ToInt32(strid));
					ShowInfo(NicheID);
				}
			}
		}
		
	private void ShowInfo(int NicheID)
	{
		Maticsoft.BLL.NicheInfo bll=new Maticsoft.BLL.NicheInfo();
		Maticsoft.Model.NicheInfo model=bll.GetModel(NicheID);
		this.lblNicheID.Text=model.NicheID.ToString();
		this.lblNicheTitle.Text=model.NicheTitle;
		this.lblNicheKey.Text=model.NicheKey;
		this.lblFatime.Text=model.Fatime.ToString();
		this.lblWrite.Text=model.Write;
		this.lblImageURL.Text=model.ImageURL;
		this.lblNicheTypeID.Text=model.NicheTypeID.ToString();
		this.lblHitNum.Text=model.HitNum.ToString();
		this.lblNicheContent.Text=model.NicheContent;

	}


    }
}
