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
//下载.net源码到51aspx
namespace Maticsoft.Web.Controls
{
    public partial class buttom : System.Web.UI.UserControl
    {
        public string NowYear { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NowYear = DateTime.Now.Year.ToString();
        }
    }
}