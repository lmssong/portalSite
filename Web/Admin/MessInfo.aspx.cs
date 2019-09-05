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
    public partial class MessInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["MessID"] != null)
                        {
                            if (Request.QueryString["MessID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("MessList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("MessList.aspx");
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
            Maticsoft.BLL.MessageInfo messbll = new Maticsoft.BLL.MessageInfo();
            int index = int.Parse(Request.QueryString["MessID"].ToString());
            Maticsoft.Model.MessageInfo messmodel = messbll.GetModel(index );
            lblemail.Text = messmodel.Email;
            lblname.Text = messmodel.Username;
            lblphoto.Text = messmodel.Linkphoto;
            if (messmodel.Sex == 1)
            {
                lblsex.Text = "先生";
            }
            else
            {
                lblsex.Text = "女士";
            }
            lbltime.Text = Convert.ToDateTime(messmodel.DateTime.ToString()).ToString("yyyy-MM-dd");
            lbltitle.Text = messmodel.MessTitle;
            txtcontent.Text = messmodel.Messcontent;
        }
    }
}
