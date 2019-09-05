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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        //获得服务器名称
                        this.lServerName.Text = Server.MachineName;
                        //获得服务器IP地址
                        this.lServerIP.Text = Request.ServerVariables["LOCAL_ADDR"].ToString();
                        //获得服务器操作系统版本
                        this.lServerOSVersion.Text = Environment.OSVersion.ToString();
                        //获得服务器IIS版本
                        this.lServerIISVersion.Text = Request.ServerVariables["SERVER_SOFTWARE"];
                        //获得DoNET引擎版本
                        this.lServerDotNETVersion.Text = ".NET CLR" + Environment.Version.Major + "." + Environment.Version.Minor + "." + Environment.Version.Build + "." + Environment.Version.Revision;

                        Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
                        lblnew.Text = newbll.GetNewCount(" Fatime='" + Convert.ToDateTime(DateTime.Now.ToString()) + "'").ToString();
                        Maticsoft.BLL.NicheInfo nichebll = new Maticsoft.BLL.NicheInfo();
                        lblniche.Text = nichebll.GetnicheCount(" Fatime='" + Convert.ToDateTime(DateTime.Now.ToString()) + "'").ToString();
                        Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
                        lblproduct.Text = probll.getproCount(" Fatime='" + Convert.ToDateTime(DateTime.Now.ToString()) + "'").ToString();
                        Maticsoft.BLL.DingProduct dingbll = new Maticsoft.BLL.DingProduct();
                        lblding.Text = dingbll.GetDingCount(" Dingtime='" + Convert.ToDateTime(DateTime.Now.ToString()) + "'").ToString();
                        Maticsoft.BLL.JobZiJianInfo jobbll = new Maticsoft.BLL.JobZiJianInfo();
                        lblzijian.Text = jobbll.GetzijianCount(" datatime='" + Convert.ToDateTime(DateTime.Now.ToString()) + "'").ToString();
                        Maticsoft.BLL.MessageInfo messbll = new Maticsoft.BLL.MessageInfo();
                        lblyijian.Text = messbll.GetmessCount(" DateTime='" + Convert.ToDateTime(DateTime.Now.ToString()) + "'").ToString();









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
    }
}
