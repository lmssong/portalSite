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
namespace Maticsoft.Web.ComPanyInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGonggao.Text.Trim().Length==0)
			{
				strErr+="Gonggao不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtGongTime.Text))
			{
				strErr+="GongTime格式错误！\\n";	
			}
			if(this.txtImageURL.Text.Trim().Length==0)
			{
				strErr+="ImageURL不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFenleiID.Text))
			{
				strErr+="FenleiID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Gonggao=this.txtGonggao.Text;
			DateTime GongTime=DateTime.Parse(this.txtGongTime.Text);
			string ImageURL=this.txtImageURL.Text;
			int FenleiID=int.Parse(this.txtFenleiID.Text);

			Maticsoft.Model.ComPanyInfo model=new Maticsoft.Model.ComPanyInfo();
			model.Gonggao=Gonggao;
			model.GongTime=GongTime;
			model.ImageURL=ImageURL;
			model.FenleiID=FenleiID;

			Maticsoft.BLL.ComPanyInfo bll=new Maticsoft.BLL.ComPanyInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
