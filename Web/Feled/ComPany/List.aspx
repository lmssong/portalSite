<%@ Page Title="ComPany" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.ComPany.List" %>
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
                    BorderWidth="1px" DataKeyNames="CompanyID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="Ñ¡Ôñ"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="CompanyNames" HeaderText="CompanyNames" SortExpression="CompanyNames" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CompanyType" HeaderText="CompanyType" SortExpression="CompanyType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ComAddress" HeaderText="ComAddress" SortExpression="ComAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ComFax" HeaderText="ComFax" SortExpression="ComFax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ComPhoto" HeaderText="ComPhoto" SortExpression="ComPhoto" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ComEmail" HeaderText="ComEmail" SortExpression="ComEmail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QQ" HeaderText="QQ" SortExpression="QQ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Comwangzhi" HeaderText="Comwangzhi" SortExpression="Comwangzhi" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="ÏêÏ¸" ControlStyle-Width="50" DataNavigateUrlFields="CompanyID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="ÏêÏ¸"  />
                            <asp:HyperLinkField HeaderText="±à¼­" ControlStyle-Width="50" DataNavigateUrlFields="CompanyID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
