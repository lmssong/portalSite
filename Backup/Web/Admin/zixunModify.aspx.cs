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
    public partial class zixunModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["zixunID"] != null)
                        {
                            if (Request.QueryString["zixunID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("zixunList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("zixunList.aspx");
                        }
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
            Maticsoft.BLL.ZiXunInfo zixunbll = new Maticsoft.BLL.ZiXunInfo();
            int index = int.Parse(Request.QueryString["zixunID"].ToString());
            Maticsoft.Model.ZiXunInfo zixunmodel = zixunbll.GetModel(index);
            txtlinkphoto.Text = zixunmodel.zixunuserPhoto;
            txtusename.Text = zixunmodel.zixunUserName;
            txtzixuncontent.Text = zixunmodel.zixuncontent;
            txtzixundaan.Text = zixunmodel.ZiXundaan;
            txtzixuntitle.Text = zixunmodel.zixunTitle;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ZiXunInfo zixunbll = new Maticsoft.BLL.ZiXunInfo();
            Maticsoft.Model.ZiXunInfo zixunmodel = zixunbll.GetModel(1);
            if (txtusename.Text.Trim() == "")
            {
                lblusername.Text = "请填写提问人姓名";
                return;
            }
            zixunmodel.zixunUserName = txtusename.Text.Trim();
            lblusername.Text = "";
            if (txtlinkphoto.Text.Trim() == "")
            {
                lbllinkphoto.Text = "请填写您的联系方式";
                return;
            }
            zixunmodel.zixunuserPhoto = txtlinkphoto.Text.Trim();
            lbllinkphoto.Text = "";
            if (txtzixuntitle.Text.Trim() == "")
            {
                lbltitile.Text = "请填写提问标题";
                return;
            }
            zixunmodel.zixunTitle = txtzixuntitle.Text.Trim();
            lbltitile.Text = "";
            if (txtzixuncontent.Text.Trim() == "")
            {
                lblcontent.Text = "请填写提问内容";
                return;
            }
            zixunmodel.zixuncontent = txtzixuncontent.Text.Trim();
            lblcontent.Text = "";
            if (txtzixundaan.Text.Trim() == "")
            {
                lbldaan.Text = "请填写您的答案";
                return;
            }
            
            zixunmodel.ZiXundaan = txtzixundaan.Text.Trim();
            lbldaan.Text = "";
            zixunbll.Update(zixunmodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            bind();
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtlinkphoto.Text = string.Empty;
            txtusename.Text = string.Empty;
            txtzixuncontent.Text = string.Empty;
            txtzixundaan.Text = string.Empty;
            txtzixuntitle.Text = string.Empty;
        }
    }
}
