<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dinggou.aspx.cs" Inherits="Maticsoft.Web.dinggou" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-产品订购</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
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
	  <div class="cell">
        <div class="up1">
        </div>
        <div class="up2">
        </div>
        <div class="up3">
        </div>
        <div class="content2">
         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		  <div class="divjies">
		    <div class="divjies1">
			 <img src="images/xuan.png" width="15" height="15" />订购产品
			</div>
			<div class="divjies2">
			 <div class="xiazai">
			    <img src="images/proe.jpg" />订购信息
			 </div>
			 <p></p>
			 <div class="divmess">
			     <table width="640" border="0" cellpadding="0" cellspacing="0" >
				  <tr>
				   <td id="tdleft">用户姓名：</td>
				   <td>
                       &nbsp;<asp:TextBox ID="txtUsersName" runat="server" BackColor="White" BorderColor="White"
                           Width="200px"></asp:TextBox>
                       <span style="color: #ff3333">*<asp:Label ID="lblUsersName" runat="server"></asp:Label></span></td>
				  </tr>
				  <tr>
				   <td id="tdleft">用户性别：</td>
				   <td>
                       &nbsp;<asp:DropDownList ID="DrpSex" runat="server" BackColor="White">
                           <asp:ListItem Selected="True" Value="2">选择性别</asp:ListItem>
                           <asp:ListItem Value="1">男</asp:ListItem>
                           <asp:ListItem Value="0">女</asp:ListItem>
                       </asp:DropDownList><asp:Label ID="Label1" runat="server" ForeColor="#FF3333"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft">现在地址：</td>
				   <td>
                       &nbsp;<asp:TextBox ID="txtDingAddress" runat="server" BackColor="White" BorderColor="White"
                           Width="200px"></asp:TextBox>
                       <span style="color: #ff3333">*</span><asp:Label ID="lblDingAddress" runat="server"
                           ForeColor="#FF3333"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft">联系电话：</td>
				   <td>
                       &nbsp;<asp:TextBox ID="txtLinkPhoto" runat="server" BackColor="White" BorderColor="White"
                           Width="200px"></asp:TextBox>
                       <span style="color: #ff3333">*</span><asp:Label ID="lblLinkPhoto" runat="server"
                           ForeColor="#FF3300"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft" style="height: 30px">电子邮箱：</td>
				   <td style="height: 30px">
                       &nbsp;<asp:TextBox ID="txtDingEmail" runat="server" BackColor="White" BorderColor="White"
                           Width="200px"></asp:TextBox>
                       <span style="color: #ff3333">*</span><asp:Label ID="lblDingEmail" runat="server"
                           ForeColor="#FF3333"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft" style="height: 30px">产品名称：</td>
				   <td style="height: 30px">
                       &nbsp;<asp:TextBox ID="txtProName" runat="server" BackColor="White" BorderColor="White"
                           Width="200px"></asp:TextBox>
                       <span style="color: #ff3333">*</span><asp:Label ID="lblProName" runat="server" ForeColor="Red"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft">产品类型：</td>
				   <td>
                       <asp:DropDownList ID="DrpProTypeTitle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DrpProTypeTitle_SelectedIndexChanged">
                           <asp:ListItem Value="0">选择产品类型</asp:ListItem>
                       </asp:DropDownList>
				   </td>
				  </tr>
				  <tr>
				   <td id="tdleft" style="height: 22px">产品型号：</td>
				   <td style="height: 22px">
                       <asp:DropDownList ID="DrpProductXing" runat="server">
                           <asp:ListItem Value="0">选择产品型号</asp:ListItem>
                       </asp:DropDownList>
                       <asp:Label ID="lblxing" runat="server" ForeColor="#FF3300"></asp:Label></td>
				  </tr>
				  <tr>
				   <td id="tdleft">订购数量：</td>
				   <td>
                       &nbsp;<asp:TextBox ID="txtDingNum" runat="server" BackColor="White" BorderColor="White"
                           Width="200px"></asp:TextBox>
                       <span style="color: #ff3333">*</span><asp:Label ID="lblNum" runat="server" ForeColor="#FF3300"></asp:Label></td>
				  </tr>
				  <tr>
				   <td  align="right" valign="top" bgcolor="#EEFCFF">订购描述：</td>
				   <td>
                       &nbsp;<asp:TextBox ID="txtDingcontent" runat="server" BackColor="White" Height="150px"
                           TextMode="MultiLine" Width="350px"></asp:TextBox>
                       <span style="color: #ff3333">*<asp:Label ID="lblDingContent" runat="server"></asp:Label></span></td>
				  </tr>
			    </table>
				 <div class="divliuyanba">
                     &nbsp;<asp:Button ID="btnok" runat="server" Text="提交信息" OnClick="btnok_Click" />&nbsp;<asp:Button ID="btncanel"
                         runat="server" Text="重置信息" OnClick="btncanel_Click" /></div>
			 
			 
		    </div>
			</div>
		  </div>
        </div>
        <div class="down1">
        </div>
        <div class="down2">
        </div>
        <div class="down3">
        </div>
      </div>
	  <!--中间内容 -->
	 </div>
	 <!--中间内容 -->
   </div>
             &nbsp;
           
           
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
