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
    public partial class AddJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                if (Session["usename"].ToString() != "")
                {
                   
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.JobInfo jobbll = new Maticsoft.BLL.JobInfo();
            Maticsoft.Model.JobInfo jobmodel = new Maticsoft.Model.JobInfo();
            if (txtJobTitleName.Text.Trim() == "")
            {
                lbljobtitle.Text = "请填写应聘职位";
                return;
            }
            jobmodel.JobTitle = txtJobTitleName.Text.Trim();
            lbljobtitle.Text = "";
            if (txtAddress.Text.Trim() == "")
            {
                lblAddress.Text = "请填写工作地址";
                return;
            }
            jobmodel.Address = txtAddress.Text.Trim();
            lblAddress.Text = "";
            if (txtNunber.Text.Trim() == "")
            {
                lblNumber.Text = "请填写您招聘人数";
                return;
            }
            jobmodel.Nunber = txtNunber.Text.Trim();
            lblNumber.Text = "";
            if (txttime.Text.Trim() == "")
            {
                lblstarttime.Text = "请填写招聘时间";
                return;
            }
            jobmodel.Starttime = Convert.ToDateTime(txttime.Text.Trim());
            lblstarttime.Text = "";
            if (txtduxiang.Text.Trim() == "")
            {
                lblduxiang.Text = "填写招聘对象";
                return;
            }
            jobmodel.Duxiang = txtduxiang.Text.Trim();
            lblduxiang.Text = "";
            if (txtage.Text.Trim() == "")
            {
                lblage.Text = "请填写应聘者年龄";
                return;
            }
            jobmodel.Age = txtage.Text.Trim();
            lblage.Text = "";
            if (txtxueli.Text.Trim() == "")
            {
                lblxueli.Text = "请填写学历要求";
                return;
            }
            jobmodel.Xueli = txtxueli.Text.Trim();
            lblxueli.Text = "";
            if (txtmonery.Text.Trim() == "")
            {
                lblmonery.Text = "请填写薪水要求";
                return;
            }
            jobmodel.Monery = txtmonery.Text.Trim();
            lblmonery.Text = "";
            if (txtzhuangye.Text.Trim() == "")
            {
                lblzhuanye.Text = "请填写专业要求";
                return;
            }
            jobmodel.Zhuanye = txtzhuangye.Text.Trim();
            lblzhuanye.Text = "";
            if (txtEndtime.Text.Trim() == "")
            {
                lblEndtime.Text = "请填写结束时间";
                return;
            }
            jobmodel.Endtime = Convert.ToDateTime(txtEndtime.Text.Trim());
            lblEndtime.Text = "";
            jobmodel.Miaoshu = txtmiaoshu.Text.Trim();
            jobmodel.Lianxi = txtlink.Text.Trim();
            jobbll.Add(jobmodel );

            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtAddress.Text = string.Empty;
            txtage.Text = string.Empty;
            txtduxiang.Text = string.Empty;
            txtEndtime.Text = string.Empty;
            txtJobTitleName.Text = string.Empty;
            txtlink.Text = string.Empty;
            txtmiaoshu.Text = string.Empty;
            txtmonery.Text = string.Empty;
            txtNunber.Text = string.Empty;
            txttime.Text = string.Empty;
            txtxueli.Text = string.Empty;
            txtzhuangye.Text = string.Empty;
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtage.Text = string.Empty;
            txtduxiang.Text = string.Empty;
            txtEndtime.Text = string.Empty;
            txtJobTitleName.Text = string.Empty;
            txtlink.Text = string.Empty;
            txtmiaoshu.Text = string.Empty;
            txtmonery.Text = string.Empty;
            txtNunber.Text = string.Empty;
            txttime.Text = string.Empty;
            txtxueli.Text = string.Empty;
            txtzhuangye.Text = string.Empty;
        }
    }
}
