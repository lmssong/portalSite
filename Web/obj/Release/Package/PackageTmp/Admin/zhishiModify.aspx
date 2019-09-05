<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zhishiModify.aspx.cs" Inherits="Maticsoft.Web.Admin.zhishiModify" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>后台管理</title>
    <script type ="text/javascript" src ="js/Calendar1.js" ></script>　
    <link rel="stylesheet" href="style/css.css" type="text/css" />
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
		  <div class="adminNewslist1">修改围栏知识</div>
		  <div class="adminNewslist2">知识列表</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">知识标题：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtzhishititle" runat="server"></asp:TextBox><span style="color: #ff3300">*<asp:Label
                  ID="lbltitle" runat="server"></asp:Label></span></div>
		</div>
		
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">关键字：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtkeyword" runat="server"></asp:TextBox><span style="color: #ff3300">*<asp:Label
                  ID="lblkeyword" runat="server"></asp:Label></span></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtFatime" onfocus="calendar()" runat="server"></asp:TextBox><span
                  style="color: #ff3300">*<asp:Label ID="lblfatime" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布人：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtwrite" runat="server"></asp:TextBox><span style="color: #ff3300">*<asp:Label
                  ID="lblwrite" runat="server"></asp:Label></span></div>
		</div>

		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>知识讲解：</div>
		  <div class="adminNewslist62">
              <asp:TextBox ID="txtcontent" runat="server" Height="230px" TextMode="MultiLine" Width="381px"></asp:TextBox></div>
		</div>
		
		
	   <div class="adminNewslist31">
           &nbsp;<asp:Button ID="btnok" runat="server" Text="提交信息" OnClick="btnok_Click" />&nbsp;<asp:Button ID="btncanel"
               runat="server" OnClick="Button2_Click" Text="重置信息" /></div>

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
