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
    public partial class fuwuInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["fuwuID"] != null)
                {
                    if (Request.QueryString["fuwuID"].ToString() != "")
                    {
                        int fuwuID = int.Parse(Request.QueryString["fuwuID"].ToString());
                        bind(fuwuID);
                    }
                    else
                    {
                        Response.Redirect("fuwu.aspx");
                    }
                }
                else
                {
                    Response.Redirect("fuwu.aspx");
                }
            }
        }

        private void bind(int fuwuID)
        {
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = fuwubll.GetModel(fuwuID);
            Maticsoft.BLL.FuWuTypeInfo typebll = new Maticsoft.BLL.FuWuTypeInfo();
            Maticsoft.Model.FuWuTypeInfo typemodel = typebll.GetModel(int.Parse(fuwumodel.FuwuTypeID.ToString()));
            lblFatime.Text = Convert.ToDateTime(fuwumodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lblFuwucontent.Text = fuwumodel.Fuwucontent;
            lblWrite.Text = fuwumodel.Write;
            lblFuwuTypeName.Text = typemodel.FuwuTypeName;
            lbltitle.Text = fuwumodel.fuwuTitle;
            

        }
    }
}
