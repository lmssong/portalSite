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
    public partial class jieshao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Maticsoft.BLL.ComPany combll = new Maticsoft.BLL.ComPany();
                int maxid = combll.GetMaxId()-1;
                Maticsoft.Model.ComPany commodel = combll.GetModel(maxid);
                lblComPanyContent.Text = commodel.comconten;
            }
        }
    }
}
