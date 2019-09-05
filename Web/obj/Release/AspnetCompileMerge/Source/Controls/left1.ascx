<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="left1.ascx.cs" Inherits="Maticsoft.Web.Controls.left1" %>
<link type="text/css" href="../style/css.css" rel="Stylesheet" />
<div class="divrightlian1">
		  <div class="divzhongleft22"> 行业知识&nbsp;</div>
			  <asp:DataList ID="datazhishi" runat="server" Width="200">
               <ItemTemplate>
                 <div class="divduwu" style="padding-left:10px;">
			      <img src="../images/bi.gif" width="6" height="6" />
			      <a href="../zhishiInfo.aspx?WeiID=<%#Eval("WeiID") %>" ><%# Eval("WeiTitle") %></a>
			     </div>
               </ItemTemplate>
               <ItemStyle HorizontalAlign ="Left"  />
             </asp:DataList>  
			</div>
			
			<div class="divrightlian1">
			  <div class="divzhongleft22">
			    推荐服务
			  </div>
			  <asp:DataList ID="datafuwu" runat="server" Width="200">
               <ItemTemplate>
                 <div class="divduwu" style="padding-left:10px;">
			      <img src="../images/bi.gif" width="6" height="6" />
			      <a href="../fuwuInfo.aspx?fuwuID=<%#Eval("fuwuID") %>" ><%# Eval("fuwuTitle")%></a>
			     </div>
               </ItemTemplate>
               <ItemStyle HorizontalAlign ="Left"  />
             </asp:DataList>  
			</div>
			
			<div class="divzhongleft2">
			  <div class="divzhongleft21">
			    <div class="divzhongleft22">联系方式</div>
				<div class="divzhongleft23">
				  <div class="divzhongleft231"><img src="images/lianxi2.png" /></div>
				  <div class="divzhongleft232"> 
                      <asp:Label ID="lblCompanyNames" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 联系人：
				      <asp:Label ID="lblFanren" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 传真：
                      <asp:Label ID="lblComFax" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 邮箱：
                      <asp:Label ID="lblComEmail" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 服务电话：
                      <asp:Label ID="lblComPhoto" runat="server"></asp:Label> 
				  </div>
				</div>
			  </div>
			</div>