<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dinggouModify.aspx.cs" Inherits="Maticsoft.Web.Admin.dinggouModify" %>

<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" />
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
		    <a href ="main.aspx" >管理首页</a>
		  </div>
	      <div class="adminrighttit2">
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
	    </div>
	    
	    <div class="adminNewslist">
		  <div class="adminNewslist1">修改订购</div>
		  <div class="adminNewslist2">订购列表</div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">用户姓名：</div>
		  <div class="adminNewslist5">
              <asp:TextBox ID="txtUsersName" runat="server" BackColor="White" BorderColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblUsersName" runat="server"></asp:Label></span></div>
		</div>
		
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">用户性别：</div>
		  <div class="adminNewslist5">
              <asp:DropDownList ID="DrpSex" runat="server" BackColor="White">
                  <asp:ListItem Selected="True" Value="2">选择性别</asp:ListItem>
                  <asp:ListItem Value="1">男</asp:ListItem>
                  <asp:ListItem Value="0">女</asp:ListItem>
              </asp:DropDownList>
              <asp:Label ID="Label1" runat="server" ForeColor="#FF3333"></asp:Label></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">用户地址：</div>
		  <div class="adminNewslist5">
		    <asp:TextBox ID="txtDingAddress" runat="server" BackColor="White" BorderColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblDingAddress" runat="server"></asp:Label></span>&nbsp;
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">联系电话：</div>
		  <div class="adminNewslist5">
		    <asp:TextBox ID="txtLinkPhoto" runat="server" BackColor="White" BorderColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblLinkPhoto" runat="server"></asp:Label></span></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">电子邮箱：</div>
		  <div class="adminNewslist5">
		    <asp:TextBox ID="txtDingEmail" runat="server" BackColor="White" BorderColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblDingEmail" runat="server"></asp:Label></span></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品名称：</div>
		  <div class="adminNewslist5">
		    <asp:TextBox ID="txtProName" runat="server" BackColor="White" BorderColor="White" Width="200px"></asp:TextBox><span
                style="color: #ff3333"> *<asp:Label ID="lblProName" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品类型：</div>
		  <div class="adminNewslist5">
              <asp:DropDownList ID="DrpProTypeTitle" runat="server" BackColor="White" AutoPostBack="True" OnSelectedIndexChanged="DrpProTypeTitle_SelectedIndexChanged">
              </asp:DropDownList>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">产品型号：</div>
		  <div class="adminNewslist5">
              <asp:DropDownList ID="DrpProductXing" runat="server" BackColor="White">
              </asp:DropDownList>
              <asp:Label ID="lblxing" runat="server" ForeColor="#FF3300"></asp:Label></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">订购数量：</div>
		  <div class="adminNewslist5">
		    <asp:TextBox ID="txtDingNum" runat="server" BackColor="White" BorderColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblNum" runat="server"></asp:Label></span>
		  </div>
		</div>
		
		
		
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"><br/>订购描述：</div>
		  <div class="adminNewslist62">
		     
		    <asp:TextBox ID="txtDingcontent" runat="server"   TextMode="MultiLine" Width="350px" Height="240px" BackColor="White"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblDingContent" runat="server"></asp:Label></span></div>
		</div>
		
		
	   <div class="adminNewslist31">
           &nbsp;<asp:Button ID="Button1" runat="server" Text="提交信息" OnClick="Button1_Click" />
           &nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="重置信息" OnClick="Button2_Click" />
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
