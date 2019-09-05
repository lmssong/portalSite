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
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
                int recordCount = 0;//总共有多少条数据
                int pageSize =12;//每页大小
                int page = 1;//当前第几页
                int pagecount;

                if (Request.QueryString["page"] != null)
                {
                    if (Request.QueryString["page"].ToString() != "")
                    {
                        page = int.Parse(Request.QueryString["page"].ToString());
                    }
                }
                recordCount = probll.getproCount("" );
                int pageCont = recordCount / pageSize + 1;
                if (recordCount % pageSize == 0)
                {
                    pageCont--;
                }
                DataSet ds = probll.getproList(pageSize * (page - 1), pageSize,"" );
                datapro.DataSource = ds;
                datapro.DataKeyField = "ProID";
                datapro.DataBind();
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
                        this.lblpage.Text += "<a href='product.aspx?page=" + 1 + "  '>首页</a>&nbsp;";
                        this.lblpage.Text += "<a href='product.aspx?page=" + (page - 1).ToString() + " '>上一页</a>&nbsp;";

                    }
                    if (page == pageCont)
                    {
                        this.lblpage.Text += "下一页&nbsp;";
                        this.lblpage.Text += "尾页&nbsp;";
                    }
                    else
                    {
                        this.lblpage.Text += "<a href='product.aspx?page=" + (page + 1).ToString() + " '>下一页</a>&nbsp;";
                        this.lblpage.Text += "<a href='product.aspx?page=" + pageCont.ToString() + " '>尾页</a>&nbsp;";

                    }

                }

            }
        }
        //分割字符串
        public static string GetCut(object obj, int n)
        {
            ///
            ///格式化字符串长度，超出部分显示省略号,区分汉字跟字母。汉字2个字节，字母数字一个字节
            ///
            string str = obj.ToString();
            string temp = string.Empty;
            if (System.Text.Encoding.Default.GetByteCount(str) <= n)//如果长度比需要的长度n小,返回原字符串
            {
                return str;
            }
            else
            {
                int t = 0;
                char[] q = str.ToCharArray();
                for (int i = 0; i < q.Length && t < n; i++)
                {
                    if ((int)q[i] >= 0x4E00 && (int)q[i] <= 0x9FA5)//是否汉字
                    {
                        temp += q[i];
                        t += 2;
                    }
                    else
                    {
                        temp += q[i];
                        t++;
                    }
                }
                return (temp + ".");
            }
        }

        protected void datapro_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Maticsoft.BLL.Product pronll = new Maticsoft.BLL.Product();
                int proid = int.Parse(datapro.DataKeys[e.Item.ItemIndex].ToString());
                Maticsoft.Model.Product promodel = pronll.GetModel(proid);
                Maticsoft.BLL.ProductType typebll = new Maticsoft.BLL.ProductType();
                Maticsoft.BLL.ProductXing xingbll = new Maticsoft.BLL.ProductXing();
                int typeid = int.Parse(promodel.ProTypeID.ToString());
                int xingid = int.Parse(promodel.ProXingID.ToString());
                Maticsoft.Model.ProductType typemodel = typebll.GetModel(typeid);
                Maticsoft.Model.ProductXing xingmodel = xingbll.GetModel(xingid);
                ((Label)e.Item.FindControl("lnlProXingID")).Text  = xingmodel.ProXingTitle;
                ((Label)e.Item.FindControl("lblProTypeID")).Text  = typemodel.ProTypeTitle;
            }
        }
    }
}
