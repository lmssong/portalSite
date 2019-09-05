<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.NewsInfo.Show" Title="ÏÔÊ¾Ò³" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		NewsID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNewsID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NewsTitle
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNewsTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NewsKey
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNewsKey" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Write
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWrite" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NewsTypeID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNewsTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fatime
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFatime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImageURL
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblImageURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HitNum
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHitNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NewsContent
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNewsContent" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




