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
namespace Maticsoft.Web.ProductXing
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ProXingID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ProXingID);
				}
			}
		}
			
	private void ShowInfo(int ProXingID)
	{
		Maticsoft.BLL.ProductXing bll=new Maticsoft.BLL.ProductXing();
		Maticsoft.Model.ProductXing model=bll.GetModel(ProXingID);
		this.lblProXingID.Text=model.ProXingID.ToString();
		this.txtProTypeID.Text=model.ProTypeID.ToString();
		this.txtProXingTitle.Text=model.ProXingTitle;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtProTypeID.Text))
			{
				strErr+="ProTypeID格式错误！\\n";	
			}
			if(this.txtProXingTitle.Text.Trim().Length==0)
			{
				strErr+="ProXingTitle不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ProXingID=int.Parse(this.lblProXingID.Text);
			int ProTypeID=int.Parse(this.txtProTypeID.Text);
			string ProXingTitle=this.txtProXingTitle.Text;


			Maticsoft.Model.ProductXing model=new Maticsoft.Model.ProductXing();
			model.ProXingID=ProXingID;
			model.ProTypeID=ProTypeID;
			model.ProXingTitle=ProXingTitle;

			Maticsoft.BLL.ProductXing bll=new Maticsoft.BLL.ProductXing();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
