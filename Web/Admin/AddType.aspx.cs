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
    public partial class AddType : System.Web.UI.Page
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
            Maticsoft.BLL.FuWuTypeInfo fuwubll = new Maticsoft.BLL.FuWuTypeInfo();
            DataSet fuwuds = fuwubll.GetAllList();
            dtlstfuwu.DataSource = fuwuds;
            dtlstfuwu.DataBind();

            Maticsoft.BLL.NewsTypeInfo newsbll = new Maticsoft.BLL.NewsTypeInfo();
            DataSet newsds = newsbll.GetAllList();
            dtlistNews.DataSource = newsds;
            dtlistNews.DataBind();

            

            Maticsoft.BLL.NicheTypeInfo nichebll = new Maticsoft.BLL.NicheTypeInfo();
            DataSet nicheds = nichebll.GetAllList();
            drpNiche.DataSource = nicheds;
            drpNiche.DataBind();


            Maticsoft.BLL.ProductType probll = new Maticsoft.BLL.ProductType();
            DataSet prods = probll.GetAllList(); 
            drpxing.DataSource = prods;
            drpxing.DataTextField = "ProTypeTitle";
            drpxing.DataValueField = "ProTypeID";
            drpxing.DataBind();

        }

        protected void btnfuwu_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.FuWuTypeInfo bll = new Maticsoft.BLL.FuWuTypeInfo();
            Maticsoft.Model.FuWuTypeInfo model = new Maticsoft.Model.FuWuTypeInfo();
            if (TextBox1.Text.Trim() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请将填写完整！')</script>");
                return;
            }
            model.FuwuTypeName = TextBox1.Text.Trim();
            bll.Add(model);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            TextBox1.Text = string.Empty;
        }

        protected void btnPro_Click(object sender, EventArgs e)
        {

        }

        protected void btnNews_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.NewsTypeInfo newsbll = new Maticsoft.BLL.NewsTypeInfo();
            Maticsoft.Model.NewsTypeInfo newmodel = new Maticsoft.Model.NewsTypeInfo();
            if (txtNewsInfo.Text.Trim() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请将填写完整！')</script>");
                return;
            }
            newmodel.NewsTypeTitle = txtNewsInfo.Text.Trim();
            newsbll.Add(newmodel );
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtNewsInfo.Text = "";
        }

        

        protected void btnNiche_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.NicheTypeInfo nichebll = new Maticsoft.BLL.NicheTypeInfo();
            Maticsoft.Model.NicheTypeInfo nichemodel = new Maticsoft.Model.NicheTypeInfo();
            if (txtNiche .Text .Trim ()=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请将填写完整！')</script>");
                return;
            }
            nichemodel.NicheTypeTitle  = txtNiche.Text.Trim();
            nichebll.Add(nichemodel );
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtNiche.Text = string.Empty;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
