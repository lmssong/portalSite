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
    public partial class hangyeInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["NicheID"] != null)
                        {
                            if (Request.QueryString["NicheID"].ToString() != "")
                            {
                                bind();
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
            Maticsoft.BLL.NicheInfo nichebll = new Maticsoft.BLL.NicheInfo();
            int index = int.Parse(Request.QueryString["NicheID"].ToString()); 
            Maticsoft.Model.NicheInfo nichemodel = nichebll.GetModel(index );
            Maticsoft.BLL.NicheTypeInfo typebll = new Maticsoft.BLL.NicheTypeInfo();
            Maticsoft.Model.NicheTypeInfo typemodel = typebll.GetModel(int.Parse(nichemodel.NicheTypeID.ToString()));
            lbldatime.Text = Convert.ToDateTime(nichemodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lblkey.Text = nichemodel.NicheKey;
            lblNichetitle.Text = nichemodel.NicheTitle;
            lbltype.Text = typemodel.NicheTypeTitle;
            lblwrite.Text = nichemodel.Write;
            Image1.ImageUrl = nichemodel.ImageURL;
            txtcontent.Text = nichemodel.NicheContent;
        }
    }
}
