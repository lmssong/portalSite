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
    public partial class successInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["SuccessID"] != null)
                {
                    if (Request.QueryString["SuccessID"].ToString() != "")
                    {
                        int successid = int.Parse(Request.QueryString["SuccessID"].ToString());
                        Maticsoft.BLL.SuccessInfo success = new Maticsoft.BLL.SuccessInfo();
                        Maticsoft.Model.SuccessInfo successmodel = success.GetModel(successid);
                        lblFatime.Text = Convert.ToDateTime(successmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
                        int hitnum = 0;
                        if (successmodel.HitNum != null)
                        {
                            successmodel.HitNum = successmodel.HitNum + 1;
                            success.Update(successmodel);
                            lblHitNum.Text = successmodel.HitNum.ToString();
                        }
                        else
                        {
                            successmodel.HitNum =  1;
                            success.Update(successmodel);
                            lblHitNum.Text = successmodel.HitNum.ToString();
                        }
                        lbllblSuccessTitle1.Text = successmodel.SuccessTitle;
                        lblSuccessContent.Text = successmodel.SuccessContent;
                        lblSuccessTitle.Text = successmodel.SuccessTitle;
                        lblWrite.Text = successmodel.Write;
                        ImgImageURL.ImageUrl = successmodel.ImageURL;
                        
                    }
                    else
                    {
                        Response.Redirect("success.aspx");
                    }
                }
                else
                {
                    Response.Redirect("success.aspx");
                }
            
            }
        }
    }
}
