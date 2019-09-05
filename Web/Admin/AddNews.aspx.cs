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
//下载.net源码到51aspx
namespace Maticsoft.Web.Admin
{
    public partial class AddNews : System.Web.UI.Page
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
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            DataSet typeds = typebll.GetAllList();
            drpNewsType.DataSource = typeds;
            drpNewsType.DataTextField = "NewsTypeTitle";
            drpNewsType.DataValueField = "NewsTypeID";
            drpNewsType.DataBind();
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
            Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
            Maticsoft.Model.NewsInfo newmodel = new Maticsoft.Model.NewsInfo();
            if (txtNewsTitle.Text.Trim() == "")
            {
                lblNewsTitle.Text = "请填写新闻标题";
                return;
            }
            newmodel.NewsTitle = txtNewsTitle.Text.Trim();
            lblNewsTitle.Text = "";
            if (txtKeyword.Text.Trim() == "")
            {
                lblkeyword.Text = "请填写新闻关键字";
                return;
            }
            newmodel.NewsKey = txtKeyword.Text.Trim();
            lblkeyword.Text = "";

            newmodel.NewsTypeID = int.Parse(drpNewsType.SelectedValue);
            if (txtwrite.Text.Trim() == "")
            {
                lblwrite.Text = "请填写新闻发布人";
                return;
            }
            newmodel.Write = txtwrite.Text.Trim();
            lblwrite.Text = "";
            newmodel.Fatime = Convert.ToDateTime(txtfatime.Text.Trim());
            newmodel.ImageURL = Image1.ImageUrl; 
            newmodel.NewsContent = txtNewContent.Text.Trim();
            newbll.Add(newmodel );
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtNewsTitle.Text = "";
            txtKeyword.Text = "";
            txtwrite.Text = "";
            txtfatime.Text = "";
            txtNewContent.Text = "";
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtNewsTitle.Text = "";
            txtKeyword.Text = "";
            txtwrite.Text = "";
            txtfatime.Text = "";
            txtNewContent.Text = "";
        }

        protected void btntype_Click(object sender, EventArgs e)
        {
            if (txtaddtype.Text.Trim() == "")
            {
                lbladdtype.Text = "请填写新闻类型";
                return;
            }
            Maticsoft.BLL.NewsTypeInfo typebll = new Maticsoft.BLL.NewsTypeInfo();
            Maticsoft.Model.NewsTypeInfo typemodel = new Maticsoft.Model.NewsTypeInfo();
            typemodel.NewsTypeTitle  = txtaddtype.Text.Trim();
            typebll.Add(typemodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<SCRIPT>alert('信息提交成功)</SCRIPT>");
        }

       
    }
}
