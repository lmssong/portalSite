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
namespace Maticsoft.Web
{
    public partial class jishu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Maticsoft.BLL.JiShuInfo jishubll = new Maticsoft.BLL.JiShuInfo();
                int recordCount = 0;//总共有多少条数据
                int pageSize = 9;//每页大小
                int page = 1;//当前第几页
                int pagecount;

                if (Request.QueryString["page"] != null)
                {
                    if (Request.QueryString["page"].ToString() != "")
                    {
                        page = int.Parse(Request.QueryString["page"].ToString());
                    }
                }
                recordCount = jishubll.getjishucount();
                int pageCont = recordCount / pageSize + 1;
                if (recordCount % pageSize == 0)
                {
                    pageCont--;
                }
                DataSet ds = jishubll.getjishuList(pageSize * (page - 1), pageSize);
                datajishu.DataSource = ds;
                datajishu.DataKeyField = "JishuID";
                datajishu.DataBind();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.lblpage.Text += "共有<b>" + recordCount + "</b>条记录&nbsp; ";
                    this.lblpage.Text += "当前第<b>" + page + "</b>页&nbsp;&nbsp;";
                    if (page == 1)
                    {
                        this.lblpage.Text += "首页&nbsp;";
                        this.lblpage.Text += "上一页&nbsp;";
                    }
                    else
                    {
                        this.lblpage.Text += "<a href='jishu.aspx?page=" + 1 + " '>首页</a>&nbsp;";
                        this.lblpage.Text += "<a href='jishu.aspx?page=" + (page - 1).ToString() +  " '>上一页</a>&nbsp;";

                    }
                    if (page == pageCont)
                    {
                        this.lblpage.Text += "下一页&nbsp;";
                        this.lblpage.Text += "尾页&nbsp;";
                    }
                    else
                    {
                        this.lblpage.Text += "<a href='jishu.aspx?page=" + (page + 1).ToString() + " '>下一页</a>&nbsp;";
                        this.lblpage.Text += "<a href=jishu.aspx?page=" + pageCont.ToString() + " '>尾页</a>&nbsp;";

                    }
                }




            }
        }

        protected void datajishu_ItemCommand(object source, DataListCommandEventArgs e)
        {//CommandName
            if (e.CommandName == "download")
            {
                int jishuid = int.Parse(e.CommandArgument .ToString ());
                Maticsoft.BLL.JiShuInfo jishubll = new Maticsoft.BLL.JiShuInfo();
                Maticsoft.Model.JiShuInfo jishumodel = jishubll.GetModel(jishuid);
                string fileName = jishumodel.JishuTitle;
                string filePath = Server.MapPath(jishumodel .JishuPath);
                string kzhanming = Path.GetExtension(jishumodel.JishuPath);
                FileInfo fileinfo = new FileInfo(filePath);
                if (fileinfo.Exists == true)
                {
                    const long ChunkSize = 102400;//100K 每次读取文件，只读取100Ｋ，这样可以缓解服务器的压力
                    byte[] buffer = new byte[ChunkSize];
                    Response.Clear();
                    FileStream iSteam = File.OpenRead(filePath);
                    long dataLengthToRead = iSteam.Length;//获取下载的文件总大小
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName)+"."+kzhanming+"");
                    while (dataLengthToRead > 0 && Response.IsClientConnected)
                    {
                        int lengthRead = iSteam.Read(buffer, 0, Convert.ToInt32(ChunkSize));//读取的大小
                        Response.OutputStream.Write(buffer, 0, lengthRead);
                        Response.Flush();
                        dataLengthToRead = dataLengthToRead - lengthRead;
                    }
                    Response.Close();
                }
            }
        }

        protected void datajishu_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            
        }
 
    }
}
