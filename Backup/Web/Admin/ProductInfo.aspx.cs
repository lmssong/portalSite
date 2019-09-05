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
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["ProID"] != null)
                        {
                            if (Request.QueryString["ProID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("ProductList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("ProductList.aspx");
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
            Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
            int index = int.Parse(Request.QueryString["ProID"].ToString());
            Maticsoft.Model.Product promodel = probll.GetModel(index);
            Maticsoft.BLL.ProductType typebll = new Maticsoft.BLL.ProductType();
            Maticsoft.Model.ProductType typemodel = typebll.GetModel(int.Parse(promodel.ProTypeID.ToString()));
            Maticsoft.BLL.ProductXing xinbll = new Maticsoft.BLL.ProductXing();
            Maticsoft.Model.ProductXing xinmodel = xinbll.GetModel(int.Parse(promodel.ProXingID.ToString()));
            lblchutime.Text = Convert.ToDateTime(promodel.Prochutime.ToString()).ToString("yyyy-MM-dd");
            lblstarttime.Text = Convert.ToDateTime(promodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lbltitle.Text = promodel.ProName;
            lbltype.Text = typemodel.ProTypeTitle;
            lblxinghao.Text = xinmodel.ProXingTitle;
            Image1.ImageUrl = promodel.ImageURL;
            txtcontent.Text = promodel.Procontent;
            if (promodel.Toujian == 1)
            {
                toujian.Visible = false;
            }
            else
            {
                toujian.Visible = true;

            }
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
            int index = int.Parse(Request.QueryString["ProID"].ToString());
            Maticsoft.Model.Product promodel = probll.GetModel(index);
            promodel.Toujian = 1;
            probll.Update(promodel);
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<scripe>alert('推荐成功....')</script>");
            bind();
        }
    }
}
