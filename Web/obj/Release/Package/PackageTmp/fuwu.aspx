<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fuwu.aspx.cs" Inherits="Maticsoft.Web.fuwu" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-服务项目</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
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

        <div class="content2">
         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		 <div class="divjies">
		    <div class="divjies1">
			 <img src="images/xuan.png" width="15" height="15" />企业服务</div>
			<div class="divjies2">
                <asp:DataList ID="dalistfuwu" runat="server" RepeatColumns="3">
                 <ItemTemplate >
                   <div class="divfuwubian">
				  <div class="divfuwu1">
				    <img src="images/3.jpg" width="70" height="80" />
				  </div>
				  <div class="divfuwu2">
				    <div class="divfuwu21">
				    名称：<a href="fuwuInfo.aspx?fuwuID=<%#Eval("fuwuID") %>" > 
				    <%# GetCut(Eval("fuwuTitle"),16)%>
				    </a></div>
					<div class="divfuwu22">
					 <%# GetCut(Eval("Fuwucontent"),60)%>
					</div>
				  </div>
			    </div>
                 </ItemTemplate>
                </asp:DataList>
			  
			  
			  
			  
		    </div>
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
