<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="companyInfo.aspx.cs" Inherits="Maticsoft.Web.Admin.companyInfo" %>

<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" /> 
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
		  <div class="adminNewslist1">企业信息</div>
		  <div class="adminNewslist2"></div>
	    </div>
		 
		<div class="adminNewslist3">
		  <div class="adminNewslist10">公司名称：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcompanyname" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblconname" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">企业类型：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcompanytype" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lbltype" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">公司地址：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcomaddress" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lbladdress" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">公司传真：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcomfax" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblfax" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">公司法人：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcomfaren" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblfanren" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">公司电话：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcomphoto" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblphoto" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">电子邮箱：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblemail" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">客 服 QQ/MSN：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtqq" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblqq" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">公司网址：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtcomwangzhi" runat="server"></asp:TextBox><span style="color: #ff3333">*</span><asp:Label
                  ID="lblwangzhi" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>公司简介：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:TextBox ID="txtcontent" runat="server" Height="240px" TextMode="MultiLine" Width="380px"></asp:TextBox><span
                  style="color: #ff3333">*</span><asp:Label ID="lblcomcontent" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
	   <div class="adminNewslist31">
           <asp:Button ID="btnadd" runat="server"   Text="添加信息" OnClick="btnadd_Click" />&nbsp;
           <asp:Button ID="btnupadel" runat="server"   Text="修改信息" OnClick="btnupadel_Click" />&nbsp;
           <asp:Button ID="btncanel" runat="server"  Text="重置信息" OnClick="btncanel_Click" /></div>

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
