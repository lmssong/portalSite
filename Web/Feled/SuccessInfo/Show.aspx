<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.SuccessInfo.Show" Title="��ʾҳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SuccessID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuccessID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuccessTitle
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuccessTitle" runat="server"></asp:Label>
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
		Write
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWrite" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImageURL
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblImageURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HitNum
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHitNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuccessContent
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuccessContent" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




