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
namespace Maticsoft.Web.SuccessInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SuccessID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SuccessID);
				}
			}
		}
			
	private void ShowInfo(int SuccessID)
	{
		Maticsoft.BLL.SuccessInfo bll=new Maticsoft.BLL.SuccessInfo();
		Maticsoft.Model.SuccessInfo model=bll.GetModel(SuccessID);
		this.lblSuccessID.Text=model.SuccessID.ToString();
		this.txtSuccessTitle.Text=model.SuccessTitle;
		this.txtFatime.Text=model.Fatime.ToString();
		this.txtWrite.Text=model.Write;
		this.txtImageURL.Text=model.ImageURL;
		this.txtHitNum.Text=model.HitNum.ToString();
		this.txtSuccessContent.Text=model.SuccessContent;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSuccessTitle.Text.Trim().Length==0)
			{
				strErr+="SuccessTitle����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime��ʽ����\\n";	
			}
			if(this.txtWrite.Text.Trim().Length==0)
			{
				strErr+="Write����Ϊ�գ�\\n";	
			}
			if(this.txtImageURL.Text.Trim().Length==0)
			{
				strErr+="ImageURL����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtHitNum.Text))
			{
				strErr+="HitNum��ʽ����\\n";	
			}
			if(this.txtSuccessContent.Text.Trim().Length==0)
			{
				strErr+="SuccessContent����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SuccessID=int.Parse(this.lblSuccessID.Text);
			string SuccessTitle=this.txtSuccessTitle.Text;
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			string Write=this.txtWrite.Text;
			string ImageURL=this.txtImageURL.Text;
			int HitNum=int.Parse(this.txtHitNum.Text);
			string SuccessContent=this.txtSuccessContent.Text;


			Maticsoft.Model.SuccessInfo model=new Maticsoft.Model.SuccessInfo();
			model.SuccessID=SuccessID;
			model.SuccessTitle=SuccessTitle;
			model.Fatime=Fatime;
			model.Write=Write;
			model.ImageURL=ImageURL;
			model.HitNum=HitNum;
			model.SuccessContent=SuccessContent;

			Maticsoft.BLL.SuccessInfo bll=new Maticsoft.BLL.SuccessInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"����ɹ���","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
