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

namespace Maticsoft.Web
{
    public partial class rencai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.JobZiJianInfo jobbll = new Maticsoft.BLL.JobZiJianInfo();
            Maticsoft.Model.JobZiJianInfo jobmodel = new Maticsoft.Model.JobZiJianInfo();
            if (txtUsersname.Text.Trim() == "")
            {
                lblusername.Text = "请填写您的姓名..";
                return;
            }
            jobmodel.Usersname = txtUsersname.Text.Trim();
            lblusername.Text = "";
            if (txtJobTitleName.Text.Trim() == "")
            {
                lnljobtitle.Text = "请填写您应聘的职位..";
                return;
            }
            jobmodel.Jobtitle = txtJobTitleName.Text.Trim();
            lnljobtitle.Text = "";
            if (drpSex.SelectedValue != "1" && drpSex.SelectedValue != "0")
            {
                lblsex.Text = "请选择您的性别..";
                return;
            }
            else
            {
                jobmodel.Sex = int.Parse(drpSex.SelectedValue.ToString());
                lblsex.Text = "";
                
            }
            if (txtXueli.Text.Trim() == "")
            {
                lblxueli.Text = "请天谢谢您的学历";
                return;
            }
            lblxueli.Text = "";
            jobmodel.Xueli = txtXueli.Text.Trim();
            if (txtJiguan.Text.Trim() == "")
            {
                lbljiguan.Text = "请填写您的籍贯";
                return;
            }
            jobmodel.Jiguan = txtJiguan.Text.Trim();
            lbljiguan.Text = "";
            if (txtBritday.Text.Trim() == "")
            {
                lblbriendy.Text = "请填写您的出生年月..";
                return;
            }
            lblbriendy.Text = "";
            jobmodel.datatime = Convert.ToDateTime(DateTime.Now.ToString());
            jobmodel.Britday = Convert.ToDateTime(txtBritday.Text.Trim());
            if (txtZhuanye.Text.Trim() == "")
            {
                lnlzhuangye.Text = "请填写您的专业...";
                return;
            } 
            lnlzhuangye.Text = "";
            jobmodel.Zhuanye = txtZhuanye.Text.Trim();
            
            jobmodel.Jiaoyu = txtJiaoyu.Text.Trim();
            jobmodel.Jingyan = txtJingyan.Text.Trim();
            jobmodel.Pingjia = txtPingjia.Text.Trim();
            jobbll.Add(jobmodel );
            Page.ClientScript.RegisterStartupScript(this .GetType (),"","<script>alert('信息添加成功..')</script>");
            txtBritday.Text = string.Empty;
            txtJiaoyu.Text = string.Empty;
            txtJiguan.Text = string.Empty;
            txtJingyan.Text = string.Empty;
            txtJobTitleName.Text = string.Empty;
            txtPingjia.Text = string.Empty;
            txtUsersname.Text = string.Empty;
            txtXueli.Text = string.Empty;
            txtZhuanye.Text = string.Empty;
        }

        protected void btncanel_Click(object sender, EventArgs e)
        {
            txtBritday.Text = string.Empty;
            txtJiaoyu.Text = string.Empty;
            txtJiguan.Text = string.Empty;
            txtJingyan.Text = string.Empty;
            txtJobTitleName.Text = string.Empty;
            txtPingjia.Text = string.Empty;
            txtUsersname.Text = string.Empty;
            txtXueli.Text = string.Empty;
            txtZhuanye.Text = string.Empty;
        }
    }
}
