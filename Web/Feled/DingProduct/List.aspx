<%@ Page Title="DingProduct" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.DingProduct.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>¹Ø¼ü×Ö£º</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="²éÑ¯"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="DingID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="Ñ¡Ôñ"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="ProName" HeaderText="ProName" SortExpression="ProName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ProXingID" HeaderText="ProXingID" SortExpression="ProXingID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ProTypeID" HeaderText="ProTypeID" SortExpression="ProTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DingNum" HeaderText="DingNum" SortExpression="DingNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DingAddress" HeaderText="DingAddress" SortExpression="DingAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LinkPhoto" HeaderText="LinkPhoto" SortExpression="LinkPhoto" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DingEmail" HeaderText="DingEmail" SortExpression="DingEmail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DingSex" HeaderText="DingSex" SortExpression="DingSex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UsersName" HeaderText="UsersName" SortExpression="UsersName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Dingtime" HeaderText="Dingtime" SortExpression="Dingtime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Dingcontent" HeaderText="Dingcontent" SortExpression="Dingcontent" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="ÏêÏ¸" ControlStyle-Width="50" DataNavigateUrlFields="DingID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="ÏêÏ¸"  />
                            <asp:HyperLinkField HeaderText="±à¼­" ControlStyle-Width="50" DataNavigateUrlFields="DingID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="±à¼­"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="É¾³ý"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="É¾³ý"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="É¾³ý" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
