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
    public partial class tupian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random(); 
            //这样循环，可以同时上传多个文件。前台已经有文件格式的判断，有错误提示了。这里只要过滤掉非法文件即可，无需提示了。 
            for (int i = 0; i < Request.Files.Count; i++)
            {
                if (Request.Files[i].ContentLength > 0)
                {
                    string ex = System.IO.Path.GetExtension(Request.Files[i].FileName).ToLower();
                    if (".jpg.gif.png.bmp".Contains(ex))
                    {
                        string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + r.Next(100, 999).ToString() + ex;
                        //保存文件名到数据库 
                        //xxxxxxxxxxxxxxxx 
                        //xxxxxxxxxxxxxxxx 

                        Request.Files[i].SaveAs(Server.MapPath(newFileName));
                       // pic = newFileName;
                    }
                }
            }

        }
    }
}
