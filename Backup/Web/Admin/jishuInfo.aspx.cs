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
    public partial class jishuInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//JishuID
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["JishuID"] != null)
                        {
                            if (Request.QueryString["JishuID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("jishuList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("jishuList.aspx");
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
            Maticsoft.BLL.JiShuInfo jishubll = new Maticsoft.BLL.JiShuInfo();
            int index = int.Parse(Request.QueryString["JishuID"].ToString());
            Maticsoft.Model.JiShuInfo jishumodel = jishubll.GetModel(index);
            lbltime.Text = Convert.ToDateTime(jishumodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lbltitle.Text = jishumodel.JishuTitle;
            lbltype.Text = jishumodel.jishuType;
            lblwenjian.Text = jishumodel.JishuPath;
            Image1.ImageUrl = jishumodel.ImageURL;
            txtNewContent.Text = jishumodel.Jishucontent;
        }
    }
}
