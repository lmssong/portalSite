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
namespace Maticsoft.Web.JobInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtJobTitle.Text.Trim().Length==0)
			{
				strErr+="JobTitle不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtNunber.Text.Trim().Length==0)
			{
				strErr+="Nunber不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtStarttime.Text))
			{
				strErr+="Starttime格式错误！\\n";	
			}
			if(this.txtDuxiang.Text.Trim().Length==0)
			{
				strErr+="Duxiang不能为空！\\n";	
			}
			if(this.txtAge.Text.Trim().Length==0)
			{
				strErr+="Age不能为空！\\n";	
			}
			if(this.txtXueli.Text.Trim().Length==0)
			{
				strErr+="Xueli不能为空！\\n";	
			}
			if(this.txtMonery.Text.Trim().Length==0)
			{
				strErr+="Monery不能为空！\\n";	
			}
			if(this.txtZhuanye.Text.Trim().Length==0)
			{
				strErr+="Zhuanye不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEndtime.Text))
			{
				strErr+="Endtime格式错误！\\n";	
			}
			if(this.txtMiaoshu.Text.Trim().Length==0)
			{
				strErr+="Miaoshu不能为空！\\n";	
			}
			if(this.txtLianxi.Text.Trim().Length==0)
			{
				strErr+="Lianxi不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string JobTitle=this.txtJobTitle.Text;
			string Address=this.txtAddress.Text;
			string Nunber=this.txtNunber.Text;
			DateTime Starttime=DateTime.Parse(this.txtStarttime.Text);
			string Duxiang=this.txtDuxiang.Text;
			string Age=this.txtAge.Text;
			string Xueli=this.txtXueli.Text;
			string Monery=this.txtMonery.Text;
			string Zhuanye=this.txtZhuanye.Text;
			DateTime Endtime=DateTime.Parse(this.txtEndtime.Text);
			string Miaoshu=this.txtMiaoshu.Text;
			string Lianxi=this.txtLianxi.Text;

			Maticsoft.Model.JobInfo model=new Maticsoft.Model.JobInfo();
			model.JobTitle=JobTitle;
			model.Address=Address;
			model.Nunber=Nunber;
			model.Starttime=Starttime;
			model.Duxiang=Duxiang;
			model.Age=Age;
			model.Xueli=Xueli;
			model.Monery=Monery;
			model.Zhuanye=Zhuanye;
			model.Endtime=Endtime;
			model.Miaoshu=Miaoshu;
			model.Lianxi=Lianxi;

			Maticsoft.BLL.JobInfo bll=new Maticsoft.BLL.JobInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
