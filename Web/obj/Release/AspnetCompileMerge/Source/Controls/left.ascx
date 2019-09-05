<%@ Control Language="c#" AutoEventWireup="True" Codebehind="left.ascx.cs" Inherits="Maticsoft.Web.Controls.CheckRight" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<link href="../style/css.css" rel="stylesheet" type="text/css" />
<link href="../style/lanrenxixi.css" rel="stylesheet" type="text/css" />
<div class="divzhongleft">
		    <!--左边内容 -->
			<div class="divzhongleft1">
			  <div class="divzhongleft11">
                  订购案例&nbsp;</div>
			  <asp:DataList ID="datading" runat="server" Width="200">
               <ItemTemplate>
                 <div class="divduwu" style="padding-left:10px;">
			      <img src="../images/bi.gif" width="6" height="6" />
			      <a href="../dinggou.aspx?DingID=<%#Eval("DingID") %>" ><%# Eval("ProName")%></a>
			     </div>
               </ItemTemplate>
               <ItemStyle HorizontalAlign ="Left"  />
             </asp:DataList>  
			</div>
			
			<div class="divzhongleft2">
			  <div class="divzhongleft21">
			    <div class="divzhongleft22">客户案例</div>
				<div class="divzhongleft23">
				 <marquee height="200" width="200"   direction="up" onmouseover="this.stop()"   onmouseout="this.start()">
				 <asp:DataList id="datasuess" Width="198%" runat="server">
				 <ItemTemplate>
<DIV class="divzhongleft234">
<DIV class="divzhongleft2341" align=center>
<asp:Image id="Image1" Width="180px" runat="server" ImageUrl='<%#Eval("ImageURL") %>' Height="80"  ></asp:Image>
 </DIV><DIV class="divzhongleft2342">名称： <A href='../successInfo.aspx?SuccessID=<%#Eval("SuccessID") %>'><%#Eval("SuccessTitle")%></A></DIV></DIV>
</ItemTemplate>
</asp:DataList></marquee>
				</div>
			  </div>
			</div>
			
			<div class="divzhongleft2">
			  <div class="divzhongleft21">
			    <div class="divzhongleft22">联系方式</div>
				<div class="divzhongleft23">
				  <div class="divzhongleft231"><img src="images/lianxi2.png" /></div>
				  
				  <div class="divzhongleft232"> 
                      <asp:Label ID="lblCompanyNames" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 联 系 人：
				      <asp:Label ID="lblFanren" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 公司传真：
                      <asp:Label ID="lblComFax" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 公司邮箱：
                      <asp:Label ID="lblComEmail" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> 服务电话：
                      <asp:Label ID="lblComPhoto" runat="server"></asp:Label> 
				  </div>
				</div>
			  </div>
			</div>
			<!--左边内容 -->
		  </div>