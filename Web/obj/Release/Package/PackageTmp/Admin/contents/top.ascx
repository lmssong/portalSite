<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="top.ascx.cs" Inherits="Maticsoft.Web.Admin.contents.WebUserControl1" %>
<link href="../style/css.css"rel="Stylesheet" type="text/css" />
<div class="admintop">
	<!-- 头部信息 -->
   
    <div style="float:left ; width:240px; text-align:left ">
        &nbsp;</div>
    <div style="float:left ; width:300px; text-align:left ; font-size:13px; padding-top:30px; padding-left:200px;">
     您好：<asp:Label ID="lblusename" runat="server" ></asp:Label><br />
     
    </div>
    <div style="float:left ; width:200px;  padding-top:25px; text-align:right; padding-right:30px;">
        <asp:ImageButton ID="imetchu" runat="server" ImageUrl="~/Admin/images/out.gif" OnClick="imetchu_Click" />
    </div>
    <!-- 头部信息 --></div>