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
namespace Maticsoft.Web.FuWuInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfuwuTitle.Text.Trim().Length==0)
			{
				strErr+="fuwuTitle不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFuwuTypeID.Text))
			{
				strErr+="FuwuTypeID格式错误！\\n";	
			}
			if(this.txtWrite.Text.Trim().Length==0)
			{
				strErr+="Write不能为空！\\n";	
			}
			if(this.txtFuwucontent.Text.Trim().Length==0)
			{
				strErr+="Fuwucontent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string fuwuTitle=this.txtfuwuTitle.Text;
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			int FuwuTypeID=int.Parse(this.txtFuwuTypeID.Text);
			string Write=this.txtWrite.Text;
			string Fuwucontent=this.txtFuwucontent.Text;

			Maticsoft.Model.FuWuInfo model=new Maticsoft.Model.FuWuInfo();
			model.fuwuTitle=fuwuTitle;
			model.Fatime=Fatime;
			model.FuwuTypeID=FuwuTypeID;
			model.Write=Write;
			model.Fuwucontent=Fuwucontent;

			Maticsoft.BLL.FuWuInfo bll=new Maticsoft.BLL.FuWuInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
