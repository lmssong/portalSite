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
    public partial class AddUsers : System.Web.UI.Page
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

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.MemberInfo menbll = new Maticsoft.BLL.MemberInfo();
            Maticsoft.Model.MemberInfo menmodel = new Maticsoft.Model.MemberInfo();
            if (txtname.Text.Trim() == "")
            {
                lblusername.Text = "请填写用户名";
                return;
            }
            if (menbll.GetExists(txtname.Text.Trim())) {
                lblusername.Text = "用户已存在";
                return;
            }
            menmodel.MemberName = txtname.Text.Trim();
            lblusername.Text = "";
            if (txtpass .Text .Trim ()=="")
            {
                lblpass.Text = "请填写密码";
                return;
            }
            if (txtpassord .Text .Trim ()=="")
            {
                lblpassword.Text = "请填写确认密码";
                return;
            }
            if (txtpass.Text.Trim() != txtpassord.Text.Trim())
            {
                lblpassword.Text = "前后密码不相同";
                return;
            }
            menmodel.Password = txtpassord.Text.Trim();
            lblpass.Text = "";
            lblpassword.Text = "";
            if (drpsex.SelectedIndex == 0)
            {
                lblsex.Text = "请选择您的性别";
               
            }
            else if (drpsex.SelectedIndex == 1)
            {
                menmodel.Sex = 1;
            }
            else
            {
                menmodel.Sex = 0;
            }
            
            if (txtlinkphoto.Text.Trim() == "")
            {
                lblLinkphoto.Text = "请填写联系电话";
                return;
            }
            menmodel.Linkphoto = txtlinkphoto.Text.Trim();
            lblLinkphoto.Text = "";
            if (txtemail.Text.Trim() == "")
            {
                lblemail.Text = "请填写电子邮箱";
                return;
            }
            menmodel.Email = txtemail.Text.Trim();
            lblemail.Text = "";
            menmodel.QQMSN = txtqq.Text.Trim();
            menbll.Add(menmodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtname.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtpassord.Text = string.Empty;
            txtlinkphoto.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtqq.Text = string.Empty;
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtname.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtpassord.Text = string.Empty;
            txtlinkphoto.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtqq.Text = string.Empty;

        }

         
    }
}
