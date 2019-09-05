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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int WeiID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(WeiID);
				}
			}
		}
			
	private void ShowInfo(int WeiID)
	{
		Maticsoft.BLL.WeiLanInfo bll=new Maticsoft.BLL.WeiLanInfo();
		Maticsoft.Model.WeiLanInfo model=bll.GetModel(WeiID);
		this.lblWeiID.Text=model.WeiID.ToString();
		this.txtWeiTitle.Text=model.WeiTitle;
		this.txtWeiKey.Text=model.WeiKey;
		this.txtFatime.Text=model.Fatime.ToString();
		this.txtWrite.Text=model.Write;
		this.txtHitNum.Text=model.HitNum.ToString();
		this.txtWeicontent.Text=model.Weicontent;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtWeiTitle.Text.Trim().Length==0)
			{
				strErr+="WeiTitle不能为空！\\n";	
			}
			if(this.txtWeiKey.Text.Trim().Length==0)
			{
				strErr+="WeiKey不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFatime.Text))
			{
				strErr+="Fatime格式错误！\\n";	
			}
			if(this.txtWrite.Text.Trim().Length==0)
			{
				strErr+="Write不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtHitNum.Text))
			{
				strErr+="HitNum格式错误！\\n";	
			}
			if(this.txtWeicontent.Text.Trim().Length==0)
			{
				strErr+="Weicontent不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int WeiID=int.Parse(this.lblWeiID.Text);
			string WeiTitle=this.txtWeiTitle.Text;
			string WeiKey=this.txtWeiKey.Text;
			DateTime Fatime=DateTime.Parse(this.txtFatime.Text);
			string Write=this.txtWrite.Text;
			int HitNum=int.Parse(this.txtHitNum.Text);
			string Weicontent=this.txtWeicontent.Text;


			Maticsoft.Model.WeiLanInfo model=new Maticsoft.Model.WeiLanInfo();
			model.WeiID=WeiID;
			model.WeiTitle=WeiTitle;
			model.WeiKey=WeiKey;
			model.Fatime=Fatime;
			model.Write=Write;
			model.HitNum=HitNum;
			model.Weicontent=Weicontent;

			Maticsoft.BLL.WeiLanInfo bll=new Maticsoft.BLL.WeiLanInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
