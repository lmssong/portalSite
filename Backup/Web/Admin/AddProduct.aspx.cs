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
    public partial class AddProduct : System.Web.UI.Page
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
                        drpbind();
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
            DataSet typeds = typebll.GetAllList();
            drptype.DataSource = typeds;
            drptype.DataTextField = "ProTypeTitle";
            drptype.DataValueField = "ProTypeID";
            drptype.DataBind();
        }
        private void drpbind()
        {
            Maticsoft.BLL.ProductType typebll = new Maticsoft.BLL.ProductType();
            DataSet typeds = typebll.GetAllList();
            drpaddtypehao.DataSource = typeds;
            drpaddtypehao.DataTextField = "ProTypeTitle";
            drpaddtypehao.DataValueField = "ProTypeID";
            drpaddtypehao.DataBind();
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
            string filepath = "/FileUpload/product/Images/";
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
            Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
            Maticsoft.Model.Product promodel = new Maticsoft.Model.Product();
            if (txtprotitle.Text.Trim() == "")
            {
                lbltitle.Text = "请填写产品名称";
                return;
            }
            promodel.ProName = txtprotitle.Text.Trim();
            lbltitle.Text = "";
            try
            {
                promodel.ProTypeID = int.Parse(drptype.SelectedValue);
            }
            catch (Exception e1)
            { }
            try
            {
                promodel.ProXingID = int.Parse(drpxing.SelectedValue);
            }
            catch (Exception e2)
            { }
            if (txttme.Text.Trim() == "")
            {
                lblprotime.Text = "请填写产品出品时间";
                return;
            }
            promodel.Prochutime = Convert.ToDateTime(txttme.Text.Trim());
            lblprotime.Text = "";
            if (txtfatime.Text.Trim() == "")
            {
                lbltime.Text = "请填写发布时间";
                return;
            }
            promodel.Fatime = Convert.ToDateTime(txtfatime.Text.Trim());
            lbltime.Text = "";
            promodel.ImageURL = Image1.ImageUrl;
            promodel.Toujian = 0;
            promodel.Procontent = txtprocontent.Text.Trim();
            probll.Add(promodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            txtprotitle.Text = string.Empty;
            txttme.Text = string.Empty;
            txtfatime.Text = string.Empty;
            txtprocontent.Text = string.Empty;
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtprotitle.Text = string.Empty;
            txttme.Text = string.Empty;
            txtfatime.Text = string.Empty;
            txtprocontent.Text = string.Empty;
        }

        protected void drptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int drptypeid = int.Parse(drptype.SelectedValue);
            Maticsoft.BLL.ProductXing xingbll = new Maticsoft.BLL.ProductXing();
            DataSet ds = xingbll.GetList(" ProTypeID=" + drptypeid + "");
            drpxing.DataSource = ds;
            drpxing.DataTextField = "ProXingTitle";
            drpxing.DataValueField = "ProXingID";
            drpxing.DataBind(); 
             
        }

        protected void btntype_Click(object sender, EventArgs e)
        {
            if (txtaddtype.Text.Trim() == "")
            {
                lblxinghao.Text = "请填写服务类型";
                return;
            }
            Maticsoft.BLL.FuWuTypeInfo typebll = new Maticsoft.BLL.FuWuTypeInfo();
            Maticsoft.Model.FuWuTypeInfo typemodel = new Maticsoft.Model.FuWuTypeInfo();
            typemodel.FuwuTypeName = txtaddtype.Text.Trim();
            typebll.Add(typemodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<SCRIPT>alert('信息提交成功)</SCRIPT>");
        }

        protected void btntype_Click1(object sender, EventArgs e)
        {
            Maticsoft.BLL.ProductType typebll = new Maticsoft.BLL.ProductType();
            Maticsoft.Model.ProductType typemodel = new Maticsoft.Model.ProductType();
            if (txtaddtype.Text.Trim() == "")
            {
                lblxinghao.Text = "请填写产品类型";
                return;
            }
            typemodel.ProTypeTitle = txtaddtype.Text.Trim();
            lblxinghao.Text = "";
            typebll.Add(typemodel);
            txtaddtype.Text = string.Empty;
            lblxinghao.Text = "产品类型提交成功";

        }

        protected void btnxing_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ProductXing xingbll = new Maticsoft.BLL.ProductXing();
            Maticsoft.Model.ProductXing xingmodel = new Maticsoft.Model.ProductXing();
            xingmodel.ProTypeID = int.Parse(drpaddtypehao.SelectedValue.ToString());
            if (txtaddxinghao.Text.Trim() == "")
            {
                lblxinghao.Text = "请填写产品型号";
                return;
            }
            xingmodel.ProXingTitle = txtaddxinghao.Text.Trim();
            lblxinghao.Text = "";
            xingbll.Add(xingmodel );
            txtaddxinghao.Text = string.Empty;
            lblxinghao.Text = "产品型号提交成功";
           
        }
      
    }
}
