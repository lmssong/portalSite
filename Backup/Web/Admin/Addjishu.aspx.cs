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
    public partial class Addjishu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                if (Session["usename"].ToString() != "")
                {
                    
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

        protected void btnup_Click(object sender, EventArgs e)//上传文件
        {
            bool typeOK = true; // 允许上传的类型

            if (upfile.HasFile) // 判断是否上传了文件
            {
                // 获取上传文件的后缀名
                string fileExtension = System.IO.Path.GetExtension(upfile.FileName).ToLower();
                // 禁止上传的文件类型枚举
                string[] denyFileType = {".dll"};

                for (int i = 0; i < denyFileType.Length; i++)
                {
                    if (fileExtension == denyFileType[i])
                    {
                        typeOK = false;
                    }
                }

                if (typeOK)
                {
                    // 指定上传文件在服务器上的保存路径
                    string savePath = Server.MapPath("~/upload/");
                    // 检查服务器上是否存在这个物理路径，如果不存在则创建
                    if (!System.IO.Directory.Exists(savePath))
                    {
                        // 这个路径应该在网站之下，而不是将网站部署在 C 盘，却把上传文件保存在 D 盘
                        System.IO.Directory.CreateDirectory(savePath);
                    }
                    savePath = savePath + "\\" + upfile.FileName;
                    upfile.SaveAs(savePath); // 保存文件

                    // 客户端访问指定的是 URL 地址，而不是服务器上的物理地址
                    lblinfo1.Text = upfile.FileName;
                     
                }
                else
                {
                    lblinfo1.Text = "不能上传.dll文件";
                }
            }
        }

        
        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.JiShuInfo jishubll = new Maticsoft.BLL.JiShuInfo();
            Maticsoft.Model.JiShuInfo jishumodel = new Maticsoft.Model.JiShuInfo();
            if (txtJishuTitle.Text.Trim() == null)
            {
                lbltitle.Text = "请填写文件名称";
                return;
            }
            jishumodel.JishuTitle = txtJishuTitle.Text.Trim();
            lbltitle.Text = "";
            jishumodel.JishuPath = lblinfo1.Text;
            if (txttime.Text.Trim() == null)
            {
                lbltime.Text = "请填写发布时间";
                return;
            }
            lbltime.Text = "";
            jishumodel.Fatime = Convert.ToDateTime(txttime .Text .Trim ());
            if (txtleib.Text.Trim() == null) 
            {
                lbltype.Text = "请填写文件类别";
                return;
            }
            lbltype.Text = "";
            jishumodel.jishuType = txtleib.Text.Trim();
            jishumodel.ImageURL = Image1.ImageUrl;
            jishumodel.Jishucontent = txtcontent.Text.Trim();
            jishubll.Add(jishumodel);
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('信息提交成功')</script>");
            txtcontent.Text = string.Empty;
            txtJishuTitle.Text = string.Empty;
            txtleib.Text = string.Empty;
            txttime.Text = string.Empty;
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
            string filepath = "/FileUpload/jishu/Images/";
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

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtcontent.Text = string.Empty;
            txtJishuTitle.Text = string.Empty;
            txtleib.Text = string.Empty;
            txttime.Text = string.Empty;
        }
    }
}
