﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Maticsoft.Web.Admin.login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理系统</title>
     <link href="style/style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <div  align="center" style="background-color: #175C7B;" >
  <div  style="padding-top :150px; padding-bottom :150px; width:440px; height:260px;background-image: url(images/denglu.jpg);background-repeat: no-repeat;
	background-position: center center;">
    <table width="440" border="0" cellpadding="0" cellspacing="0" id="divmaintable1">
      <tr>
        <td width="170" height="90">&nbsp;</td>
        <td width="120">&nbsp;</td>
        <td width="150">&nbsp;</td>
      </tr>
      <tr>
        <td align="right">
            <span style="font-size: 9pt">用户名：</span></td>
        <td height="25">
            <asp:TextBox ID="txtusename" runat="server"></asp:TextBox></td>
        <td style="text-align: left">&nbsp;<asp:RequiredFieldValidator ID="fileusename" runat="server" ControlToValidate="txtusename"
                ErrorMessage="用户名不能为空"></asp:RequiredFieldValidator>
            <asp:Label ID="lblusename" runat="server" ForeColor="#FF3300"></asp:Label></td>
      </tr>

      <tr>
        <td align="right">
            <span style="font-size: 9pt">密 码：</span></td>
        <td height="25" style="text-align: left">
            <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
        <td style="text-align: left">&nbsp;<asp:RequiredFieldValidator ID="filepass" runat="server" ErrorMessage="密码不能为空" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
            <asp:Label ID="lblpass" runat="server" ForeColor="#FF3300"></asp:Label></td>
      </tr>
      <tr>
        <td width="170" align="right" style="height: 25px">
            <span style="font-size: 9pt">验证码：</span></td>
        <td  align="left" style="height: 25px">
            <asp:TextBox ID="txtyan" runat="server" Width="61px"></asp:TextBox>
            <asp:Label ID="lblyanzheng" runat="server" BackColor="DeepSkyBlue" ForeColor="#004000" ></asp:Label> </td>
         <td  align="left" style="height: 25px">
            <asp:Label ID="lblyan" runat="server" ForeColor="#FF3300"></asp:Label></td> 
      </tr>
	   <tr>
        <td height="50" colspan="3" align="center">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Admin/images/deng.jpg"
                OnClick="ImageButton1_Click" />&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Admin/images/touchu.jpg" OnClick="ImageButton2_Click"  /></td>
      </tr>
    </table>
  </div>
</div>
    </form>
</body>
</html>
