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
namespace Maticsoft.Web.NewsTypeInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NewsTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NewsTypeID);
				}
			}
		}
			
	private void ShowInfo(int NewsTypeID)
	{
		Maticsoft.BLL.NewsTypeInfo bll=new Maticsoft.BLL.NewsTypeInfo();
		Maticsoft.Model.NewsTypeInfo model=bll.GetModel(NewsTypeID);
		this.lblNewsTypeID.Text=model.NewsTypeID.ToString();
		this.txtNewsTypeTitle.Text=model.NewsTypeTitle;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNewsTypeTitle.Text.Trim().Length==0)
			{
				strErr+="NewsTypeTitle不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int NewsTypeID=int.Parse(this.lblNewsTypeID.Text);
			string NewsTypeTitle=this.txtNewsTypeTitle.Text;


			Maticsoft.Model.NewsTypeInfo model=new Maticsoft.Model.NewsTypeInfo();
			model.NewsTypeID=NewsTypeID;
			model.NewsTypeTitle=NewsTypeTitle;

			Maticsoft.BLL.NewsTypeInfo bll=new Maticsoft.BLL.NewsTypeInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
