﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsInfo.aspx.cs" Inherits="Maticsoft.Web.Admin.NewsInfo" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
  <div class="admindiv">
    <!--内容部分 -->
	<uc1:top ID ="top1" runat ="server" />
	
	<div class="adminzhong">
	  <!--中部内容 -->
	  <div class="adminleft">
	   <!--左边内容 -->
	    <uc2:left ID="left1" runat ="server" />
	   <!--左边内容 -->
	  </div>
	  
	  <div class="adminright">
	   <!--右边内容 -->
	     <div class="adminrighttit">
	      <div class="adminrighttit1">
		    <a href ="main.aspx" >管理首页</a>
		  </div>
	      <div class="adminrighttit2">
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
	    </div>
	    
	    <div class="adminNewslist">
		  <div class="adminNewslist1">新闻信息 </div>
		  <div class="adminNewslist2">已发布新闻</div>
	    </div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">新闻标题：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltitle" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">关键字：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblkey" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">新闻类型：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltype" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布人：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblwrite" runat="server"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblstarttime" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>新闻图片：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:Image ID="Image1" runat="server" Height="200px" /></div>
		</div>
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>新闻内容：</div>
		  <div class="adminNewslist62">
              <asp:TextBox ID="txtcontent" runat="server" Height="240px" TextMode="MultiLine" Width="386px"></asp:TextBox></div>
		</div>
	    

	    <!--右边内容 -->
	  </div>
	  <!--中部内容 -->
	</div>
	<!--内容部分 -->
  </div>
</div>
    </form>
</body>
</html>
