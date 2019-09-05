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
    public partial class NewsLIst : System.Web.UI.Page
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
            Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
            int recordCount = 0;//总共有多少条数据
            int pageSize = 20;//每页大小
            int page = 1;//当前第几页
            int pagecount;

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].ToString() != "")
                {
                    page = int.Parse(Request.QueryString["page"].ToString());
                }
            }
            recordCount = newbll.GetNewCount("");
            int pageCont = recordCount / pageSize + 1;
            if (recordCount % pageSize == 0)
            {
                pageCont--;
            }
            DataSet ds = newbll.GeNewsList(pageSize * (page - 1), pageSize, "");
            datamess.DataSource = ds;
            datamess.DataKeyField = "NewsID";
            datamess.DataBind();
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
                    this.lblpage.Text += "<a href='NewsLIst.aspx?page=" + 1 + " '>首页</a>&nbsp;";
                    this.lblpage.Text += "<a href='NewsLIst.aspx?page=" + (page - 1).ToString() + " '>上一页</a>&nbsp;";

                }
                if (page == pageCont)
                {
                    this.lblpage.Text += "下一页&nbsp;";
                    this.lblpage.Text += "尾页&nbsp;";
                }
                else
                {
                    this.lblpage.Text += "<a href='NewsLIst.aspx?page=" + (page + 1).ToString() + " '>下一页</a>&nbsp;";
                    this.lblpage.Text += "<a href='NewsLIst.aspx?page=" + pageCont.ToString() + " '>尾页</a>&nbsp;";

                }
            }
        }

       　

        protected void datamess_DeleteCommand1(object source, DataListCommandEventArgs e)
        {
            int index = int.Parse(datamess.DataKeys[e.Item.ItemIndex].ToString());
            Maticsoft.BLL.NewsInfo jobbll = new Maticsoft.BLL.NewsInfo();
            jobbll.Delete(index);
            lblpage.Text = "";
            bind();
        }

        protected void datamess_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            int index = int.Parse(datamess.DataKeys[e.Item.ItemIndex].ToString());
            Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
            Maticsoft.Model.NewsInfo newmodel = newbll.GetModel(index);
            int typeid = int.Parse(newmodel.NewsTypeID.ToString ());
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            Maticsoft.Model.NewsTypeInfo typemodel = typebll.GetModel(typeid);
            ((Label)e.Item.FindControl("lbltype")).Text = typemodel.NewsTypeTitle;

        }
    }
}
