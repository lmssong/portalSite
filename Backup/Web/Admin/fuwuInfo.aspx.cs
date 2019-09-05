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
    public partial class fuwuInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                         if (Request.QueryString["fuwuID"] != null)
                {
                    if (Request.QueryString["fuwuID"].ToString() != "")
                    {
                        bind();
                    }
                    else
                    {
                        Response.Redirect("fuwuList.aspx");
                    }
                }
                else
                {
                    Response.Redirect("fuwuList.aspx");
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
            int fuwuid = int.Parse(Request.QueryString["fuwuID"].ToString());
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = fuwubll.GetModel(fuwuid);
            Maticsoft.BLL.FuWuTypeInfo fuwutypebll = new Maticsoft.BLL.FuWuTypeInfo();
            lblfaren.Text = fuwumodel.Write;
            lblfatime.Text = Convert.ToDateTime(fuwumodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lbltitle.Text = fuwumodel.fuwuTitle;
            string fuwutype = fuwutypebll.GetModel(Convert.ToInt32(fuwumodel.FuwuTypeID.ToString())).ToString();
            lbltype.Text = fuwutype;
            if (fuwumodel.ImageURL == "")
            {
                tu.Visible = false;
 
            }
            else
            {
                tu.Visible = true;
                Image1.ImageUrl = fuwumodel.ImageURL;
            
            }
            
        }
    }
}
