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
namespace Maticsoft.Web.Product
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
					int ProID=(Convert.ToInt32(strid));
					ShowInfo(ProID);
				}
			}
		}
		
	private void ShowInfo(int ProID)
	{
		Maticsoft.BLL.Product bll=new Maticsoft.BLL.Product();
		Maticsoft.Model.Product model=bll.GetModel(ProID);
		this.lblProID.Text=model.ProID.ToString();
		this.lblProName.Text=model.ProName;
		this.lblProTypeID.Text=model.ProTypeID.ToString();
		this.lblProXingID.Text=model.ProXingID.ToString();
		this.lblProchutime.Text=model.Prochutime.ToString();
		this.lblFatime.Text=model.Fatime.ToString();
		this.lblToujian.Text=model.Toujian?"ÊÇ":"·ñ";
		this.lblHitNum.Text=model.HitNum.ToString();
		this.lblProcontent.Text=model.Procontent;

	}


    }
}
