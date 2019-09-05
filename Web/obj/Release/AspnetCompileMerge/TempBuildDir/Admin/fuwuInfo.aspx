<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fuwuInfo.aspx.cs" Inherits="Maticsoft.Web.Admin.fuwuInfo" %>

<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        
    
    </div>
    
    <div align="center">
  <div class="admindiv">
    <!--内容部分 -->
	<uc1:top ID="Top1" runat="server" />
	
	<div class="adminzhong">
	  <!--中部内容 -->
	  <div class="adminleft">
	   <!--左边内容 -->
	   <uc2:left ID="Left1" runat="server" />
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
		  <div class="adminNewslist1">服务资料 </div>
		  <div class="adminNewslist2">服务列表</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">服务标题：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltitle" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">服务类型：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lbltype" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblfatime" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布人：</div>
		  <div class="adminNewslist5">
              <asp:Label ID="lblfaren" runat="server"></asp:Label></div>
		</div>
		
		<div visible ="false"  style="width:720px; height:200px; border-bottom-width: 1px; border-bottom-style: solid; border-bottom-color: #75C8FF;" id ="tu" runat ="server" >
             <div style="float:left; width:190px; height:200px; background-color: #D0E3FF; text-align: right;"> 服务图片：</div>
             <div style="float:left; width:500px;" align="left">
                 &nbsp;<asp:Image ID="Image1" runat="server" Height ="200px"   />
             </div>
          </div> 
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>
		  服务描述：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:TextBox ID="txtFuwucontent" runat="server" BackColor="White" Height="238px"
                  TextMode="MultiLine" Width="405px"></asp:TextBox>*</div>
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
