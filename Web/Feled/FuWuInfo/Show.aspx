<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.FuWuInfo.Show" Title="��ʾҳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		fuwuID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfuwuID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		fuwuTitle
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfuwuTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fatime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFatime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuwuTypeID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFuwuTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Write
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWrite" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fuwucontent
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFuwucontent" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




