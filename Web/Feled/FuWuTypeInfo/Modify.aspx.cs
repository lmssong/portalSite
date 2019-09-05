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
namespace Maticsoft.Web.FuWuTypeInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FuwuTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FuwuTypeID);
				}
			}
		}
			
	private void ShowInfo(int FuwuTypeID)
	{
		Maticsoft.BLL.FuWuTypeInfo bll=new Maticsoft.BLL.FuWuTypeInfo();
		Maticsoft.Model.FuWuTypeInfo model=bll.GetModel(FuwuTypeID);
		this.lblFuwuTypeID.Text=model.FuwuTypeID.ToString();
		this.txtFuwuTypeName.Text=model.FuwuTypeName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFuwuTypeName.Text.Trim().Length==0)
			{
				strErr+="FuwuTypeName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FuwuTypeID=int.Parse(this.lblFuwuTypeID.Text);
			string FuwuTypeName=this.txtFuwuTypeName.Text;


			Maticsoft.Model.FuWuTypeInfo model=new Maticsoft.Model.FuWuTypeInfo();
			model.FuwuTypeID=FuwuTypeID;
			model.FuwuTypeName=FuwuTypeName;

			Maticsoft.BLL.FuWuTypeInfo bll=new Maticsoft.BLL.FuWuTypeInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
