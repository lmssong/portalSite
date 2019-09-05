﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addsuccess.aspx.cs" Inherits="Maticsoft.Web.Admin.Addsuccess" %>

<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" />
    <script type ="text/javascript" src ="js/Calendar1.js" ></script>　
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
	     <uc2:left ID="Left1" runat="server" />
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
		  <div class="adminNewslist1">添加成功案例 </div>
		  <div class="adminNewslist2">已发布案例</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">案例名称：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtsuccesstitle" runat="server" BackColor="White"></asp:TextBox><span style="color: #ff3333">*<asp:Label
                  ID="lbltitle" runat="server"></asp:Label>
              </span>
		  </div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布人：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtwrite" runat="server" BackColor="White"></asp:TextBox><span style="color: #ff3333">*<asp:Label
                  ID="lblwrite" runat="server"></asp:Label>
              </span>&nbsp;</div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtfatime" runat="server"　onfocus="calendar()" BackColor="White"></asp:TextBox><span style="color: #ff3333">*<asp:Label
                  ID="lblfatime" runat="server"></asp:Label>
              </span>&nbsp;</div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品图片：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:FileUpload ID="txtFile" runat="server" BackColor="White" />
              <asp:Button ID="btnup" runat="server" OnClick="btnup_Click1" Text="上传" />
              <asp:Label ID="lblInfo" runat="server"></asp:Label><br/>　
           </div>  
		</div>
		<div visible ="false"  style="width:720px; height:200px; border-bottom-width: 1px; border-bottom-style: solid; border-bottom-color: #75C8FF;" id ="tu" runat ="server" >
             <div style="float:left; width:190px; height:200px; background-color: #D0E3FF;"> </div>
             <div style="float:left; width:500px;" align="left">
             <asp:Image ID="Image1" runat="server" Height ="200px" BackColor="White"   />
             </div>
          </div> 
		
		
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>
		  案例描述：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:TextBox ID="txtcontent" runat="server" BackColor="White" Height="230px"
                  TextMode="MultiLine" Width="399px"></asp:TextBox></div>
		</div>
	   <div class="adminNewslist31">
           &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交信息" />
           &nbsp;
           <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="重置信息" />
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
