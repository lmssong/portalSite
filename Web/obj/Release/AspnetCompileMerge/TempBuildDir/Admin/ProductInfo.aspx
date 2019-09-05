<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="Maticsoft.Web.Admin.ProductInfo" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>-后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" />
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
		  <div class="adminNewslist1">产品信息 </div>
		  <div class="adminNewslist2">已发布新闻</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品标题：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltitle" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品类型：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltype" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品型号：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblxinghao" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产出日期：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblchutime" runat="server"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblstarttime" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>
		  产品图片：</div>
		  <div class="adminNewslist62">
              <asp:Image ID="Image1" runat="server" Height="200px" /></div>
		</div>
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>
		  产品描述：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:TextBox ID="txtcontent" runat="server" Height="240px" TextMode="MultiLine"
                  Width="380px"></asp:TextBox></div>
		</div>
		<div class="adminNewslist3" id ="toujian" runat ="server" >
		  <div class="adminNewslist10">是否推荐：</div>
		  <div class="adminNewslist5">
              &nbsp;
              <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="推荐" />&nbsp;</div>
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
