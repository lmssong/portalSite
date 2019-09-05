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
    public partial class NewsInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["NewsID"] != null)
                        {
                            if (Request.QueryString["NewsID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("NewsLIst.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("NewsLIst.aspx");
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
            Maticsoft.BLL.NewsInfo newsbll = new Maticsoft.BLL.NewsInfo();
            int index = int.Parse(Request.QueryString["NewsID"].ToString());
            Maticsoft.Model.NewsInfo newmodel = newsbll.GetModel(index);
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            int typeid = int.Parse(newmodel.NewsTypeID.ToString());
            Maticsoft.Model.NewsTypeInfo typemodel = typebll.GetModel(typeid);
            lblkey.Text = newmodel.NewsKey;
            lblstarttime.Text = Convert.ToDateTime(newmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lbltitle.Text = newmodel.NewsTitle;
            lbltype.Text = typemodel.NewsTypeTitle;
            lblwrite.Text = newmodel.Write;
            Image1.ImageUrl = newmodel.ImageURL;
            txtcontent.Text = newmodel.NewsContent;
        }
    }
}
