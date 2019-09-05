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

namespace Maticsoft.Web
{
    public partial class message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.MessageInfo messbll = new Maticsoft.BLL.MessageInfo();
            Maticsoft.Model.MessageInfo messmodel = new Maticsoft.Model.MessageInfo();
            messmodel.Address = txtAddress.Text.Trim();
            messmodel.DateTime = Convert.ToDateTime(DateTime .Now .ToString ());
            messmodel.Email = txtEmail.Text.Trim();
            if (txtMesscontent.Text.Trim() == "")
            {
                lblcotent.Text = "请填写留言内容";
                return;
            }
            lblcotent.Text = "";
            messmodel.Messcontent = txtMesscontent.Text.Trim();
            if (txtMessTitle.Text.Trim() == "")
            {
                lnltitle.Text = "请填写留言名称";
                return;
            }
            lnltitle.Text = "";
            messmodel.MessTitle = txtMessTitle.Text.Trim();
            if (txtUsername.Text.Trim() == "")
            {
                lblusename.Text = "请填写用户名称";
                return;
            }
            messmodel.Username = txtUsername.Text.Trim();
            lblusename.Text = "";
            if (drpSex.SelectedValue != "1" && drpSex.SelectedValue != "0")
            {
                lblsex.Text = "请选择您的性别";
                return;
            }
            messmodel.Sex = int.Parse(drpSex.SelectedValue);
            lblsex.Text = "";
            messmodel.Linkphoto = txtLinkphoto.Text.Trim();
            messbll.Add(messmodel );
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('信息提交成功！！！')</script>");

            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLinkphoto.Text = string.Empty;
            txtMesscontent.Text = string.Empty;
            txtMessTitle.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLinkphoto.Text = string.Empty;
            txtMesscontent.Text = string.Empty;
            txtMessTitle.Text = string.Empty;
            txtUsername.Text = string.Empty;

        }
    }
}
