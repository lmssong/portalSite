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
namespace Maticsoft.Web.MessageInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMessTitle.Text.Trim().Length==0)
			{
				strErr+="MessTitle����Ϊ�գ�\\n";	
			}
			if(this.txtUsername.Text.Trim().Length==0)
			{
				strErr+="Username����Ϊ�գ�\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address����Ϊ�գ�\\n";	
			}
			if(this.txtLinkphoto.Text.Trim().Length==0)
			{
				strErr+="Linkphoto����Ϊ�գ�\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="Email����Ϊ�գ�\\n";	
			}
			if(this.txtMesscontent.Text.Trim().Length==0)
			{
				strErr+="Messcontent����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string MessTitle=this.txtMessTitle.Text;
			string Username=this.txtUsername.Text;
			bool Sex=this.chkSex.Checked;
			string Address=this.txtAddress.Text;
			string Linkphoto=this.txtLinkphoto.Text;
			string Email=this.txtEmail.Text;
			string Messcontent=this.txtMesscontent.Text;

			Maticsoft.Model.MessageInfo model=new Maticsoft.Model.MessageInfo();
			model.MessTitle=MessTitle;
			model.Username=Username;
			model.Sex=Sex;
			model.Address=Address;
			model.Linkphoto=Linkphoto;
			model.Email=Email;
			model.Messcontent=Messcontent;

			Maticsoft.BLL.MessageInfo bll=new Maticsoft.BLL.MessageInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"����ɹ���","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
