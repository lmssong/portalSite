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
    public partial class JobInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["JobID"] != null)
                        {
                            if (Request.QueryString["JobID"].ToString() != "")
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("JobList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("JobList.aspx");
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
            Maticsoft.BLL.JobInfo jobbll = new Maticsoft.BLL.JobInfo();
            int jobid = int.Parse(Request.QueryString["JobID"].ToString());
            Maticsoft.Model.JobInfo jobmodel = jobbll.GetModel(jobid);
            lbladdress.Text = jobmodel.Address;
            lblage.Text = jobmodel.Age;
            lblduxiang.Text = jobmodel.Duxiang;
            lblendtime.Text = Convert.ToDateTime(jobmodel.Endtime.ToString()).ToString("yyyy-MM-dd");
            lblmonery.Text = jobmodel.Monery;
            lblnum.Text = jobmodel.Nunber;
            lbltime.Text = Convert.ToDateTime(jobmodel.Starttime.ToString()).ToString("yyyy-MM-dd");
            lblxueli.Text = jobmodel.Xueli;
            lblzhiwei.Text = jobmodel.JobTitle;
            lblzhuanye.Text = jobmodel.Zhuanye;
            txtlianxi.Text = jobmodel.Lianxi;
            txtmiaoshu.Text = jobmodel.Miaoshu;
        }
    }
}
