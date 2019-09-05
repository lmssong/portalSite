using System;
using System.Collections.Generic;
using System.Text;

namespace Maticsoft.BLL
{
    /// <summary>
    /// 分页
    /// url 要跳转的地址，格式如“product.aspx?page=”
    /// pageIndex 当前页下标
    /// pageCount 总页数
    /// count  每次显示页码个数
    /// </summary>
    public class AspNetPage
    {
        public string GetAspNetPage(string url, int pageIndex, int pageCount,int count)
        {
            string strpage = "";
            int size;
            int max;
            int min;
            int i=0;
            min = count / 2;
            max = count - min;
            size = pageIndex + max;
            if (pageCount < size)
            {
               size= pageCount;
            }
            if (pageIndex - min > 0)
            {
                i = pageIndex - min;
            }
            for (; i < size; i++)
            {
                if (i == pageIndex)
                {
                    strpage += "&nbsp;" + (i + 1).ToString() + "&nbsp;&nbsp;";
                }
                else
                {
                    strpage += "<a href='" + url + (i).ToString() + "'>[" + (i + 1).ToString() + "]</a>&nbsp;&nbsp;";
                }
            }
            return strpage;
        }
    }
}
