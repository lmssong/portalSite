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
namespace Maticsoft.Web.DingProduct
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProName.Text.Trim().Length==0)
			{
				strErr+="ProName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtProXingID.Text))
			{
				strErr+="ProXingID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtProTypeID.Text))
			{
				strErr+="ProTypeID格式错误！\\n";	
			}
			if(this.txtDingNum.Text.Trim().Length==0)
			{
				strErr+="DingNum不能为空！\\n";	
			}
			if(this.txtDingAddress.Text.Trim().Length==0)
			{
				strErr+="DingAddress不能为空！\\n";	
			}
			if(this.txtLinkPhoto.Text.Trim().Length==0)
			{
				strErr+="LinkPhoto不能为空！\\n";	
			}
			if(this.txtDingEmail.Text.Trim().Length==0)
			{
				strErr+="DingEmail不能为空！\\n";	
			}
			if(this.txtUsersName.Text.Trim().Length==0)
			{
				strErr+="UsersName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDingtime.Text))
			{
				strErr+="Dingtime格式错误！\\n";	
			}
			if(this.txtDingcontent.Text.Trim().Length==0)
			{
				strErr+="Dingcontent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			int ProXingID=int.Parse(this.txtProXingID.Text);
			int ProTypeID=int.Parse(this.txtProTypeID.Text);
			string DingNum=this.txtDingNum.Text;
			string DingAddress=this.txtDingAddress.Text;
			string LinkPhoto=this.txtLinkPhoto.Text;
			string DingEmail=this.txtDingEmail.Text;
			bool DingSex=this.chkDingSex.Checked;
			string UsersName=this.txtUsersName.Text;
			DateTime Dingtime=DateTime.Parse(this.txtDingtime.Text);
			string Dingcontent=this.txtDingcontent.Text;

			Maticsoft.Model.DingProduct model=new Maticsoft.Model.DingProduct();
			model.ProName=ProName;
			model.ProXingID=ProXingID;
			model.ProTypeID=ProTypeID;
			model.DingNum=DingNum;
			model.DingAddress=DingAddress;
			model.LinkPhoto=LinkPhoto;
			model.DingEmail=DingEmail;
			model.DingSex=DingSex;
			model.UsersName=UsersName;
			model.Dingtime=Dingtime;
			model.Dingcontent=Dingcontent;

			Maticsoft.BLL.DingProduct bll=new Maticsoft.BLL.DingProduct();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
