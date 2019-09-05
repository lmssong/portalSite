﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tupian.aspx.cs" Inherits="Maticsoft.Web.Admin.tupian" %>

<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <script type ="text/javascript" src ="js/Calendar1.js" ></script>　
</head>
<body>
    <form id="form1" runat="server">
     <div align="center">
  <div class="admindiv">
    <!--内容部分 -->
	<uc1:top ID="top1" runat ="server" />
	
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
		  <div class="adminNewslist1">修改成功案例 </div>
		  <div class="adminNewslist2">已发布案例</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		　<div class="adminNewslist3">
		  <div class="adminNewslist10">
              首页商标图片1：</div>
		  <div class="adminNewslist5">
              &nbsp;</div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">
              首页商标图片2：</div>
		  <div class="adminNewslist5">
              &nbsp;</div>
		 </div>
		 <div class="adminNewslist3">
		  <div class="adminNewslist10">
              首页商标图片3：</div>
		  <div class="adminNewslist5">
              &nbsp;</div>
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
