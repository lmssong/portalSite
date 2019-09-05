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
    public partial class successList : System.Web.UI.Page
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
            Maticsoft.BLL.SuccessInfo successbll = new Maticsoft.BLL.SuccessInfo();
            int recordCount = 0;//总共有多少条数据
            int pageSize = 9;//每页大小
            int page = 1;//当前第几页
            int pagecount;

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].ToString() != "")
                {
                    page = int.Parse(Request.QueryString["page"].ToString());
                }
            }
            recordCount = successbll.getsuccessCount("");
            int pageCont = recordCount / pageSize + 1;
            if (recordCount % pageSize == 0)
            {
                pageCont--;
            }
            DataSet ds = successbll.getsuccessList(pageSize * (page - 1), pageSize, "");
            datasuccess.DataSource = ds;
            datasuccess.DataBind();
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
                    this.lblpage.Text += "<a href='success.aspx?page=" + 1 + " & FenleiID=" + 3 + "" + " '>首页</a>&nbsp;";
                    this.lblpage.Text += "<a href='success.aspx?page=" + (page - 1).ToString() + " & FenleiID=" + 3 + "" + " '>上一页</a>&nbsp;";

                }
                if (page == pageCont)
                {
                    this.lblpage.Text += "下一页&nbsp;";
                    this.lblpage.Text += "尾页&nbsp;";
                }
                else
                {
                    this.lblpage.Text += "<a href='success.aspx?page=" + (page + 1).ToString() + " & FenleiID=" + 3 + "" + " '>下一页</a>&nbsp;";
                    this.lblpage.Text += "<a href='success.aspx?page=" + pageCont.ToString() + " & FenleiID=" + 3 + "" + " '>尾页</a>&nbsp;";

                }
            }
        }

        protected void datasuccess_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int index = int.Parse(datasuccess.DataKeys[e.Item.ItemIndex].ToString());
            Maticsoft.BLL.SuccessInfo nichebll = new Maticsoft.BLL.SuccessInfo();
            nichebll.Delete(index);
            lblpage.Text = "";
            bind();
        }
    }
}
