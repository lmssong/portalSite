<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NicheList.aspx.cs" Inherits="Maticsoft.Web.NicheList" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-商业资讯</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div align="center">
     <table border ="0" cellpadding ="0" cellspacing ="0" width ="1000">
       <tr>
         <td>
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
	  <div class="cell">
        <div class="up1">
        </div>
        <div class="up2">
        </div>
        <div class="up3">
        </div>
        <div class="content2">
         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		 <div class="divjies">
		    <div class="divjies1"><img src="images/xuan.png" width="15" height="15" />行业资讯</div>
			<div class="divjies2">
			  
			  <div class="divNews">
			   
			   <div class="divNewscontent" style="text-align: center">
                <asp:DataList ID="dataniche" runat="server">
                  <ItemTemplate>
                   <div class="divNewscontent1">
				    <div class="divNewscontent11">
				     <img src="images/news.png" /> <a href="NicheInfo.aspx?NicheID=<%#Eval("NicheID") %>"><%#Eval("NicheTitle") %></a>
				    </div>
				   <div class="divNewscontent12"> 
				     (<%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>)
				   </div>
			       </div>
                  </ItemTemplate>
                </asp:DataList> 
                   <asp:Label ID="lblpage" runat="server" Font-Size="9pt"></asp:Label>
			   </div>
			  </div>
			   </div>
			  </div>
        </div>
        <div class="down1">
        </div>
        <div class="down2">
        </div>
        <div class="down3">
        </div>
      </div>
	  <!--中间内容 -->
	 </div>
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
