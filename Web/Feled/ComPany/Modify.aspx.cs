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
namespace Maticsoft.Web.ComPany
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CompanyID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(CompanyID);
				}
			}
		}
			
	private void ShowInfo(int CompanyID)
	{
		Maticsoft.BLL.ComPany bll=new Maticsoft.BLL.ComPany();
		Maticsoft.Model.ComPany model=bll.GetModel(CompanyID);
		this.lblCompanyID.Text=model.CompanyID.ToString();
		this.txtCompanyNames.Text=model.CompanyNames;
		this.txtCompanyType.Text=model.CompanyType;
		this.txtComAddress.Text=model.ComAddress;
		this.txtComFax.Text=model.ComFax;
		this.txtComPhoto.Text=model.ComPhoto;
		this.txtComEmail.Text=model.ComEmail;
		this.txtQQ.Text=model.QQ;
		this.txtComwangzhi.Text=model.Comwangzhi;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyNames.Text.Trim().Length==0)
			{
				strErr+="CompanyNames����Ϊ�գ�\\n";	
			}
			if(this.txtCompanyType.Text.Trim().Length==0)
			{
				strErr+="CompanyType����Ϊ�գ�\\n";	
			}
			if(this.txtComAddress.Text.Trim().Length==0)
			{
				strErr+="ComAddress����Ϊ�գ�\\n";	
			}
			if(this.txtComFax.Text.Trim().Length==0)
			{
				strErr+="ComFax����Ϊ�գ�\\n";	
			}
			if(this.txtComPhoto.Text.Trim().Length==0)
			{
				strErr+="ComPhoto����Ϊ�գ�\\n";	
			}
			if(this.txtComEmail.Text.Trim().Length==0)
			{
				strErr+="ComEmail����Ϊ�գ�\\n";	
			}
			if(this.txtQQ.Text.Trim().Length==0)
			{
				strErr+="QQ����Ϊ�գ�\\n";	
			}
			if(this.txtComwangzhi.Text.Trim().Length==0)
			{
				strErr+="Comwangzhi����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CompanyID=int.Parse(this.lblCompanyID.Text);
			string CompanyNames=this.txtCompanyNames.Text;
			string CompanyType=this.txtCompanyType.Text;
			string ComAddress=this.txtComAddress.Text;
			string ComFax=this.txtComFax.Text;
			string ComPhoto=this.txtComPhoto.Text;
			string ComEmail=this.txtComEmail.Text;
			string QQ=this.txtQQ.Text;
			string Comwangzhi=this.txtComwangzhi.Text;


			Maticsoft.Model.ComPany model=new Maticsoft.Model.ComPany();
			model.CompanyID=CompanyID;
			model.CompanyNames=CompanyNames;
			model.CompanyType=CompanyType;
			model.ComAddress=ComAddress;
			model.ComFax=ComFax;
			model.ComPhoto=ComPhoto;
			model.ComEmail=ComEmail;
			model.QQ=QQ;
			model.Comwangzhi=Comwangzhi;

			Maticsoft.BLL.ComPany bll=new Maticsoft.BLL.ComPany();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"����ɹ���","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
