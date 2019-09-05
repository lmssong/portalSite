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
namespace Maticsoft.Web.NicheTypeInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NicheTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NicheTypeID);
				}
			}
		}
			
	private void ShowInfo(int NicheTypeID)
	{
		Maticsoft.BLL.NicheTypeInfo bll=new Maticsoft.BLL.NicheTypeInfo();
		Maticsoft.Model.NicheTypeInfo model=bll.GetModel(NicheTypeID);
		this.lblNicheTypeID.Text=model.NicheTypeID.ToString();
		this.txtNicheTypeTitle.Text=model.NicheTypeTitle;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNicheTypeTitle.Text.Trim().Length==0)
			{
				strErr+="NicheTypeTitle不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int NicheTypeID=int.Parse(this.lblNicheTypeID.Text);
			string NicheTypeTitle=this.txtNicheTypeTitle.Text;


			Maticsoft.Model.NicheTypeInfo model=new Maticsoft.Model.NicheTypeInfo();
			model.NicheTypeID=NicheTypeID;
			model.NicheTypeTitle=NicheTypeTitle;

			Maticsoft.BLL.NicheTypeInfo bll=new Maticsoft.BLL.NicheTypeInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
