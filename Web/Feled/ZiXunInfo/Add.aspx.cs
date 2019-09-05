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
namespace Maticsoft.Web.ZiXunInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtzixunTitle.Text.Trim().Length==0)
			{
				strErr+="zixunTitle不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtzixuntime.Text))
			{
				strErr+="zixuntime格式错误！\\n";	
			}
			if(this.txtzixuncontent.Text.Trim().Length==0)
			{
				strErr+="zixuncontent不能为空！\\n";	
			}
			if(this.txtzixunUserName.Text.Trim().Length==0)
			{
				strErr+="zixunUserName不能为空！\\n";	
			}
			if(this.txtzixunuserPhoto.Text.Trim().Length==0)
			{
				strErr+="zixunuserPhoto不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string zixunTitle=this.txtzixunTitle.Text;
			DateTime zixuntime=DateTime.Parse(this.txtzixuntime.Text);
			string zixuncontent=this.txtzixuncontent.Text;
			string zixunUserName=this.txtzixunUserName.Text;
			string zixunuserPhoto=this.txtzixunuserPhoto.Text;

			Maticsoft.Model.ZiXunInfo model=new Maticsoft.Model.ZiXunInfo();
			model.zixunTitle=zixunTitle;
			model.zixuntime=zixuntime;
			model.zixuncontent=zixuncontent;
			model.zixunUserName=zixunUserName;
			model.zixunuserPhoto=zixunuserPhoto;

			Maticsoft.BLL.ZiXunInfo bll=new Maticsoft.BLL.ZiXunInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
