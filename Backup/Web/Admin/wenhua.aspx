<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wenhua.aspx.cs" Inherits="Maticsoft.Web.Admin.wenhua" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
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
		  <div class="adminNewslist1">企业文化 </div>
		  <div class="adminNewslist2"></div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>
		  企业文化：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:TextBox ID="txtwenhua" runat="server" Height="240px" TextMode="MultiLine"
                  Width="398px"></asp:TextBox>*</div>
		</div>
	   <div class="adminNewslist31">
           <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="提交信息" />
           &nbsp;<asp:Button ID="btnupdael" runat="server"  Text="修改信息" OnClick="btnupdael_Click" />
           &nbsp;&nbsp;<asp:Button ID="btncanel" runat="server" OnClick="btncanel_Click" Text="重置信息" /></div>

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
