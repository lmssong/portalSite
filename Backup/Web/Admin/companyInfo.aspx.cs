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
    public partial class companyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usename"] != null)
                {
                    if (Session["usename"].ToString() != "")
                    {
                        Maticsoft.BLL.ComPany companybll = new Maticsoft.BLL.ComPany();
                        Maticsoft.Model.ComPany companymodel = companybll.GetModel(1);

                        if (companymodel.CompanyNames == "")
                        {
                            btnadd.Visible = true;
                            btnupadel.Visible = false;

                        }
                        else
                        {
                            btnadd.Visible = false;
                            btnupadel.Visible = true;
                            bind();
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
            Maticsoft.BLL.ComPany combll = new Maticsoft.BLL.ComPany();
            Maticsoft.Model.ComPany commodel = combll.GetModel(1);

            txtcomfaren.Text = commodel.Fanren.ToString();
            txtcomfax.Text = commodel.ComFax;
            txtcompanyname.Text = commodel.CompanyNames;
            txtcompanytype.Text = commodel.CompanyType;
            txtcomphoto.Text = commodel.ComPhoto;
            txtcomwangzhi.Text = commodel.Comwangzhi;
            txtcontent.Text = commodel.comconten;
            txtEmail.Text = commodel.ComEmail;
            txtqq.Text = commodel.QQ;
            txtcomaddress.Text = commodel.ComAddress;

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.ComPany companybll = new Maticsoft.BLL.ComPany();
            Maticsoft.Model.ComPany commodel = new Maticsoft.Model.ComPany();
            if (txtcompanyname.Text.Trim() == "")
            {
                lblconname.Text = "请填写公司名称";
                return;
            }
            lblconname.Text = "";
            commodel.CompanyNames = txtcompanyname.Text.Trim();
            if (txtcompanytype.Text.Trim() == "")
            {
                lbltype.Text = "请填写公司类型";
                return;
            }
            lbltype.Text = "";
            commodel.CompanyType = txtcompanytype.Text.Trim();
            if (txtcomaddress.Text.Trim() == "")
            {
                lbladdress.Text = "请填写公司地址";
                return;
            }
            lbladdress.Text = "";
            commodel.ComAddress = txtcomaddress.Text.Trim();
            if (txtcomfax.Text.Trim() == "")
            {
                lblfax.Text = "请填写公司传真";
                return;
            }
            lblfax.Text = "";
            commodel.ComFax = txtcomfax.Text.Trim();
            if (txtcomfaren.Text.Trim() == "")
            {
                lblfanren.Text = "请填写公司法人代表";
                return;
            }
            lblfanren.Text = "";
            commodel.Fanren = txtcomfaren.Text.Trim();
            if (txtcomphoto.Text.Trim() == "")
            {
                lblphoto.Text = "请填写公司电话";
                return;
            }
            lblphoto.Text = "";
            commodel.ComPhoto = txtcomphoto.Text.Trim();
            if (txtEmail.Text.Trim() == "")
            {
                lblemail.Text = "请填写公司邮箱";
                return;
            }
            lblemail.Text = "";
            commodel.ComEmail = txtEmail.Text.Trim();
            if (txtqq.Text.Trim() == "")
            {
                lblqq.Text = "请填写公司qq或MSN";
                return;
            }
            lblqq.Text = "";
            commodel.QQ = txtqq.Text.Trim();
            if (txtcomwangzhi.Text.Trim() == "")
            {
                lblwangzhi.Text = "请填写公司网址";
                return;
            }
            lblwangzhi.Text = "";
            commodel.Comwangzhi = txtcomwangzhi.Text.Trim();
            if (txtcontent.Text.Trim() == "")
            {
                lblcomcontent.Text = "请填写公司简介";
            }
            lblcomcontent.Text = "";
            commodel.comconten = txtcontent.Text.Trim();
            companybll.Add(commodel);
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('信息添加成功....')</script>");
            txtcomaddress.Text = string.Empty;
            txtcomfaren.Text = string.Empty;
            txtcomfax.Text = string.Empty;
            txtcompanyname.Text = string.Empty;
            txtcompanytype.Text = string.Empty;
            txtcomphoto.Text = string.Empty;
            txtcomwangzhi.Text = string.Empty;
            txtcontent.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtqq.Text = string.Empty;

        }

        protected void btnupadel_Click(object sender, EventArgs e)
        {
            //Maticsoft.BLL.ComPany companybll = new Maticsoft.BLL.ComPany();
            //Maticsoft.Model.ComPany commodel = new Maticsoft.Model.ComPany();
            Maticsoft.BLL.ComPany companybll = new Maticsoft.BLL.ComPany();
            
            Maticsoft.Model.ComPany commodel = companybll.GetModel(1);
            if (txtcompanyname.Text.Trim() == "")
            {
                lblconname.Text = "请填写公司名称";
                return;
            }
            lblconname.Text = "";
            commodel.CompanyNames = txtcompanyname.Text.Trim();
            if (txtcompanytype.Text.Trim() == "")
            {
                lbltype.Text = "请填写公司类型";
                return;
            }
            lbltype.Text = "";
            commodel.CompanyType = txtcompanytype.Text.Trim();
            if (txtcomaddress.Text.Trim() == "")
            {
                lbladdress.Text = "请填写公司地址";
                return;
            }
            lbladdress.Text = "";
            commodel.ComAddress = txtcomaddress.Text.Trim();
            if (txtcomfax.Text.Trim() == "")
            {
                lblfax.Text = "请填写公司传真";
                return;
            }
            lblfax.Text = "";
            commodel.ComFax = txtcomfax.Text.Trim();
            if (txtcomfaren.Text.Trim() == "")
            {
                lblfanren.Text = "请填写公司法人代表";
                return;
            }
            lblfanren.Text = "";
            commodel.Fanren = txtcomfaren.Text.Trim();
            if (txtcomphoto.Text.Trim() == "")
            {
                lblphoto.Text = "请填写公司电话";
                return;
            }
            lblphoto.Text = "";
            commodel.ComPhoto = txtcomphoto.Text.Trim();
            if (txtEmail.Text.Trim() == "")
            {
                lblemail.Text = "请填写公司邮箱";
                return;
            }
            lblemail.Text = "";
            commodel.ComEmail = txtEmail.Text.Trim();
            if (txtqq.Text.Trim() == "")
            {
                lblqq.Text = "请填写公司qq或MSN";
                return;
            }
            lblqq.Text = "";
            commodel.QQ = txtqq.Text.Trim();
            if (txtcomwangzhi.Text.Trim() == "")
            {
                lblwangzhi.Text = "请填写公司网址";
                return;
            }
            lblwangzhi.Text = "";
            commodel.Comwangzhi = txtcomwangzhi.Text.Trim();
            if (txtcontent.Text.Trim() == "")
            {
                lblcomcontent.Text = "请填写公司简介";
            }
            lblcomcontent.Text = "";
            commodel.comconten = txtcontent.Text.Trim();
            companybll.Update(commodel );
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('信息添加成功....')</script>");
            bind();
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtcomaddress.Text = string.Empty;
            txtcomfaren.Text = string.Empty;
            txtcomfax.Text = string.Empty;
            txtcompanyname.Text = string.Empty;
            txtcompanytype.Text = string.Empty;
            txtcomphoto.Text = string.Empty;
            txtcomwangzhi.Text = string.Empty;
            txtcontent.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtqq.Text = string.Empty;
        }

        

         
    }
}
