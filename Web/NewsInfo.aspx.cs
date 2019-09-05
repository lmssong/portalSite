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
    public partial class NewsInfo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["NewsID"] != null )
                {
                    if (Request.QueryString["NewsID"].ToString() != "" )
                    {

                        int newsid = int.Parse(Request.QueryString["NewsID"].ToString());
                        bind( newsid);


                    }
                    else
                    {
                        Response.Redirect("NewsList.aspx");
                    }
                }
                else
                {
                    Response.Redirect("NewsList.aspx");
                }
            }
        }

        private void bind(int newsid)
        {
            Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
            Maticsoft.Model.NewsInfo newmodel = newbll.GetModel(newsid);
            int typeid = int.Parse(newmodel.NewsTypeID.ToString());
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            Maticsoft.Model.NewsTypeInfo typemodel = typebll.GetModel(typeid);
            lblFatime.Text = Convert.ToDateTime(newmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lblNewsContent.Text = newmodel.NewsContent;
            lblNewsTitle.Text = newmodel.NewsTitle;
            lblNewsTypeTitle.Text = typemodel.NewsTypeTitle;
            lblNewsTypeTitle1.Text = typemodel.NewsTypeTitle;
            lblWrite.Text = newmodel.Write;
            imgnews.ImageUrl = newmodel.ImageURL;
        }
    }
}
