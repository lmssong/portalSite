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
namespace Maticsoft.Web.WeiLanInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtWeiTitle.Text.Trim().Length==0)
			{
				strErr+="WeiTitle����Ϊ�գ�\\n";	
			}
			if(this.txtWeiKey.Text.Trim().Length==0)
			{
				strErr+="WeiKey����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime��ʽ����\\n";	
			}
			if(this.txtWrite.Text.Trim().Length==0)
			{
				strErr+="Write����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtHitNum.Text))
			{
				strErr+="HitNum��ʽ����\\n";	
			}
			if(this.txtWeicontent.Text.Trim().Length==0)
			{
				strErr+="Weicontent����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string WeiTitle=this.txtWeiTitle.Text;
			string WeiKey=this.txtWeiKey.Text;
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			string Write=this.txtWrite.Text;
			int HitNum=int.Parse(this.txtHitNum.Text);
			string Weicontent=this.txtWeicontent.Text;

			Maticsoft.Model.WeiLanInfo model=new Maticsoft.Model.WeiLanInfo();
			model.WeiTitle=WeiTitle;
			model.WeiKey=WeiKey;
			model.Fatime=Fatime;
			model.Write=Write;
			model.HitNum=HitNum;
			model.Weicontent=Weicontent;

			Maticsoft.BLL.WeiLanInfo bll=new Maticsoft.BLL.WeiLanInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"����ɹ���","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
