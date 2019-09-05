<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Maticsoft.Web.Admin.login" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
  <div class="admindiv">
    <!--内容部分 -->
	<uc1:top ID ="top1" runat ="server" />
	
	<div class="adminzhong">
	  <!--中部内容 -->
	  <div class="adminleft">
	   <!--左边内容 -->
	    <uc2:left ID="left1" runat ="server" />
	   <!--左边内容 -->
	  </div>
	  
	  <div class="adminright">
	   <!--右边内容 -->
	     <div class="adminrighttit">
           <div class="adminrighttit1">
		    <a href ="main.aspx" >管理首页</a>
		  </div>
	      <div class="adminrighttit2">
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
		 
	    </div>
	    
	    <div class="adminrightcon">
		  <table align="center" border="0" cellpadding="3" cellspacing="1" 
            width="98%">

            <tr>
                <td   height="30" width="100%">
                    &nbsp;服务器名称: <asp:Label ID="lServerName" runat="server" Text=""></asp:Label></td>
             </tr>
            <tr>
                <td   style="width: 100%"  height="30">
                    &nbsp;服务器IP:<asp:Label ID="lServerIP" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td   style="width: 100%"  height="30">
                    &nbsp;服务器操作系统版本：<asp:Label ID="lServerOSVersion"  runat="server" Text=""></asp:Label>
                    </td>
             </tr>
            <tr>
                <td   style="width: 100%"  height="30">
                    &nbsp;服务器IIS版本:<asp:Label ID="lServerIISVersion" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td   height="30" width="100%">
                    &nbsp;DotNET引擎版本：<asp:Label ID="lServerDotNETVersion" runat="server" Text=""></asp:Label></td>
               <%-- <td   style="width: 50%">
                    &nbsp; </td>--%>
            </tr>
        </table> 
		  <table align="center" border="0" cellpadding="3" cellspacing="1" width="98%" style="margin-top:20px;">
            <tr>
                <td  height="23" width="100%" style="background-color: #e8e8e8; text-align: center">
                 网站信息
                </td>
            </tr>
            <tr>
                <td  height="30" width="100%">
                    &nbsp;今天发布的新闻信息：<asp:Label ID="lblnew" ForeColor="#FF3300" runat="server"></asp:Label>条</td>
            </tr>
            <tr>
                <td   height="30" width="100%">
                    &nbsp;今天发布的行业信息：<asp:Label ID="lblniche" ForeColor="#FF3300" runat="server"></asp:Label>条</td>
            </tr>
            <tr>
                <td    height="30" width="100%">
                    &nbsp;今天发布产品信息：
                    <asp:Label ID="lblproduct" ForeColor="#FF3300" runat="server"></asp:Label>条</td>
                
            </tr>
            <tr>
                <td   height="30" width="100%">
                    &nbsp;今天收到的订购信息：<asp:Label ID="lblding" ForeColor="#FF3300" runat="server"></asp:Label>条</td>
                
            </tr>
            <tr>
                <td   height="30" width="100%">
                    &nbsp;今天人才自荐：<asp:Label ID="lblzijian" ForeColor="#FF3300" runat="server"></asp:Label>条</td>
                
            </tr>
            <tr>
                <td  height="30" width="100%">
                    &nbsp;今天意见建议：<asp:Label ID="lblyijian" runat="server" ForeColor="#ff3300" Text=""></asp:Label>条</td>
            </tr>

        </table>
        <table align="center" border="0" cellpadding="3" cellspacing="1" class="tableBorder"
            style="line-height: 14pt; margin-top:20px;" width="98%">
            <tr>
                <th class="tableHeaderText" colspan="2" height="25" style="background-color: #e8e8e8; text-align: center">
                    系统管理小贴士</th>
            </tr>
            <tr>
            </tr>
            <tr>
                <td   height="30" valign="top" width="111">
                    <b>一句话贴士</b>
                </td>
                <td   height="30" width="846" style="line-height:30px;">
                    ① 进行任何的删除操作都是不可逆的，要仔细看页面中的说明，以免误操作
                    <br />
                    ② 网站后台为整套系统最关键也是最脆弱部分，建议定期的查看系统安全日志<br />
                    ③ 系统管理员的帐号及密码应复杂，不易被猜测到，建议定期更改<br />
                </td>
            </tr>
        </table>
		</div>
	    <!--右边内容 -->
	  </div>
	  <!--中部内容 -->
	</div>
	<!--内容部分 -->
  </div>
</div>
    </form>
</body>
</html>
