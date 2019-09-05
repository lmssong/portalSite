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
namespace Maticsoft.Web.ProductXing
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtProTypeID.Text))
			{
				strErr+="ProTypeID格式错误！\\n";	
			}
			if(this.txtProXingTitle.Text.Trim().Length==0)
			{
				strErr+="ProXingTitle不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ProTypeID=int.Parse(this.txtProTypeID.Text);
			string ProXingTitle=this.txtProXingTitle.Text;

			Maticsoft.Model.ProductXing model=new Maticsoft.Model.ProductXing();
			model.ProTypeID=ProTypeID;
			model.ProXingTitle=ProXingTitle;

			Maticsoft.BLL.ProductXing bll=new Maticsoft.BLL.ProductXing();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
