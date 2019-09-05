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
    public partial class NicheInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["NicheID"] != null)
                {
                    if (Request.QueryString["NicheID"].ToString ()!="")
                    {
                        int nicheid = int.Parse(Request.QueryString["NicheID"].ToString());
                        Maticsoft.BLL.NicheInfo nichebll = new Maticsoft.BLL.NicheInfo();
                        Maticsoft.Model.NicheInfo  nichemodel = nichebll.GetModel(nicheid);
                        Maticsoft .BLL .NicheTypeInfo typebll=new Maticsoft.BLL.NicheTypeInfo ();
                        Maticsoft.Model.NicheTypeInfo typemodel = typebll.GetModel(int.Parse(nichemodel.NicheTypeID.ToString()));
                        lblFatime.Text = Convert.ToDateTime(nichemodel .Fatime .ToString ()).ToString("yyyy-MM-dd");
                        lblNicheContent.Text = nichemodel.NicheContent;
                        lblNicheTitle.Text = nichemodel.NicheTitle;
                        lblNicheTypeTitle.Text = typemodel.NicheTypeTitle;
                        lblWrite.Text = nichemodel.Write;
                        
                    }
                    else
                    {
                        Response.Redirect("NicheList.aspx");
                    }
                }
                else
                {
                    Response.Redirect("NicheList.aspx");
                }
            }
        }
    }
}
