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
namespace Maticsoft.Web.MemberInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MemberID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MemberID);
				}
			}
		}
			
	private void ShowInfo(int MemberID)
	{
		Maticsoft.BLL.MemberInfo bll=new Maticsoft.BLL.MemberInfo();
		Maticsoft.Model.MemberInfo model=bll.GetModel(MemberID);
		this.lblMemberID.Text=model.MemberID.ToString();
		this.txtMemberName.Text=model.MemberName;
		this.txtPassword.Text=model.Password;
		this.chkSex.Checked=model.Sex;
		this.txtLinkphoto.Text=model.Linkphoto;
		this.txtEmail.Text=model.Email;
		this.txtQQMSN.Text=model.QQMSN;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMemberName.Text.Trim().Length==0)
			{
				strErr+="MemberName不能为空！\\n";	
			}
			if(this.txtPassword.Text.Trim().Length==0)
			{
				strErr+="Password不能为空！\\n";	
			}
			if(this.txtLinkphoto.Text.Trim().Length==0)
			{
				strErr+="Linkphoto不能为空！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="Email不能为空！\\n";	
			}
			if(this.txtQQMSN.Text.Trim().Length==0)
			{
				strErr+="QQMSN不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MemberID=int.Parse(this.lblMemberID.Text);
			string MemberName=this.txtMemberName.Text;
			string Password=this.txtPassword.Text;
			bool Sex=this.chkSex.Checked;
			string Linkphoto=this.txtLinkphoto.Text;
			string Email=this.txtEmail.Text;
			string QQMSN=this.txtQQMSN.Text;


			Maticsoft.Model.MemberInfo model=new Maticsoft.Model.MemberInfo();
			model.MemberID=MemberID;
			model.MemberName=MemberName;
			model.Password=Password;
			model.Sex=Sex;
			model.Linkphoto=Linkphoto;
			model.Email=Email;
			model.QQMSN=QQMSN;

			Maticsoft.BLL.MemberInfo bll=new Maticsoft.BLL.MemberInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
