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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                Maticsoft.BLL.ComPanyInfo combll = new Maticsoft.BLL.ComPanyInfo();
                Maticsoft.Model.ComPanyInfo commodel = combll.GetgonggaoModel(1);
                lblgonggao.Text = commodel.Gonggao;

            }
        }

        private void bind()
        {
            Maticsoft.BLL.NewsInfo newbll = new Maticsoft.BLL.NewsInfo();
            DataSet newds = newbll.GetList(7, "", " Fatime desc ");
            datanews.DataSource = newds;
            datanews.DataBind();
            Maticsoft.BLL.NicheInfo nichebll = new Maticsoft.BLL.NicheInfo();
            DataSet nicheds = nichebll.GetList(6, "", "Fatime desc");
            dataniche.DataSource = nicheds;
            dataniche.DataBind();
            Maticsoft.BLL.Product probll = new Maticsoft.BLL.Product();
            DataSet prods = probll.GetList(4, "", " Fatime desc");
            datapro.DataSource = prods;
            datapro.DataBind();
            Maticsoft.BLL.WeiLanInfo weilanbll = new Maticsoft.BLL.WeiLanInfo();
            DataSet weilands = weilanbll.GetList(6, "", " Fatime desc ");
            dataweilan.DataSource = weilands;
            dataweilan.DataBind();
            DataSet toujiands = probll.GetList(4, " Toujian=1 ", "  Fatime desc");
            datatoujian.DataSource = toujiands;
            datatoujian.DataBind();
            Maticsoft.BLL.ZiXunInfo zixunbll = new Maticsoft.BLL.ZiXunInfo();
            DataSet zixunds = zixunbll.GetList(6, "ZiXundaan is not null", " zixuntime desc ");
            dataxiangmo.DataSource = zixunds;
            dataxiangmo.DataBind();
            Maticsoft.BLL.JiShuInfo jishubll = new Maticsoft.BLL.JiShuInfo();
            DataSet jishuds = jishubll.GetList(6, "", " Fatime desc ");
            datajishu.DataSource = jishuds;
            datajishu.DataBind();
            Maticsoft.BLL.FuWuInfo fuwubll = new Maticsoft.BLL.FuWuInfo();
            DataSet fuwuds = fuwubll.GetList(6, "", "  Fatime desc ");
            datafuwu.DataSource = fuwuds;
            datafuwu.DataBind();
        }
    }
}
