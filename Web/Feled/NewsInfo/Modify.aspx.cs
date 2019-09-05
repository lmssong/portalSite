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
namespace Maticsoft.Web.NewsInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NewsID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NewsID);
				}
			}
		}
			
	private void ShowInfo(int NewsID)
	{
		Maticsoft.BLL.NewsInfo bll=new Maticsoft.BLL.NewsInfo();
		Maticsoft.Model.NewsInfo model=bll.GetModel(NewsID);
		this.lblNewsID.Text=model.NewsID.ToString();
		this.txtNewsTitle.Text=model.NewsTitle;
		this.txtNewsKey.Text=model.NewsKey;
		this.txtWrite.Text=model.Write;
		this.txtNewsTypeID.Text=model.NewsTypeID.ToString();
		this.txtFatime.Text=model.Fatime.ToString();
		this.txtImageURL.Text=model.ImageURL;
		this.txtHitNum.Text=model.HitNum.ToString();
		this.txtNewsContent.Text=model.NewsContent;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNewsTitle.Text.Trim().Length==0)
			{
				strErr+="NewsTitle不能为空！\\n";	
			}
			if(this.txtNewsKey.Text.Trim().Length==0)
			{
				strErr+="NewsKey不能为空！\\n";	
			}
			if(this.txtWrite.Text.Trim().Length==0)
			{
				strErr+="Write不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtNewsTypeID.Text))
			{
				strErr+="NewsTypeID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime格式错误！\\n";	
			}
			if(this.txtImageURL.Text.Trim().Length==0)
			{
				strErr+="ImageURL不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtHitNum.Text))
			{
				strErr+="HitNum格式错误！\\n";	
			}
			if(this.txtNewsContent.Text.Trim().Length==0)
			{
				strErr+="NewsContent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int NewsID=int.Parse(this.lblNewsID.Text);
			string NewsTitle=this.txtNewsTitle.Text;
			string NewsKey=this.txtNewsKey.Text;
			string Write=this.txtWrite.Text;
			int NewsTypeID=int.Parse(this.txtNewsTypeID.Text);
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			string ImageURL=this.txtImageURL.Text;
			int HitNum=int.Parse(this.txtHitNum.Text);
			string NewsContent=this.txtNewsContent.Text;


			Maticsoft.Model.NewsInfo model=new Maticsoft.Model.NewsInfo();
			model.NewsID=NewsID;
			model.NewsTitle=NewsTitle;
			model.NewsKey=NewsKey;
			model.Write=Write;
			model.NewsTypeID=NewsTypeID;
			model.Fatime=Fatime;
			model.ImageURL=ImageURL;
			model.HitNum=HitNum;
			model.NewsContent=NewsContent;

			Maticsoft.BLL.NewsInfo bll=new Maticsoft.BLL.NewsInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
