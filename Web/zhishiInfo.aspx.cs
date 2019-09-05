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
    public partial class zhishiInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["WeiID"] != null)
                {
                    if (Request.QueryString["WeiID"].ToString() != "")
                    {
                        int weilanid = int.Parse(Request.QueryString["WeiID"].ToString());
                        bind(weilanid);
                    }
                    else
                    {
                        Response.Redirect("zhishi.aspx");
                    }
                }
                else
                {
                    Response.Redirect("zhishi.aspx");
                }
            }
        }

        private void bind( int weilanid)
        {
            Maticsoft.BLL.WeiLanInfo weilanbll = new Maticsoft.BLL.WeiLanInfo();
            Maticsoft.Model.WeiLanInfo weilanmodel = weilanbll.GetModel(weilanid);
            lblFatime.Text = Convert.ToDateTime(weilanmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            lblWeicontent.Text = weilanmodel.Weicontent;
            lblWeiTitle.Text = weilanmodel.WeiTitle;
            lblWrite.Text = weilanmodel.Write;
            if (weilanmodel.HitNum == null)
            {
                int hitnum = 0;
                hitnum += 1;
                weilanmodel.HitNum = hitnum;
                weilanbll.Update(weilanmodel);
                lblhitnum.Text = hitnum.ToString();
            }
            else
            {
                int hitnum = int.Parse(weilanmodel.HitNum.ToString());
                hitnum += 1;
                weilanmodel.HitNum = hitnum;
                weilanbll.Update(weilanmodel);
                lblhitnum.Text = hitnum.ToString();
            }
        }
    }
}
