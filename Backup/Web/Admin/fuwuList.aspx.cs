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
    public partial class fuwuList : System.Web.UI.Page
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
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = fuwubll.GetModel(1);
            DataSet ds = fuwubll.GetAllList();
            datafuwu.DataSource = ds;
            datafuwu.DataKeyField = "fuwuID";
            datafuwu.DataBind();
        }

        protected void datading_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int index = int.Parse(datafuwu.DataKeys[e.Item.ItemIndex].ToString());
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            fuwubll.Delete(index);
            bind();
        }

        protected void datading_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            int index = int.Parse(datafuwu.DataKeys[e.Item.ItemIndex].ToString());
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = fuwubll.GetModel(index);
            Maticsoft .BLL .FuWuTypeInfo typebll=new Maticsoft.BLL.FuWuTypeInfo ();
            Maticsoft.Model.FuWuTypeInfo typemodel = typebll.GetModel(int.Parse(fuwumodel.FuwuTypeID.ToString()));
            ((Label)e.Item.FindControl("lnltype")).Text = typemodel.FuwuTypeName;
        }
    }
}
