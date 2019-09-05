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
namespace Maticsoft.Web.NicheInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NicheID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NicheID);
				}
			}
		}
			
	private void ShowInfo(int NicheID)
	{
		Maticsoft.BLL.NicheInfo bll=new Maticsoft.BLL.NicheInfo();
		Maticsoft.Model.NicheInfo model=bll.GetModel(NicheID);
		this.lblNicheID.Text=model.NicheID.ToString();
		this.txtNicheTitle.Text=model.NicheTitle;
		this.txtNicheKey.Text=model.NicheKey;
		this.txtFatime.Text=model.Fatime.ToString();
		this.txtWrite.Text=model.Write;
		this.txtImageURL.Text=model.ImageURL;
		this.txtNicheTypeID.Text=model.NicheTypeID.ToString();
		this.txtHitNum.Text=model.HitNum.ToString();
		this.txtNicheContent.Text=model.NicheContent;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNicheTitle.Text.Trim().Length==0)
			{
				strErr+="NicheTitle不能为空！\\n";	
			}
			if(this.txtNicheKey.Text.Trim().Length==0)
			{
				strErr+="NicheKey不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime格式错误！\\n";	
			}
			if(this.txtWrite.Text.Trim().Length==0)
			{
				strErr+="Write不能为空！\\n";	
			}
			if(this.txtImageURL.Text.Trim().Length==0)
			{
				strErr+="ImageURL不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtNicheTypeID.Text))
			{
				strErr+="NicheTypeID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHitNum.Text))
			{
				strErr+="HitNum格式错误！\\n";	
			}
			if(this.txtNicheContent.Text.Trim().Length==0)
			{
				strErr+="NicheContent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int NicheID=int.Parse(this.lblNicheID.Text);
			string NicheTitle=this.txtNicheTitle.Text;
			string NicheKey=this.txtNicheKey.Text;
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			string Write=this.txtWrite.Text;
			string ImageURL=this.txtImageURL.Text;
			int NicheTypeID=int.Parse(this.txtNicheTypeID.Text);
			int HitNum=int.Parse(this.txtHitNum.Text);
			string NicheContent=this.txtNicheContent.Text;


			Maticsoft.Model.NicheInfo model=new Maticsoft.Model.NicheInfo();
			model.NicheID=NicheID;
			model.NicheTitle=NicheTitle;
			model.NicheKey=NicheKey;
			model.Fatime=Fatime;
			model.Write=Write;
			model.ImageURL=ImageURL;
			model.NicheTypeID=NicheTypeID;
			model.HitNum=HitNum;
			model.NicheContent=NicheContent;

			Maticsoft.BLL.NicheInfo bll=new Maticsoft.BLL.NicheInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
