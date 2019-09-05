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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string MemberName=this.txtMemberName.Text;
			string Password=this.txtPassword.Text;
			bool Sex=this.chkSex.Checked;
			string Linkphoto=this.txtLinkphoto.Text;
			string Email=this.txtEmail.Text;
			string QQMSN=this.txtQQMSN.Text;

			Maticsoft.Model.MemberInfo model=new Maticsoft.Model.MemberInfo();
			model.MemberName=MemberName;
			model.Password=Password;
			model.Sex=Sex;
			model.Linkphoto=Linkphoto;
			model.Email=Email;
			model.QQMSN=QQMSN;

			Maticsoft.BLL.MemberInfo bll=new Maticsoft.BLL.MemberInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
