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
namespace Maticsoft.Web.Product
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
			if(!PageValidate.IsNumber(txtProTypeID.Text))
			{
				strErr+="ProTypeID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtProXingID.Text))
			{
				strErr+="ProXingID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtProchutime.Text))
			{
				strErr+="Prochutime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHitNum.Text))
			{
				strErr+="HitNum格式错误！\\n";	
			}
			if(this.txtProcontent.Text.Trim().Length==0)
			{
				strErr+="Procontent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			int ProTypeID=int.Parse(this.txtProTypeID.Text);
			int ProXingID=int.Parse(this.txtProXingID.Text);
			DateTime Prochutime=DateTime.Parse(this.txtProchutime.Text);
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			bool Toujian=this.chkToujian.Checked;
			int HitNum=int.Parse(this.txtHitNum.Text);
			string Procontent=this.txtProcontent.Text;

			Maticsoft.Model.Product model=new Maticsoft.Model.Product();
			model.ProName=ProName;
			model.ProTypeID=ProTypeID;
			model.ProXingID=ProXingID;
			model.Prochutime=Prochutime;
			model.Fatime=Fatime;
			model.Toujian=Toujian;
			model.HitNum=HitNum;
			model.Procontent=Procontent;

			Maticsoft.BLL.Product bll=new Maticsoft.BLL.Product();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
