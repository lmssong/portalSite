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
    public partial class left1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                Maticsoft.BLL.WeiLanInfo weilanbll = new Maticsoft.BLL.WeiLanInfo();
                DataSet weilands = weilanbll.GetList(6, "", " Fatime desc");
                datazhishi.DataSource = weilands;
                datazhishi.DataBind();
                Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
                DataSet fuwuds = fuwubll.GetList(6, "", "Fatime desc");
                datafuwu.DataSource = fuwuds;
                datafuwu.DataBind();
            }
        }

        private void bind()
        {
            Maticsoft.BLL.ComPany companybll = new Maticsoft.BLL.ComPany();
            int maxid = companybll.GetMaxId() - 1;
            Maticsoft.Model.ComPany companymodel = companybll.GetModel(maxid);
            lblComEmail.Text = companymodel.ComEmail;
            lblComFax.Text = companymodel.ComFax;
            lblCompanyNames.Text = companymodel.CompanyNames;
            lblComPhoto.Text = companymodel.ComPhoto;
            lblFanren.Text = companymodel.Fanren;
        }
    }
}