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
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblyanzheng.Text = CreateRandomCode(5);
             
            }
        }
        protected string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(61);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (txtyan.Text.Trim() != lblyanzheng.Text)
            {
                lblyan.Text = "验证码不正确";
                return;
            }
            string usename = txtusename.Text.Trim();
            string pass = txtpass.Text.Trim();
            Maticsoft.BLL.MemberInfo menbll = new Maticsoft.BLL.MemberInfo();
            Maticsoft.Model.MemberInfo menmodel = menbll.GetpassModel(usename);
            if (menbll.GetExists(usename) == true)
            {
                if (pass != menmodel .Password)
                {
                    lblpass.Text = "密码不正确";
                    return;
                   
                }
                else
                {
                    string urlendel = Server.UrlEncode(usename);
                    Session["usename"] = urlendel;
                    Response.Redirect("main.aspx");
                }
            }
            else
            {
                lblusename.Text = "该用户不存在";
            }


        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("../index.aspx");
        }

       
    }
}
