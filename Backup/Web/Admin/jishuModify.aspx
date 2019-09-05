<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jishuModify.aspx.cs" Inherits="Maticsoft.Web.Admin.jishuModify" %>

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
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
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
		  <div class="adminNewslist1">修改技术资料 </div>
		  <div class="adminNewslist2">技术列表</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		  <div class="adminNewslist3">
		  <div class="adminNewslist10">技术标题：</div>
		  <div class="adminNewslist5">
              <asp:TextBox ID="txtJishuTitle" runat="server" BackColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lbltitle" runat="server"></asp:Label>
              </span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">上传文件：</div>
		  <div class="adminNewslist5">
              <asp:FileUpload ID="upfile" runat="server" />&nbsp;
              <asp:Button ID="btnup" runat="server" OnClick="btnup_Click" Text="上传" />
              <asp:Label ID="lblinfo1" runat="server"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              <asp:TextBox ID="txttime" runat="server" onfocus="calendar()" BackColor="White" Width="200px"></asp:TextBox><span
                  style="color: #ff3333">* 
                  <asp:Label ID="lbltime" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">文件类别：</div>
		  <div class="adminNewslist5">
             <asp:TextBox ID="txtleib" runat="server" BackColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">* 
                  <asp:Label ID="lbltype" runat="server"></asp:Label></span></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10"> 文件图片：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:FileUpload ID="txtFile" runat="server" />
              <asp:Button ID="Button1" runat="server" OnClick="btnup_Click1" Text="上传" />
              <asp:Label ID="lblInfo" runat="server"></asp:Label><br/>　
           </div>  
		</div>
		<div    style="width:720px; height:200px; border-bottom-width: 1px; border-bottom-style: solid; border-bottom-color: #75C8FF;" id ="tu" runat ="server" >
             <div style="float:left; width:190px; height:200px; background-color: #D0E3FF;"> </div>
             <div style="float:left; width:500px;" align="left">
                 <asp:Image ID="Image1" runat="server" Height ="200px"   />
             </div>
          </div> 
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>
		  文件描述：</div>
		  <div class="adminNewslist62">
             <asp:TextBox ID="txtcontent" runat="server" Height="240px" TextMode="MultiLine"  Width="400px" BackColor="White"></asp:TextBox> 
          </div>
		</div>
	   <div class="adminNewslist31">
           &nbsp; &nbsp;&nbsp;<asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="提交信息" />&nbsp;
           &nbsp;<asp:Button ID="btncanel" runat="server" Text="重置信息" OnClick="btncanel_Click" />
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
