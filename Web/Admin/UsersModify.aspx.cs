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
    public partial class UsersModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        bind();
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
        }

        private void bind()
        {
            try
            {
                Maticsoft.BLL.MemberInfo menbll = new Maticsoft.BLL.MemberInfo();
                string usernamr = Session["usename"].ToString();
                string name = Server.UrlDecode(usernamr);
                Maticsoft.Model.MemberInfo menmodel1 = menbll.GetpassModel(name);
                int menid = int.Parse(menmodel1.MemberID.ToString());
                Maticsoft.Model.MemberInfo menmodel = menbll.GetModel(menid);
                txtemail.Text = menmodel.Email;
                txtlinkphoto.Text = menmodel.Linkphoto;
                txtname.Text = menmodel.MemberName;
                txtqq.Text = menmodel.QQMSN;
                if (menmodel.Sex == 1)
                {
                    drpsex.SelectedIndex = 1;
                }
                else
                {
                    drpsex.SelectedIndex = 2;
                }
            }
            catch (Exception ex) {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发生错误：" + ex.Message + "')</script>");
            }
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.BLL.MemberInfo menbll = new Maticsoft.BLL.MemberInfo();
                Maticsoft.Model.MemberInfo menmodel = menbll.GetpassModel(txtname.Text.Trim());
                
                menmodel.MemberName = txtname.Text.Trim();
                lblusername.Text = "";
                if (txtpass.Text.Trim() == "")
                {
                    lblpass.Text = "请填写密码";
                    return;
                }
                if (txtpassord.Text.Trim() == "")
                {
                    lblpassword.Text = "请填写确认密码";
                    return;
                }
                if (txtpass.Text.Trim() != menmodel.Password)
                {
                    lblpass.Text = "您的旧密码输入不正确";
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
                menbll.Update(menmodel);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
                bind();
            }
            catch (Exception ex) {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发生错误："+ ex.Message+"')</script>");
            }
            
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
