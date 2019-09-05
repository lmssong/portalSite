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

namespace Maticsoft.Web
{
    public partial class jobInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["JobID"] != null)
                {
                    if (Request.QueryString["JobID"].ToString() != "")
                    {
                        int jobid = int.Parse(Request.QueryString["JobID"].ToString());
                        Maticsoft.BLL.JobInfo jobbll = new Maticsoft.BLL.JobInfo();
                        Maticsoft.Model.JobInfo jobmodel = jobbll.GetModel(jobid);
                        lblAge.Text = jobmodel.Age;
                        lblDuxiang.Text = jobmodel.Duxiang;
                        lblEndtime.Text = Convert.ToDateTime(jobmodel.Endtime.ToString()).ToString("yyyy-MM-dd");
                        lblJobTitle.Text = jobmodel.JobTitle;
                        lblLianxi.Text = jobmodel.Lianxi;
                        lblMiaoshu.Text = jobmodel.Miaoshu;
                        lblMonery.Text = jobmodel.Monery;
                        lblXueli.Text = jobmodel.Xueli;
                        lblZhuanye.Text = jobmodel.Zhuanye;

                    }
                    else
                    {
                        Response.Redirect("job.aspx");
                    }
                }
                else
                {
                    Response.Redirect("job.aspx");
                }
            }
        }
    }
}
