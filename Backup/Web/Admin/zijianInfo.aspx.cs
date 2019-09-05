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
    public partial class zijianInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["JobInfoID"] != null)
                        {
                            if (Request.QueryString["JobInfoID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("zijianLIst.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("zijianLIst.aspx");
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
            Maticsoft.BLL.JobZiJianInfo zijianbll = new Maticsoft.BLL.JobZiJianInfo();
            int index=int .Parse (Request.QueryString["JobInfoID"].ToString());
            Maticsoft.Model.JobZiJianInfo zijianmodel = zijianbll.GetModel(index);

            lblguanji.Text = zijianmodel.Jiguan;
            try
            {
                lblbrierth.Text = Convert.ToDateTime(zijianmodel.Britday.ToString()).ToString("yyyy-MM-dd");
            }
            catch (Exception e1)
            { }

            lblmonery.Text = zijianmodel.Monery;
            lblname.Text = zijianmodel.Usersname;
            if (zijianmodel.Sex.ToString() == "1")
            {
                lblsex.Text = "先生";
            }
            else if (zijianmodel.Sex.ToString() == "0")
            {
                lblsex.Text = "女士";
            }
            else
            { }
            lblxueli.Text = zijianmodel.Xueli;
            lblzhiwei.Text = zijianmodel.Jobtitle;
            lblzhuanye.Text = zijianmodel.Zhuanye;
            txtjiaoyue.Text = zijianmodel.Jiaoyu;
            txtjingyan.Text = zijianmodel.Jingyan;
            txtpingjia.Text = zijianmodel.Pingjia;
        }
    }
}
