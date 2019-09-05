<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.JiShuInfo.Show" Title="ÏÔÊ¾Ò³" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		JishuID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJishuID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JishuTitle
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJishuTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JishuNum
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJishuNum" runat="server"></asp:Label>
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
		jishuType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbljishuType" runat="server"></asp:Label>
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
		JishuPath
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJishuPath" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




