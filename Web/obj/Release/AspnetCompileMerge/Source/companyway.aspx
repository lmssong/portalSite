﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="companyway.aspx.cs" Inherits="Maticsoft.Web.companyway" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-联系方式</title>
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
		   <div class="divjies1">
			 <img src="images/xuan.png" width="15" height="15" />联系我们
			</div>
			<div class="divjies2">
			  <div class="divlink">
			    <div class="divlink1">
				  <div class="divlink11">公司名称：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblCompanyNames" runat="server"></asp:Label>
				  </div>
			    </div>
				<div class="divlink1">
				  <div class="divlink11">公司电话：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblComPhoto" runat="server"></asp:Label> 
				  </div>
			    </div>
				<div class="divlink1">
				  <div class="divlink11">公司传真：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblComFax" runat="server"></asp:Label>
				  </div>
			    </div>
				<div class="divlink1">
				  <div class="divlink11">公司地址：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblComAddress" runat="server"></asp:Label>
				  </div>
			    </div>
				<div class="divlink1">
				  <div class="divlink11">公司邮箱：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblComEmail" runat="server"></asp:Label>
				  </div>
			    </div>
				<div class="divlink1">
				  <div class="divlink11">客服Q Q：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblqq" runat="server"></asp:Label>
				  </div>
			    </div>
				<div class="divlink1">
				  <div class="divlink11">公司网址：</div>
				  <div class="divlink12">
				    <asp:Label ID="lblComwangzhi" runat="server"></asp:Label>
				  </div>
			    </div>
				
				
			  </div>
			  <div class="divlinkphoto">
			    <img src="images/rere.png" />
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