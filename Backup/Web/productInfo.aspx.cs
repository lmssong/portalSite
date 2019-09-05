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
    public partial class productInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProID"] != null)
                {
                    if (Request.QueryString["ProID"].ToString() != "")
                    {
                        int proid = int.Parse(Request.QueryString["ProID"].ToString ());
                        Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
                        Maticsoft.Model.Product  promodel = probll.GetModel(proid);
                        Maticsoft .BLL .ProductType typebll=new Maticsoft.BLL.ProductType ();
                        Maticsoft.Model.ProductType typemodel = typebll.GetModel(int.Parse(promodel.ProTypeID.ToString()));
                        Maticsoft .BLL .ProductXing xingbll=new Maticsoft.BLL.ProductXing ();
                        Maticsoft.Model.ProductXing xingmodel = xingbll.GetModel(int.Parse(promodel.ProXingID.ToString()));
                        lblFatime.Text = Convert.ToDateTime(promodel.Fatime.ToString()).ToString("yyyy-MM-dd");
                        int hitnum = 0;
                        if (promodel .HitNum  != null)
                        {
                            promodel.HitNum = promodel.HitNum + 1;
                            probll.Update(promodel);
                            lblHitNum.Text = promodel.HitNum.ToString();
                        }
                        else
                        {
                            promodel.HitNum = 1;
                            probll.Update(promodel);
                            lblHitNum.Text = promodel.HitNum.ToString();
                        }
                        lblProcontent.Text = promodel.Procontent;
                        lblProName.Text = promodel.ProName;
                        lblProName1.Text = promodel.ProName;
                        lblProTypeTitle.Text = typemodel.ProTypeTitle;
                        lblProXingTitle.Text = xingmodel.ProXingTitle;
                        ImgImageURL.ImageUrl = promodel.ImageURL;

                    }
                    else
                    {
                        Response.Redirect("product.aspx"); 
                    }
                }
                else
                {
                    Response.Redirect("product.aspx");
                }
            }
        }
    }
}
