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
    public partial class zixunInfo : System.Web.UI.Page
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
            lblname.Text = zixunmodel.zixunUserName;
            lbltitle.Text = zixunmodel.zixunTitle;
            lblphoto.Text = zixunmodel.zixunuserPhoto;
            txtzixuncontent.Text = zixunmodel.zixuncontent;
            txtzixundaan.Text = zixunmodel.ZiXundaan;
        }
    }
}
