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
using System.IO;
namespace Maticsoft.Web.Admin
{
    public partial class fuwuModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["fuwuID"] != null)
                {
                    if (Request.QueryString["fuwuID"].ToString() != "")
                    {
                        drpbind();
                        bind();
                    }
                    else
                    {
                        Response.Redirect("fuwuList.aspx");
                    }
                }
                else
                {
                    Response.Redirect("fuwuList.aspx");
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
            int fuwuid = int.Parse(Request.QueryString["fuwuID"].ToString());
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = fuwubll.GetModel(fuwuid);
            txtFatime.Text = Convert.ToDateTime(fuwumodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            Image1.ImageUrl = fuwumodel.ImageURL;
            txtFuwucontent.Text = fuwumodel.Fuwucontent;
            txtfuwuTitle.Text = fuwumodel.fuwuTitle;
            txtWrite.Text = fuwumodel.Write;
            DrpFuwuType.SelectedValue = fuwumodel.FuwuTypeID.ToString();
        }

        private void drpbind()
        {
            Maticsoft.BLL.FuWuTypeInfo fuwubll = new Maticsoft.BLL.FuWuTypeInfo();
            DataSet ds = fuwubll.GetAllList();
            DrpFuwuType.DataSource = ds;
            DrpFuwuType.DataTextField = "FuwuTypeName";
            DrpFuwuType.DataValueField = "FuwuTypeID";
            DrpFuwuType.DataBind();
            Image1.Visible = false;
        }

        protected void btnup_Click1(object sender, EventArgs e)
        {
            if (txtFile.HasFile)//判断是否上传了文件
            {
                lblInfo.Text = "请您选择您要上传的文件..";
            }
            string filetext = Path.GetExtension(txtFile.PostedFile.FileName).ToLower();
            if (filetext != ".jpg" && filetext != ".gif" && filetext != ".png")
            {
                lblInfo.Text = "上传的文件只能是*.jpg,*.gif,*.png格式的..";
                return;
            }
            if (txtFile.PostedFile.ContentLength > 1000 * 1024)
            {
                lblInfo.Text = "上传的文件必须小于1000KB..";
                return;
            }
            string strfilename = "(" + Guid.NewGuid().ToString() + ")" + filetext;
            string filepath = "/FileUpload/News/Images/";
            string datatime = DateTime.Now.ToString("yyyyMMdd");
            string path = filepath + datatime + "/";
            if (Directory.Exists(Server.MapPath(path)) == false)
            {
                Directory.CreateDirectory(Server.MapPath(path));
            }
            txtFile.SaveAs(Server.MapPath(path + "/" + strfilename));
            lblInfo.Text = "文件上传成功..";
            tu.Visible = true;
            Image1.ImageUrl = path + strfilename;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = fuwubll.GetModel(1);
            if (txtfuwuTitle.Text.Trim() == "")
            {
                lblfuwutitle.Text = "请填写服务标题！";
                return;
            }
            fuwumodel.fuwuTitle = txtfuwuTitle.Text.Trim();
            lblfuwutitle.Text = "";
            if (txtFatime.Text.Trim() == "")
            {
                lblfuwutime.Text = "请填写服务发布时间！";
                return;
            }
            fuwumodel.Fatime = Convert.ToDateTime(txtFatime.Text.Trim());
            lblfuwutime.Text = "";
            fuwumodel.Fuwucontent = txtFuwucontent.Text.Trim();

            fuwumodel.FuwuTypeID = DrpFuwuType.SelectedIndex + 1;
            tu.Visible = true;
            fuwumodel.ImageURL = Image1.ImageUrl;
            if (txtWrite.Text.Trim() == "")
            {
                lblfuwuwrite.Text = "请填写发布人！";
                return;
            }
            fuwumodel.Write = txtWrite.Text.Trim();
            lblfuwuwrite.Text = "";
            fuwubll.Update(fuwumodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            bind();
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtFatime.Text = string.Empty;
            txtFuwucontent.Text = string.Empty;
            txtfuwuTitle.Text = string.Empty;
            txtWrite.Text = string.Empty;
        }
    }
}
