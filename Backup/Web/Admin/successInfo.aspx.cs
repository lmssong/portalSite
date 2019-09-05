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
    public partial class successInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["SuccessID"] != null)
                        {
                            if (Request.QueryString["SuccessID"].ToString() != null)
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("successList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("successList.aspx");
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
            Maticsoft.BLL.SuccessInfo successbll = new Maticsoft.BLL.SuccessInfo();
            int index = int.Parse(Request.QueryString["SuccessID"].ToString());
            Maticsoft.Model.SuccessInfo successmodel = successbll.GetModel(index);
            lblfatime.Text = Convert.ToDateTime(successmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lbltitle.Text = successmodel.SuccessTitle;
            lblwrite.Text = successmodel.Write;
            txtcontent.Text = successmodel.SuccessContent;
            Image1.ImageUrl = successmodel.ImageURL;
        }
    }
}
