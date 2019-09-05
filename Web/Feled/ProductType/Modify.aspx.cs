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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.ProductType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ProTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ProTypeID);
				}
			}
		}
			
	private void ShowInfo(int ProTypeID)
	{
		Maticsoft.BLL.ProductType bll=new Maticsoft.BLL.ProductType();
		Maticsoft.Model.ProductType model=bll.GetModel(ProTypeID);
		this.lblProTypeID.Text=model.ProTypeID.ToString();
		this.txtProTypeTitle.Text=model.ProTypeTitle;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProTypeTitle.Text.Trim().Length==0)
			{
				strErr+="ProTypeTitle不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ProTypeID=int.Parse(this.lblProTypeID.Text);
			string ProTypeTitle=this.txtProTypeTitle.Text;


			Maticsoft.Model.ProductType model=new Maticsoft.Model.ProductType();
			model.ProTypeID=ProTypeID;
			model.ProTypeTitle=ProTypeTitle;

			Maticsoft.BLL.ProductType bll=new Maticsoft.BLL.ProductType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
