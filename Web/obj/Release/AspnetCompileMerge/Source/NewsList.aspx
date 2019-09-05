<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="Maticsoft.Web.NewsList" %>

<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-企业新闻</title>
    <link href="style/css.css" rel="stylesheet" type="text/css" />
     <link href="style/lanrenxixi.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        
        
        
     <table border ="0" cellpadding ="0" cellspacing ="0" width ="1000">
       <tr>
         <td colspan="2">
           <uc3:top ID="Top1" runat="server" />
         </td>
       </tr>
       <tr>
         <td>
           <%--<uc2:left ID="Left1" runat="server" />--%>
           <div class="divzhong">
     <!--中间内容 -->
	 <div class="divxun">
	  <!--中间内容 -->

         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		 <div class="divjies">
		    <div class="divjies1"><img src="images/xuan.png" width="15" height="15" />新闻动态</div>
			<div class="divjies2">
			  
			 
                <asp:DataList ID="datanewsquan" runat="server" OnItemDataBound="datanewsquan_ItemDataBound">
                  <ItemTemplate>
                     <div class="divNews">
			   <div class="divNewstitle">
			     <img src="images/proe.jpg" />  
                   <asp:Label ID="lbltype" runat="server" Text=<%#Eval("NewsTypeID")%>></asp:Label>
			   </div>
                 <asp:DataList ID="datanewsfen" runat="server">
                  <ItemTemplate>
                   <div class="divNewscontent">
			        <div class="divNewscontent1">
				    <div class="divNewscontent11">
				     <img src="images/news.png" /> <a href="NewsInfo.aspx?NewsID=<%#Eval("NewsID") %> ">  <%#Eval("NewsTitle") %> </a>
				   </div>
				   <div class="divNewscontent12">
				    <%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>
				   </div>
			     </div>
			   </div>
                      <asp:Label ID="lblpage" runat="server" Visible="false"></asp:Label>
                 </ItemTemplate>
               </asp:DataList>
			  </div>
              <div style="height:25px; text-align :center ">
              <asp:Label ID="lblpage" runat="server"></asp:Label>
              </div>
              </ItemTemplate>
             </asp:DataList>
			</div>
		  </div> 
 
      </div>
	  <!--中间内容 -->

	 <!--中间内容 -->
   </div>
           
           
         </td>
       </tr>
       <tr>
         <td>
           <uc1:buttom ID="Buttom1" runat="server" />
         </td>
       </tr>
     </table>
    </div>
    </form>
</body>
</html>
