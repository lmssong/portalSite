<%@ Control Language="c#" AutoEventWireup="True" Codebehind="left.ascx.cs" Inherits="Maticsoft.Web.Controls.CheckRight" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<link href="../style/css.css" rel="stylesheet" type="text/css" />
<link href="../style/lanrenxixi.css" rel="stylesheet" type="text/css" />
<div class="divzhongleft">
		    <!--������� -->
			<div class="divzhongleft1">
			  <div class="divzhongleft11">
                  ��������&nbsp;</div>
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
			    <div class="divzhongleft22">�ͻ�����</div>
				<div class="divzhongleft23">
				 <marquee height="200" width="200"   direction="up" onmouseover="this.stop()"   onmouseout="this.start()">
				 <asp:DataList id="datasuess" Width="198%" runat="server">
				 <ItemTemplate>
<DIV class="divzhongleft234">
<DIV class="divzhongleft2341" align=center>
<asp:Image id="Image1" Width="180px" runat="server" ImageUrl='<%#Eval("ImageURL") %>' Height="80"  ></asp:Image>
 </DIV><DIV class="divzhongleft2342">���ƣ� <A href='../successInfo.aspx?SuccessID=<%#Eval("SuccessID") %>'><%#Eval("SuccessTitle")%></A></DIV></DIV>
</ItemTemplate>
</asp:DataList></marquee>
				</div>
			  </div>
			</div>
			
			<div class="divzhongleft2">
			  <div class="divzhongleft21">
			    <div class="divzhongleft22">��ϵ��ʽ</div>
				<div class="divzhongleft23">
				  <div class="divzhongleft231"><img src="images/lianxi2.png" /></div>
				  
				  <div class="divzhongleft232"> 
                      <asp:Label ID="lblCompanyNames" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> �� ϵ �ˣ�
				      <asp:Label ID="lblFanren" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> ��˾���棺
                      <asp:Label ID="lblComFax" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> ��˾���䣺
                      <asp:Label ID="lblComEmail" runat="server"></asp:Label>
				  </div>
				  <div class="divzhongleft232"> ����绰��
                      <asp:Label ID="lblComPhoto" runat="server"></asp:Label> 
				  </div>
				</div>
			  </div>
			</div>
			<!--������� -->
		  </div>