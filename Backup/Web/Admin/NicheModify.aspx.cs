﻿using System;
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
    public partial class NicheModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        if (Request.QueryString["NicheID"] != null)
                        {
                            if (Request.QueryString["NicheID"].ToString() != "")
                            {
                                drpbind();
                                bind();
                            }
                            else
                            {
                                Response.Redirect("NicheList.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("NicheList.aspx");
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
            Maticsoft.BLL.NicheInfo nichebll = new Maticsoft.BLL.NicheInfo();
            int index = int.Parse(Request.QueryString["NicheID"].ToString()); 
            Maticsoft.Model.NicheInfo nichemodel = nichebll.GetModel(index);
            txtfatime.Text = Convert.ToDateTime(nichemodel.Fatime.ToString()).ToString("yyyy-MM-dd");
            Image1.ImageUrl = nichemodel.ImageURL;
            txtKeyword.Text = nichemodel.NicheKey;
            txtNichecontent.Text = nichemodel.NicheContent;
            txtNichetitle.Text = nichemodel.NicheTitle;
            txtwrote.Text = nichemodel.Write;
            drpNicheType.SelectedValue = nichemodel.NicheTypeID.ToString();
        }

        private void drpbind()
        {
            Maticsoft.BLL.NicheTypeInfo typebll = new Maticsoft.BLL.NicheTypeInfo();
            DataSet typeds = typebll.GetAllList();
            drpNicheType.DataSource = typeds;
            drpNicheType.DataTextField = "NicheTypeTitle";
            drpNicheType.DataValueField = "NicheTypeID";
            drpNicheType.DataBind();
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

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.NicheInfo nichebll = new Maticsoft.BLL.NicheInfo();
            Maticsoft.Model.NicheInfo nichemodel = nichebll.GetModel(1);
            if (txtNichetitle.Text.Trim() == "")
            {
                lblNicheTitle.Text = "请填写行业标题";
                return;
            }
            nichemodel.NicheTitle = txtNichetitle.Text.Trim();
            lblNicheTitle.Text = "";
            if (txtKeyword.Text.Trim() == "")
            {
                lblKeyword.Text = "请填写关键词";
                return;
            }
            nichemodel.NicheKey = txtKeyword.Text.Trim();
            lblKeyword.Text = "";
            try
            {
                nichemodel.NicheTypeID = int.Parse(drpNicheType.SelectedValue);
            }
            catch (Exception e1)
            { }
            if (txtwrote.Text.Trim() == "")
            {
                lblNichewrite.Text = "请填写发布人";
                return;
            }
            nichemodel.Write = txtwrote.Text.Trim();
            lblNichewrite.Text = "";
            if (txtfatime.Text.Trim() == "")
            {
                lblfatime.Text = "请填写发布时间";
            }
            nichemodel.Fatime = Convert.ToDateTime(txtfatime.Text.Trim());
            lblfatime.Text = "";
            nichemodel.ImageURL = Image1.ImageUrl;

            nichemodel.NicheContent = txtNichecontent.Text.Trim();
            nichebll.Update(nichemodel);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功！')</script>");
            bind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtfatime.Text = string.Empty;
            txtKeyword.Text = string.Empty;
            txtNichecontent.Text = string.Empty;
            txtNichetitle.Text = string.Empty;
            txtwrote.Text = string.Empty;
        }
    }
}
