<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zijianInfo.aspx.cs" Inherits="Maticsoft.Web.Admin.zijianInfo" %>
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
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
		  <div class="adminrighttit2">
		    <a href =main.aspx >管理首页</a>
		  </div>
	    </div>
	    
	    <div class="adminNewslist">
		  <div class="adminNewslist1">个人应聘信息 </div>
		  <div class="adminNewslist2">
              个人应聘列表</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">个人姓名：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblname" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘职位：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblzhiwei" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">性别：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblsex" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">学历：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblxueli" runat="server"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">籍贯：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblguanji" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">出生日期：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblbrierth" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">所学专业：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblzhuanye" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">薪水待遇：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:Label ID="lblmonery" runat="server"></asp:Label></div>
		</div>
		
		<div class="adminNewslist6" style="height:160px;">
		  <div class="adminNewslist61" style="height:160px;"><br/>
	      教育经历：</div>
		  <div class="adminNewslist62" style="height:160px;">
              &nbsp;<asp:TextBox ID="txtjiaoyue" runat="server" Height="150px" TextMode="MultiLine"
                  Width="380px"></asp:TextBox>*</div>
		</div>
		
		<div class="adminNewslist6" style="height:160px;">
		  <div class="adminNewslist61" style="height:160px;"><br/>
	      工资经验：</div>
		  <div class="adminNewslist62" style="height:160px;">
              &nbsp;<asp:TextBox ID="txtjingyan" runat="server" Height="150px" TextMode="MultiLine"
                  Width="380px"></asp:TextBox>*</div>
		</div>
		
		<div class="adminNewslist6" style="height:160px;">
		  <div class="adminNewslist61" style="height:160px;"><br/>
	      自我评价：</div>
		  <div class="adminNewslist62" style="height:160px;">
              &nbsp;<asp:TextBox ID="txtpingjia" runat="server" Height="150px" TextMode="MultiLine"
                  Width="380px"></asp:TextBox>*</div>
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
