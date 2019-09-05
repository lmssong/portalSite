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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MessID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MessID);
				}
			}
		}
			
	private void ShowInfo(int MessID)
	{
		Maticsoft.BLL.MessageInfo bll=new Maticsoft.BLL.MessageInfo();
		Maticsoft.Model.MessageInfo model=bll.GetModel(MessID);
		this.lblMessID.Text=model.MessID.ToString();
		this.txtMessTitle.Text=model.MessTitle;
		this.txtUsername.Text=model.Username;
		this.chkSex.Checked=model.Sex;
		this.txtAddress.Text=model.Address;
		this.txtLinkphoto.Text=model.Linkphoto;
		this.txtEmail.Text=model.Email;
		this.txtMesscontent.Text=model.Messcontent;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMessTitle.Text.Trim().Length==0)
			{
				strErr+="MessTitle不能为空！\\n";	
			}
			if(this.txtUsername.Text.Trim().Length==0)
			{
				strErr+="Username不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtLinkphoto.Text.Trim().Length==0)
			{
				strErr+="Linkphoto不能为空！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="Email不能为空！\\n";	
			}
			if(this.txtMesscontent.Text.Trim().Length==0)
			{
				strErr+="Messcontent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MessID=int.Parse(this.lblMessID.Text);
			string MessTitle=this.txtMessTitle.Text;
			string Username=this.txtUsername.Text;
			bool Sex=this.chkSex.Checked;
			string Address=this.txtAddress.Text;
			string Linkphoto=this.txtLinkphoto.Text;
			string Email=this.txtEmail.Text;
			string Messcontent=this.txtMesscontent.Text;


			Maticsoft.Model.MessageInfo model=new Maticsoft.Model.MessageInfo();
			model.MessID=MessID;
			model.MessTitle=MessTitle;
			model.Username=Username;
			model.Sex=Sex;
			model.Address=Address;
			model.Linkphoto=Linkphoto;
			model.Email=Email;
			model.Messcontent=Messcontent;

			Maticsoft.BLL.MessageInfo bll=new Maticsoft.BLL.MessageInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
