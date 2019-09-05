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
    public partial class dinggouModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["DingID"] != null)
                        {
                            if (Request.QueryString["DingID"].ToString() != "")
                            {
                                drpbind();
                                bind();
                            }
                            else
                            {
                                Response.Redirect("dinggouList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("dinggouList.aspx");
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
            Maticsoft.BLL.DingProduct dingbll = new Maticsoft.BLL.DingProduct();
            int dingid = int.Parse(Request.QueryString["DingID"].ToString());
            Maticsoft.Model.DingProduct dingmodel = dingbll.GetModel(dingid);
            txtDingAddress.Text = dingmodel.DingAddress;
            txtDingcontent.Text = dingmodel.Dingcontent;
            txtDingEmail.Text = dingmodel.DingEmail;
            txtDingNum.Text = dingmodel.DingNum;
             
            txtLinkPhoto.Text = dingmodel.LinkPhoto;
            txtProName.Text = dingmodel.ProName;
            txtUsersName.Text = dingmodel.UsersName;
            DrpProductXing.SelectedValue = dingmodel.ProXingID.ToString();
            DrpProTypeTitle.SelectedValue = dingmodel.ProTypeID.ToString();
            DrpSex.SelectedValue = dingmodel.DingSex.ToString();
        }

        private void drpbind()
        {
            Maticsoft.BLL.ProductType typebll = new Maticsoft.BLL.ProductType();
            DataSet ds = typebll.GetAllList();
            DrpProTypeTitle.DataSource = ds;
            DrpProTypeTitle.DataTextField = "ProTypeTitle";
            DrpProTypeTitle.DataValueField = "ProTypeID";
            DrpProTypeTitle.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.DingProduct dingbll = new Maticsoft.BLL.DingProduct();
            int dingid = int.Parse(Request.QueryString["DingID"].ToString());
            Maticsoft.Model.DingProduct dingmodel = dingbll.GetModel(dingid);
            if (txtUsersName.Text.Trim() == "")
            {
                lblUsersName.Text = "请填写用户名！";
                return;
            }
            dingmodel.UsersName = txtUsersName.Text.Trim();
            lblUsersName.Text = "";
            if (txtDingAddress.Text.Trim() == "")
            {
                lblDingAddress.Text = "请您填写订货地址！";
                return;
            }
            dingmodel.DingAddress = txtDingAddress.Text.Trim();
            lblDingAddress.Text = "";
            if (txtDingcontent.Text.Trim() == "")
            {
                lblDingContent.Text = "请填写订购描述！";
                return;

            }
            dingmodel.Dingcontent = txtDingcontent.Text.Trim();
            lblDingContent.Text = "";
            if (txtDingEmail.Text.Trim() == "")
            {
                lblDingEmail.Text = "请填写订购邮箱！";
                return;
            }
            dingmodel.DingEmail = txtDingEmail.Text.Trim();
            lblDingEmail.Text = "";
            if (txtDingNum.Text.Trim() == "")
            {
                lblNum.Text = "请填写订购数量！";
                return;
            }
            dingmodel.DingNum = txtDingNum.Text.Trim();
            lblNum.Text = "";
            if (DrpSex.SelectedValue == "2")
            {
                Label1.Text = "请选择性别";
                return;
            }
            dingmodel.DingSex = DrpSex.SelectedIndex;
            Label1.Text = "";

            dingmodel.Dingtime = Convert.ToDateTime(DateTime.Now.ToString());
            
            if (txtLinkPhoto.Text.Trim() == "")
            {
                lblLinkPhoto.Text = "请填写您的电话";
                return;
            }
            dingmodel.LinkPhoto = txtLinkPhoto.Text.Trim();
            lblLinkPhoto.Text = "";
            if (txtProName.Text.Trim() == "")
            {
                lblProName.Text = "请填写产品名称！";
                return;
            }
            dingmodel.ProName = txtProName.Text.Trim(); lblProName.Text = "";
            dingmodel.ProTypeID = int.Parse(DrpProTypeTitle.SelectedValue);
            if (DrpProductXing.SelectedValue == "")
            {
                lblxing.Text = "请选择您的产品型号";
                return;
            }
            else
            {
                dingmodel.ProXingID = int.Parse(DrpProductXing.SelectedValue);
                lblxing.Text = "";
                dingbll.Update(dingmodel);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
                bind();
            }
             
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtDingAddress.Text = string.Empty;
            txtDingcontent.Text = string.Empty;
            txtDingEmail.Text = string.Empty;
             
            txtLinkPhoto.Text = string.Empty;
            txtProName.Text = string.Empty;
            txtUsersName.Text = string.Empty;
        }

        protected void DrpProTypeTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int drptypeid = int.Parse(DrpProTypeTitle.SelectedValue);
            Maticsoft.BLL.ProductXing xingbll = new Maticsoft.BLL.ProductXing();
            DataSet ds = xingbll.GetList(" ProTypeID=" + drptypeid + "");
            DrpProductXing.DataSource = ds;
            DrpProductXing.DataTextField = "ProXingTitle";
            DrpProductXing.DataValueField = "ProXingID";
            DrpProductXing.DataBind(); 
        }
    }
}
