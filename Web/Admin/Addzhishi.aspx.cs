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

namespace Maticsoft.Web.Admin
{
    public partial class Addzhishi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                if (Session["usename"].ToString() != "")
                {
                    
                }
                else
                {
                    Response.Redirect("login.aspx");
                    Response.End();
                }
            }
            else
            {
                Response.Redirect("login.aspx");
                Response.End();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtcontent.Text = string.Empty;
            txtFatime.Text = string.Empty;
            txtkeyword.Text = string.Empty;
            txtwrite.Text = string.Empty;
            txtzhishititle.Text = string.Empty;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.WeiLanInfo weilanbll = new Maticsoft.BLL.WeiLanInfo();
            Maticsoft.Model.WeiLanInfo weilanmodel = new Maticsoft.Model.WeiLanInfo();
            if (txtzhishititle.Text.Trim() == "")
            {
                lbltitle.Text = "请填写围栏标题";
                return;
            }
            weilanmodel.WeiTitle = txtzhishititle.Text.Trim();
            lbltitle.Text = "";
            if (txtkeyword.Text.Trim() == "")
            {
                lblkeyword.Text = "请填写关键字";
                return;
            }
            weilanmodel.WeiKey = txtkeyword.Text.Trim();
            lblkeyword.Text = "";
            if (txtFatime.Text.Trim() == "")
            {
                lblfatime.Text = "请填写发布时间";
                return;
            }
            weilanmodel.Fatime = Convert.ToDateTime(txtFatime.Text.Trim());
            lblfatime.Text = "";
            if (txtwrite.Text.Trim() == "")
            {
                lblwrite.Text = "请填写发布人";
                return;
            }
            weilanmodel.Write = txtwrite.Text.Trim();
            lblwrite.Text = "";
            weilanmodel.Weicontent = txtcontent.Text.Trim();
            weilanbll.Add(weilanmodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtcontent.Text = string.Empty;
            txtFatime.Text = string.Empty;
            txtkeyword.Text = string.Empty;
            txtwrite.Text = string.Empty;
            txtzhishititle.Text = string.Empty;
        }
    }
}
