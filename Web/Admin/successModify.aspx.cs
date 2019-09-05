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
    public partial class successModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["SuccessID"] != null)
                        {
                            if (Request.QueryString["SuccessID"].ToString() != null)
                            {
                                bind();
                            }
                            else
                            {
                                Response.Redirect("successList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("successList.aspx");
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
            Maticsoft.BLL.SuccessInfo successbll = new Maticsoft.BLL.SuccessInfo();
            int index = int.Parse(Request.QueryString["SuccessID"].ToString());
            Maticsoft.Model.SuccessInfo successmodel = successbll.GetModel(index);
            txtcontent.Text = successmodel.SuccessContent;
            txtfatime.Text = Convert.ToDateTime(successmodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            txtsuccesstitle.Text = successmodel.SuccessTitle;
            txtwrite.Text = successmodel.Write;
            Image1.Visible = true;
            Image1.ImageUrl = successmodel.ImageURL;
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
            string filepath = "/FileUpload/success/Images/";
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.SuccessInfo successbll = new Maticsoft.BLL.SuccessInfo();
            int index = int.Parse(Request.QueryString["SuccessID"].ToString());
            Maticsoft.Model.SuccessInfo successmodel = successbll.GetModel(index);
            if (txtsuccesstitle.Text.Trim() == "")
            {
                lbltitle.Text = "请填写案例名称";
                return;
            }
            successmodel.SuccessTitle = txtsuccesstitle.Text.Trim();
            lbltitle.Text = "";
            if (txtwrite.Text.Trim() == "")
            {
                lblwrite.Text = "请填写发布人";
                return;
            }
            successmodel.Write = txtwrite.Text.Trim();
            lblwrite.Text = "";
            if (txtfatime.Text.Trim() == "")
            {
                lblfatime.Text = "请填写您的发布时间";
            }
            successmodel.Fatime = Convert.ToDateTime(txtfatime.Text.Trim());
            lblfatime.Text = "";
            successmodel.ImageURL = Image1.ImageUrl;
            successmodel.SuccessContent = txtcontent.Text.Trim();
            successbll.Update(successmodel );
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            bind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtsuccesstitle.Text = string.Empty;
            txtwrite.Text = string.Empty;
            txtfatime.Text = string.Empty;
            txtcontent.Text = string.Empty;
        }
    }
}
