<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersModify.aspx.cs" Inherits="Maticsoft.Web.Admin.UsersModify" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
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
		  <div class="adminNewslist1">修改用户信息</div>
		  <div class="adminNewslist2">用户列表</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		 <div class="adminNewslist3">
		  <div class="adminNewslist10">用户呢称：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtname" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblusername" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">
              原来密码：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtpass" runat="server" BackColor="White" TextMode="Password"  ></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblpass" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">
              现在密码：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtpassord" runat="server" BackColor="White" TextMode="Password"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblpassword" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">性别：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:DropDownList ID="drpsex" runat="server">
                  <asp:ListItem Value="0">请选择性别</asp:ListItem>
                  <asp:ListItem Value="1">男</asp:ListItem>
                  <asp:ListItem Value="2">女</asp:ListItem>
              </asp:DropDownList>
              <asp:Label ID="lblsex" runat="server" ForeColor="Red"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">联系电话：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtlinkphoto" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblLinkphoto" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">电子邮箱：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtemail" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblemail" runat="server"></asp:Label></span>
		  </div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">QQ/MSN：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtqq" runat="server" BackColor="White"></asp:TextBox>
		  </div>
		</div>
		
		
	   <div class="adminNewslist31">
           <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="提交信息" />
           <asp:Button ID="btncanel" runat="server" OnClick="btncanel_Click" Text="重置信息" /></div>

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
