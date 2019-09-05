namespace Maticsoft.Web.Controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using LTP.Accounts.Bus;
	using System.Configuration;
	using System.Web.Security;

	/// <summary>
	///	CheckRight 的摘要说明。
	/// </summary>
	public partial class CheckRight : System.Web.UI.UserControl
	{
        protected void Page_Load(object sender, System.EventArgs e)
		{
            if (!IsPostBack)
            {
                lianxibind();
                Maticsoft.BLL.SuccessInfo success = new Maticsoft.BLL.SuccessInfo();
                DataSet successds = success.GetList(6, "", "Fatime desc ");
                datasuess.DataSource = successds;
                datasuess.DataBind();
                Maticsoft.BLL.DingProduct dingbll = new Maticsoft.BLL.DingProduct();
                DataSet dingds = dingbll.GetList(5, "", "Dingtime desc ");
                datading.DataSource = dingds;
                datading.DataBind(); 
            }
		}

        private void lianxibind()
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
