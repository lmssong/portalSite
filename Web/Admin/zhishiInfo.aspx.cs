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
    public partial class zhishiInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["WeiID"] != null)
                        {
                            if (Request.QueryString["WeiID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("zhishiList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("zhishiList.aspx");
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
            Maticsoft.BLL.WeiLanInfo weilanbll = new Maticsoft.BLL.WeiLanInfo();
            int index = int.Parse(Request.QueryString["WeiID"].ToString());
            Maticsoft.Model.WeiLanInfo weilanmodel = weilanbll.GetModel(index );
            lblfatime.Text = Convert.ToDateTime(weilanmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lblkey.Text = weilanmodel.WeiKey;
            lbltitle.Text = weilanmodel.WeiTitle;
            lblwrite.Text = weilanmodel.Write;
            txtcontent.Text = weilanmodel.Weicontent;
        }
    }
}
