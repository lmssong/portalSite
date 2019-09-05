<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.MessageInfo.Show" Title="ÏÔÊ¾Ò³" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MessID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMessID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MessTitle
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMessTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Username
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsername" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sex
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Address
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Linkphoto
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLinkphoto" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Email
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Messcontent
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMesscontent" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




