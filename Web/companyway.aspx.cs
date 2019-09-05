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
    public partial class companyway : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Maticsoft.BLL.ComPany companybll = new Maticsoft.BLL.ComPany();
                Maticsoft.Model .ComPany  companymodel = companybll.GetModel(1);
                lblComAddress.Text = companymodel.ComAddress;
                lblComEmail.Text = companymodel.ComEmail;
                lblComFax.Text = companymodel.ComFax;
                lblCompanyNames.Text = companymodel.CompanyNames;
                lblComPhoto.Text = companymodel.ComPhoto;
                lblComwangzhi.Text = companymodel.Comwangzhi;
                lblqq.Text = companymodel.QQ;
                
            }
        }
    }
}
