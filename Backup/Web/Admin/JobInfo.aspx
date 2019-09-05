<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobInfo.aspx.cs" Inherits="Maticsoft.Web.Admin.JobInfo" %>

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
	<uc1:top ID="Top1" runat="server" />
	
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
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
		  <div class="adminrighttit2">
		    <a href =main.aspx >管理首页</a>
		  </div>
	    </div>
	    
	    <div class="adminNewslist">
		  <div class="adminNewslist1">招聘信息 </div>
		  <div class="adminNewslist2">已发布新闻</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘职位：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblzhiwei" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">工资地点：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbladdress" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘人数：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblnum" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘时间：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltime" runat="server"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘对象：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblduxiang" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">现在年龄：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblage" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">学历要求：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblxueli" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">薪水待遇：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblmonery" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">专业要求：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblzhuanye" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">结束时间：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblendtime" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist6" style ="height:160px;">
		  <div class="adminNewslist61" style ="height:160px;"><br/>
	      职位描述：</div>
		  <div class="adminNewslist62" style ="height:160px;">
              &nbsp;<asp:TextBox ID="txtmiaoshu" runat="server" BackColor="White" Height="150px"
                  TextMode="MultiLine" Width="405px"></asp:TextBox></div>
		</div>
		
		<div class="adminNewslist6" style ="height:160px;">
		  <div class="adminNewslist61" style ="height:160px;"><br/>
	      联系公司：</div>
		  <div class="adminNewslist62" style ="height:160px;">
              &nbsp;<asp:TextBox ID="txtlianxi" runat="server" BackColor="White" Height="150px"
                  TextMode="MultiLine" Width="405px"></asp:TextBox></div>
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
