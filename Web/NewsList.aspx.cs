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
    public partial class NewsList : System.Web.UI.Page
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
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            DataSet ds = typebll.GetAllList();
            datanewsquan.DataSource = ds;
            datanewsquan.DataKeyField = "NewsTypeID";
             datanewsquan.DataBind();
        }

       

        protected void datanewsquan_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
            int index = int.Parse(datanewsquan.DataKeys[e.Item.ItemIndex].ToString());
            //DataSet bllds = newbll.GetList("NewsTypeID="+index+"");
            int pageSize =5;//每页大小
            int page = 1;//当前第几页
            int recordCount;//总共有多少条数据
            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].ToString() != "")
                {
                    page = int.Parse(Request.QueryString["page"].ToString());
                }
            }
            recordCount = newbll.GetNewCount("NewsTypeID="+index+"");
            int pageCount = recordCount / pageSize + 1;//共有多少页
            if (recordCount % pageSize == 0)
            {
                pageCount--;
            }
            DataSet bllds = newbll.GeNewsList(pageSize * (page - 1), pageSize, "NewsTypeID=" + index + "");
            DataList dlNews = e.Item.FindControl("datanewsfen") as DataList;
            dlNews.DataSource = bllds;
            dlNews.DataBind();
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            Maticsoft.Model.NewsTypeInfo typemodel = typebll.GetModel(int.Parse(this.datanewsquan.DataKeys[e.Item.ItemIndex].ToString()));
            Label lbltype = e.Item.FindControl("lbltype") as Label;
            lbltype.Text = typemodel.NewsTypeTitle;
            Label lblpage = e.Item.FindControl("lblpage") as Label;
           
        }
    }
}
