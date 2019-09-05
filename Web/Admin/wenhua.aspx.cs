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
    public partial class wenhua : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
                        if (combll.Exists(2) == true)
                        {
                            bind();
                        }
                        else
                        {
                            btnok.Visible = true;
                            btnupdael.Visible = false;
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
            btnupdael.Visible = true;
            btnok.Visible = false;
            Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
            Maticsoft.Model.ComPanyInfo commodel = combll.GetgonggaoModel(2);
            txtwenhua.Text = commodel.Gonggao;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
            Maticsoft.Model.ComPanyInfo commodel = new Maticsoft.Model.ComPanyInfo();
            commodel.Gonggao = txtwenhua.Text.Trim();
            combll.Add(commodel);
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('信息添加成功')</script>");
            bind();

        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtwenhua.Text = string.Empty;
        }

        protected void btnupdael_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
            Maticsoft.Model.ComPanyInfo commodel = combll.GetgonggaoModel(2);
            commodel.Gonggao = txtwenhua.Text.Trim();
            combll.Update(commodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息提交成功')</script>");
            bind();
        }
    }
}
