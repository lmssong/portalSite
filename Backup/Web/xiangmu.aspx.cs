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
    public partial class xiangmu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {

            Maticsoft.BLL.ZiXunInfo zixunbll = new Maticsoft.BLL.ZiXunInfo();
            int pageSize = 15;//每页大小
            int page = 1;//当前第几页
            int recordCount;//总共有多少条数据
           if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].ToString() != "")
                {
                    page = int.Parse(Request.QueryString["page"].ToString());
                }
            }
            recordCount = zixunbll.GetzixunCount("ZiXundaan is not null");
            int pageCount = recordCount / pageSize + 1;//共有多少页
            if (recordCount % pageSize == 0)
            {
                pageCount--;
            }
            DataSet ds = zixunbll.GetzixunList(pageSize * (page - 1), pageSize, "ZiXundaan is not null");
            datazixun.DataSource = ds;
            datazixun.DataBind();
            if (ds.Tables[0].Rows.Count > 0)
            {

                this.lblpage.Text += "共有<b>" + recordCount + "</b>条记录&nbsp; ";
                this.lblpage.Text += "当前第<b>" + page + "</b>页&nbsp;&nbsp;";
                if (page == 1)
                {
                    this.lblpage.Text += "首页&nbsp;";
                    this.lblpage.Text += "上一页&nbsp;";
                }
                else
                {
                    this.lblpage.Text += "<a href='xiangmu.aspx?page=" + 1 + " '>首页</a>&nbsp;";
                    this.lblpage.Text += "<a href='xiangmu.aspx?page=" + (page - 1).ToString() + "  '>上一页</a>&nbsp;";

                }
                if (page == pageCount)
                {
                    this.lblpage.Text += "下一页&nbsp;";
                    this.lblpage.Text += "尾页&nbsp;";
                }
                else
                {
                    this.lblpage.Text += "<a href='xiangmu.aspx?page=" + (page + 1).ToString() + "  '>下一页</a>&nbsp;";
                    this.lblpage.Text += "<a href='xiangmu.aspx?page=" + pageCount.ToString() + " '>尾页</a>&nbsp;";

                }

            }

        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ZiXunInfo zixunbll = new Maticsoft.BLL.ZiXunInfo();
            Maticsoft.Model.ZiXunInfo zixunmodel = new Maticsoft.Model.ZiXunInfo();
            zixunmodel.zixuncontent = txtcontent.Text.Trim();
            if (txtusename.Text.Trim() == "")
            {
                lblusename.Text = "请填写用户名称..";
                return;
            }
            zixunmodel.zixunUserName = txtusename.Text.Trim();
            lblusename.Text ="";
            if (txttitle.Text.Trim() == "")
            {
                lnltitle.Text = "请填写提问标题..";
                return;
            }
            zixunmodel.zixunTitle = txttitle.Text.Trim();
            lnltitle.Text = "";
            if (txtlinphoto.Text.Trim() == "")
            {
                lbllinkphoto.Text = "请填写您的联系方式..";
            }
            lbllinkphoto.Text = "";
            zixunmodel.zixunuserPhoto = txtlinphoto.Text.Trim();
            zixunmodel.zixuntime = Convert.ToDateTime(DateTime .Now .ToString ());
            zixunbll.Add(zixunmodel);
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('提交信息成功！！')</script>");
            bind();
            txtcontent.Text = string.Empty;
            txtlinphoto.Text = string.Empty;
            txttitle.Text = string.Empty;
            txtusename.Text = string.Empty;
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtcontent.Text = string.Empty;
            txtlinphoto.Text = string.Empty;
            txttitle.Text = string.Empty;
            txtusename.Text = string.Empty;
        }
    }
}
