<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.ZiXunInfo.Show" Title="ÏÔÊ¾Ò³" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		zixunID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzixunID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zixunTitle
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzixunTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zixuntime
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzixuntime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zixuncontent
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzixuncontent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zixunUserName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzixunUserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zixunuserPhoto
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzixunuserPhoto" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




