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
namespace Maticsoft.Web.JobZiJianInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUsersname.Text.Trim().Length==0)
			{
				strErr+="Usersname不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtJobID.Text))
			{
				strErr+="JobID格式错误！\\n";	
			}
			if(this.txtXueli.Text.Trim().Length==0)
			{
				strErr+="Xueli不能为空！\\n";	
			}
			if(this.txtJiguan.Text.Trim().Length==0)
			{
				strErr+="Jiguan不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBritday.Text))
			{
				strErr+="Britday格式错误！\\n";	
			}
			if(this.txtZhuanye.Text.Trim().Length==0)
			{
				strErr+="Zhuanye不能为空！\\n";	
			}
			if(this.txtJiaoyu.Text.Trim().Length==0)
			{
				strErr+="Jiaoyu不能为空！\\n";	
			}
			if(this.txtJingyan.Text.Trim().Length==0)
			{
				strErr+="Jingyan不能为空！\\n";	
			}
			if(this.txtPingjia.Text.Trim().Length==0)
			{
				strErr+="Pingjia不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Usersname=this.txtUsersname.Text;
			int JobID=int.Parse(this.txtJobID.Text);
			bool Sex=this.chkSex.Checked;
			string Xueli=this.txtXueli.Text;
			string Jiguan=this.txtJiguan.Text;
			DateTime Britday=DateTime.Parse(this.txtBritday.Text);
			string Zhuanye=this.txtZhuanye.Text;
			string Jiaoyu=this.txtJiaoyu.Text;
			string Jingyan=this.txtJingyan.Text;
			string Pingjia=this.txtPingjia.Text;

			Maticsoft.Model.JobZiJianInfo model=new Maticsoft.Model.JobZiJianInfo();
			model.Usersname=Usersname;
			model.JobID=JobID;
			model.Sex=Sex;
			model.Xueli=Xueli;
			model.Jiguan=Jiguan;
			model.Britday=Britday;
			model.Zhuanye=Zhuanye;
			model.Jiaoyu=Jiaoyu;
			model.Jingyan=Jingyan;
			model.Pingjia=Pingjia;

			Maticsoft.BLL.JobZiJianInfo bll=new Maticsoft.BLL.JobZiJianInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
