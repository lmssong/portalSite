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
    public partial class Addfuwu : System.Web.UI.Page
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
            Maticsoft.BLL.FuWuTypeInfo fuwubll = new Maticsoft.BLL.FuWuTypeInfo();
            DataSet ds = fuwubll.GetAllList();
            DrpFuwuType.DataSource = ds;
            DrpFuwuType.DataTextField = "FuwuTypeName";
            DrpFuwuType.DataValueField = "FuwuTypeID";
            DrpFuwuType.DataBind();
            Image1.Visible = false;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            Maticsoft.Model.FuWuInfo fuwumodel = new Maticsoft.Model.FuWuInfo();
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
            fuwubll.Add(fuwumodel );
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('信息添加成功！')</script>");
            txtFatime.Text = string.Empty;
            txtFuwucontent.Text = string.Empty;
            txtfuwuTitle.Text = string.Empty;
            txtWrite.Text = string.Empty;
            
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtFatime.Text = string.Empty;
            txtFuwucontent.Text = string.Empty;
            txtfuwuTitle.Text = string.Empty;
            txtWrite.Text = string.Empty;
        }

        protected void btnup_Click(object sender, EventArgs e)
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
            string filepath = "/FileUpload/Niche/Images/";
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
            string filepath = "/FileUpload/fuwu/Images/";
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

        protected void btntype_Click(object sender, EventArgs e)
        {
            if (txtaddtype.Text.Trim() == "")
            {
                lbladdtype.Text = "请填写服务类型";
                return;
            }
            Maticsoft.BLL.FuWuTypeInfo typebll = new Maticsoft.BLL.FuWuTypeInfo();
            Maticsoft.Model.FuWuTypeInfo typemodel = new Maticsoft.Model.FuWuTypeInfo();
            typemodel.FuwuTypeName = txtaddtype.Text.Trim();
            typebll.Add(typemodel);
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<SCRIPT>alert('信息提交成功)</SCRIPT>");
        }

         
    }
}
