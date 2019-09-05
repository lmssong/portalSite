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
namespace Maticsoft.Web.JiShuInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtJishuTitle.Text.Trim().Length==0)
			{
				strErr+="JishuTitle不能为空！\\n";	
			}
			if(this.txtJishuNum.Text.Trim().Length==0)
			{
				strErr+="JishuNum不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime格式错误！\\n";	
			}
			if(this.txtjishuType.Text.Trim().Length==0)
			{
				strErr+="jishuType不能为空！\\n";	
			}
			if(this.txtImageURL.Text.Trim().Length==0)
			{
				strErr+="ImageURL不能为空！\\n";	
			}
			if(this.txtJishuPath.Text.Trim().Length==0)
			{
				strErr+="JishuPath不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string JishuTitle=this.txtJishuTitle.Text;
			string JishuNum=this.txtJishuNum.Text;
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			string jishuType=this.txtjishuType.Text;
			string ImageURL=this.txtImageURL.Text;
			string JishuPath=this.txtJishuPath.Text;

			Maticsoft.Model.JiShuInfo model=new Maticsoft.Model.JiShuInfo();
			model.JishuTitle=JishuTitle;
			model.JishuNum=JishuNum;
			model.Fatime=Fatime;
			model.jishuType=jishuType;
			model.ImageURL=ImageURL;
			model.JishuPath=JishuPath;

			Maticsoft.BLL.JiShuInfo bll=new Maticsoft.BLL.JiShuInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
