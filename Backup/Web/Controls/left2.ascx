<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="left2.ascx.cs" Inherits="Maticsoft.Web.Controls.left2" %>
<link href="../style/css.css" rel="Stylesheet" type="text/css" />
<link href="../style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
<div class="divrightlian1">
			  <div class="divzhongleft22">
			    栏目导航
			  </div>
			  <div class="divduwu" style="text-align:center ; padding-left:10px; padding-right:10px; height:25px; padding-top:10px;">
                 <a href ="../jieshao.aspx" style="color:Black ;" >公司简介</a>
			  </div>
			  <div class="divduwu" style="text-align:center ; padding-left:10px; padding-right:10px; height:25px; padding-top:10px;">
                 <a href ="../zhishi.aspx"  style="color:Black ;" > 行业知识</a>
			  </div>
			  <div class="divduwu" style="text-align:center ; padding-left:10px; padding-right:10px; height:25px; padding-top:10px;">
                <a href ="../wenhua.aspx" style="color:Black ;"> 企业文化</a>
			  </div>
			  <div class="divduwu" style="text-align:center ; padding-left:10px; padding-right:10px; height:25px; padding-top:10px;">
                <a href ="../message.aspx" style="color:Black ;" > 在线留言</a>
			  </div>
			  <div class="divduwu" style="text-align:center ; padding-left:10px; padding-right:10px; height:25px; padding-top:10px;">
                <a href ="../success.aspx" style="color:Black ;"> 成功案例</a>
			  </div>
			  
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