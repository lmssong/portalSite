<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="Maticsoft.Web.message" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-在线留言</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/lanrenxixi.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
 
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">   
     <table border ="0" cellpadding ="0" cellspacing ="0" width ="1000">
       <tr>
         <td>
           <uc3:top ID="Top1" runat="server" />
         </td>
       </tr>
       <tr>
         <td>
           <%--<uc2:left ID="Left1" runat="server" />--%>
           <div class="divzhong">
     <!--中间内容 -->
	 <div class="divxun">
	  <!--中间内容 -->

         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		<div class="divjies">
		    <div class="divjies1">
			 <img src="images/xuan.png" width="15" height="15" />给我留言
			</div>
			<div class="divjies2">
			  <div class="divmess">
			     <table width="620" border="0" cellspacing="0" cellpadding="0">
				  <tr>
				   <td id="tdleft">用户姓名：</td>
				   <td>
                       <asp:TextBox ID="txtUsername" runat="server" BackColor="White"></asp:TextBox>
                       <asp:Label ID="lblusename" runat="server" Font-Size="10pt" ForeColor="Red"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft">用户性别：</td>
				   <td>
                       <asp:DropDownList ID="drpSex" runat="server" BackColor="White">
                           <asp:ListItem Value="2">选择性别</asp:ListItem>
                           <asp:ListItem Value="1">男</asp:ListItem>
                           <asp:ListItem Value="0">女</asp:ListItem>
                       </asp:DropDownList>
                       <asp:Label ID="lblsex" runat="server" Font-Size="10pt" ForeColor="Red"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft">现在地址：</td>
				   <td>
                       <asp:TextBox ID="txtAddress" runat="server" BackColor="White"></asp:TextBox></td>
				  </tr>
				  <tr>
				   <td id="tdleft">联系电话：</td>
				   <td>
                       <asp:TextBox ID="txtLinkphoto" runat="server" BackColor="White"></asp:TextBox></td>
				  </tr>
				  <tr>
				   <td id="tdleft">电子邮箱：</td>
				   <td>
                       <asp:TextBox ID="txtEmail" runat="server" BackColor="White"></asp:TextBox></td>
				  </tr>
				  <tr>
				   <td id="tdleft">留言标题：</td>
				   <td>
                       <asp:TextBox ID="txtMessTitle" runat="server" BackColor="White"></asp:TextBox>
                       <asp:Label ID="lnltitle" runat="server" Font-Size="10pt" ForeColor="Red"></asp:Label></td>
				  </tr>
				  <tr>
				   <td  align="right" valign="top" bgcolor="#EEFCFF">
                       <span style="font-size: 10pt">留言内容：</span></td>
				   <td>
                       <asp:TextBox ID="txtMesscontent" runat="server" TextMode="MultiLine" Width="400px" Height ="150px" BackColor="White"></asp:TextBox>
                       <asp:Label ID="lblcotent" runat="server" Font-Size="10pt" ForeColor="Red"></asp:Label></td>
				  </tr>
				 </table>
				 <div class="divliuyanba">
                     <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="提交信息" />&nbsp;
                     <asp:Button ID="btncanel" runat="server" OnClick="btncanel_Click" Text="重置信息" /></div>
				 
			     <div class="divliuyantu"><img src="images/3232.png" width="540" height="230" /></div>
			  </div>
		    </div>
		  </div>

        
	  <!--中间内容 -->
	 </div>
	 <!--中间内容 -->
   </div>
           
           
         </td>
       </tr>
       <tr>
         <td>
           <uc1:buttom ID="Buttom1" runat="server" />
         </td>
       </tr>
     </table>
    </div>
    </form>
</body>
</html>
