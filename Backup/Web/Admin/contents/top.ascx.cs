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

namespace Maticsoft.Web.Admin.contents
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                string usename = Session["usename"].ToString();
                lblusename.Text = Server.UrlDecode(usename);
            }
        }

        protected void imetchu_Click(object sender, ImageClickEventArgs e)
        {
            Session.Clear();
        }
    }
}