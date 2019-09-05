<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddType.aspx.cs" Inherits="Maticsoft.Web.Admin.AddType" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <title>后台管理</title>
     <link rel="stylesheet" href="style/css.css" type="text/css" /> 
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div align="center">
  <div class="admindiv">
    <!--内容部分 -->
	<uc2:top id="Top1" runat="server"> </uc2:top>
	
	<div class="adminzhong">
	  <!--中部内容 -->
	  <div class="adminleft">
	   <!--左边内容 -->
	   <uc1:left id="Left1" runat="server"> </uc1:left>
	   <!--左边内容 -->
	  </div>
	  
	  <div class="adminright">
	   <!--右边内容 -->
	     <div class="adminrighttit">
	      <div class="adminrighttit1">
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
		  <div class="adminrighttit2">
		    <a href =main.aspx >管理首页</a>
		  </div>
	    </div>
	    
	    <div class="adminNewslist">
		  <div class="adminNewslist1" style="color: #0099ff">
              添加类型资料
          </div>
		  <div class="adminNewslist2" style="color: #0099ff"></div>
           </div>
	    
	    <div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
	    <div class="adminNewslist3 STYLE1" align="center" >  
	     添加服务类型：<asp:TextBox ID="TextBox1" runat="server" BackColor="White" Width="200px"></asp:TextBox>
            <asp:Button ID="btnfuwu" runat="server" Text="添加服务" OnClick="btnfuwu_Click" />
	    </div>
	    <div style="width:100%; text-align :center ; padding-left:15px; padding-right :15px;">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 96%; height: 100%; border-right: deepskyblue 1px solid; border-top: deepskyblue 1px solid; border-left: deepskyblue 1px solid; border-bottom: deepskyblue 1px solid;">
                <tr style="background-color : #0099ff; color :White ;">
                    <td style="height: 20px; width: 50%; background-color : #0099ff; text-align: center;">
                      服务类型标题
                    </td>
                    <td style="height: 20px; width: 50%; background-color : #0099ff">
                     编辑
                    </td>
                </tr>
                <tr>
                  <td colspan ="2">
                     <asp:DataList ID="dtlstfuwu" runat="server" Width ="100%">
                      <ItemTemplate >
                          <table style="width: 100%">
                              <tr>
                                  <td style="width: 50%">
                                   <%#Eval("FuwuTypeName")%>
                                  </td>
                                  <td style="width: 50%">
                                      <asp:Label ID="bian" runat="server" Text="编辑"></asp:Label>
                                      <asp:Label ID="shan" runat="server" Text="删除"></asp:Label>
                                  </td>
                              </tr>
                          </table>
                        
                      </ItemTemplate>
                     </asp:DataList>
                      <asp:Label ID="lblpagefuwu" runat="server" ></asp:Label>
                  </td>  
                </tr>
            </table>
	    
	    </div>
	    
	    
	    <hr />
	    
	    
	    <div class="adminNewslist3 STYLE1" align="center" >  
	     添加新闻类型：<asp:TextBox ID="txtNewsInfo" runat="server" BackColor="White" Width="200px"></asp:TextBox>
            <asp:Button ID="btnNews" runat="server" Text="添加新闻" OnClick="btnNews_Click"   />
	    </div>
	    <div style="width:100%; text-align :center ; padding-left:15px; padding-right :15px;">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 96%; height: 100%; border-right: deepskyblue 1px solid; border-top: deepskyblue 1px solid; border-left: deepskyblue 1px solid; border-bottom: deepskyblue 1px solid;">
                <tr style="background-color : #0099ff; color :White ;">
                    <td style="height: 20px; width: 50%; background-color : #0099ff">
                      新闻类型标题
                    </td>
                    <td style="height: 20px; width: 50%; background-color : #0099ff">
                     编辑
                    </td>
                </tr>
                <tr>
                  <td colspan ="2">
                     <asp:DataList ID="dtlistNews" runat="server" Width ="100%">
                      <ItemTemplate >
                          <table style="width: 100%">
                              <tr>
                                  <td style="width: 50%">
                                   <%#Eval("NewsTypeTitle")%>
                                  </td>
                                  <td style="width: 50%">
                                      <asp:Label ID="bian" runat="server" Text="编辑"></asp:Label>
                                      <asp:Label ID="shan" runat="server" Text="删除"></asp:Label>
                                  </td>
                              </tr>
                          </table>
                        
                      </ItemTemplate>
                     </asp:DataList>
                      <asp:Label ID="lblpageNews" runat="server" ></asp:Label>
                  </td>  
                </tr>
            </table>
	    
	    </div>
	    
	    
	    <hr />
	    
	    
	    
	    <div class="adminNewslist3 STYLE1" align="center" >  添加行业类型：<asp:TextBox ID="txtNiche" runat="server" BackColor="White" Width="200px"></asp:TextBox>
            <asp:Button ID="btnNiche" runat="server" Text="添加行业" OnClick="btnNiche_Click"   />
	    </div>
	    <div style="width:100%; text-align :center ; padding-left:15px; padding-right :15px;">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 96%; height: 100%; border-right: deepskyblue 1px solid; border-top: deepskyblue 1px solid; border-left: deepskyblue 1px solid; border-bottom: deepskyblue 1px solid;">
                <tr style="background-color : #0099ff; color :White ;">
                    <td style="height: 20px; width: 50%; background-color : #0099ff">
                        行业类型标题
                    </td>
                    <td style="height: 20px; width: 50%; background-color : #0099ff">
                     编辑
                    </td>
                </tr>
                <tr>
                  <td colspan ="2">
                     <asp:DataList ID="drpNiche" runat="server" Width ="100%">
                      <ItemTemplate >
                          <table style="width: 100%">
                              <tr>
                                  <td style="width: 50%">
                                   <%#Eval("NicheTypeTitle")%>
                                  </td>
                                  <td style="width: 50%">
                                      <asp:Label ID="bian" runat="server" Text="编辑"></asp:Label>
                                      <asp:Label ID="shan" runat="server" Text="删除"></asp:Label>
                                  </td>
                              </tr>
                          </table>
                        
                      </ItemTemplate>
                     </asp:DataList>
                      <asp:Label ID="lblpageNiche" runat="server" ></asp:Label>
                  </td>  
                </tr>
            </table>
	    
	    </div>
	    
	    
	    <hr />
	    
	    
	    <div class="adminNewslist3 STYLE1" align="center" >  添加产品类型与型号：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="2">选择添加类型</asp:ListItem>
                <asp:ListItem Value="0">添加产品类型</asp:ListItem>
                <asp:ListItem Value="1">添加产品型号</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="drpxing" runat="server">
            </asp:DropDownList>
            <asp:TextBox ID="txtpro" runat="server" BackColor="White" Width="150px"></asp:TextBox>&nbsp;
            <asp:Button ID="btnPro" runat="server" Text="添加产品" OnClick="btnPro_Click"   />
	    </div>
	    <div style="width:100%; text-align :center ; padding-left:15px; padding-right :15px;">
	    
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
