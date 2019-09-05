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
    public partial class Adddinggou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        bind();
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
            Maticsoft.BLL.ProductType typebll = new Maticsoft.BLL.ProductType();
            DataSet ds = typebll.GetAllList();
            DrpProTypeTitle.DataSource = ds;
            DrpProTypeTitle.DataTextField = "ProTypeTitle";
            DrpProTypeTitle.DataValueField = "ProTypeID";
            DrpProTypeTitle.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtDingAddress.Text = string.Empty;
            txtDingcontent.Text = string.Empty;
            txtDingEmail.Text = string.Empty;
            txtDingtime.Text = string.Empty;
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

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.DingProduct dingbll = new Maticsoft.BLL.DingProduct();
            Maticsoft.Model.DingProduct dingmodel= new Maticsoft.Model.DingProduct();
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
            lblDingContent.Text ="";
            if (txtDingEmail.Text.Trim() == "")
            {
                lblDingEmail.Text = "请填写订购邮箱！";
                return;
            }
            dingmodel.DingEmail = txtDingEmail.Text.Trim();
            lblDingEmail.Text ="";
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
            Label1.Text ="";
            if (txtDingtime.Text.Trim() == "")
            {
                lblDatatime.Text = "请填写订购时间";
                return;
            }
            dingmodel.Dingtime = Convert.ToDateTime(txtDingtime.Text.Trim());
            lblDatatime.Text ="";
            if (txtLinkPhoto.Text.Trim() == "")
            {
                lblLinkPhoto.Text = "请填写您的电话";
                return;
            }
            dingmodel.LinkPhoto = txtLinkPhoto.Text.Trim();
            lblLinkPhoto.Text ="";
            if (txtProName.Text.Trim() == "")
            {
                lblProName.Text = "请填写产品名称！";
                return;
            }
            dingmodel.ProName = txtProName.Text.Trim();lblProName.Text ="";
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
                dingbll.Add(dingmodel);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            }
            
            txtDingAddress.Text = string.Empty;
            txtDingcontent.Text = string.Empty;
            txtDingEmail.Text = string.Empty;
            txtDingtime.Text = string.Empty;
            txtLinkPhoto.Text = string.Empty;
            txtProName.Text = string.Empty;
            txtUsersName.Text = string.Empty;

        }
    }
}
