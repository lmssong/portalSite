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
    public partial class gonggao : System.Web.UI.Page
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
                        Maticsoft.Model.ComPanyInfo commodel = combll.GetgonggaoModel(1);
                        if (combll.getfenleiExists(1) == true)
                        {
                            btnok.Visible = false;
                            btntian.Visible = true;
                            bind();
                        }
                        else if (combll.getfenleiExists(1) == false)
                        {
                            btnok.Visible = true;
                            btntian.Visible = false;
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
            Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
            Maticsoft.Model.ComPanyInfo commodel1 = combll.GetgonggaoModel(1);
            txtgong.Text = commodel1.Gonggao;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
            Maticsoft.Model.ComPanyInfo commodel = new Maticsoft.Model.ComPanyInfo();
            commodel.Gonggao = txtgong.Text.Trim();
            commodel.GongTime = Convert.ToDateTime(DateTime.Now.ToString());
            commodel.FenleiID = 1;
            combll.Add(commodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息提交成功！')</script>");
            bind();
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtgong.Text = string.Empty;
        }

        protected void btntian_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
            Maticsoft.Model.ComPanyInfo commodel = combll.GetgonggaoModel(1);
            commodel.Gonggao = txtgong.Text.Trim();
            commodel.GongTime = Convert.ToDateTime(DateTime.Now.ToString());
            combll.getupdate(commodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息提交成功！')</script>");
            bind();
        }
    }
}
