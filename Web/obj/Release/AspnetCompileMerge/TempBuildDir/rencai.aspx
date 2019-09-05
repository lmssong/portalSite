<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rencai.aspx.cs" Inherits="Maticsoft.Web.rencai" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-人才自荐</title>
        <link href="style/css.css" rel="Stylesheet" type="text/css" />
        <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
        <script src ="js/Calendar1.js" type ="text/javascript" ></script>  
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
 
        <div class="content2">
         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		 <div class="divjies">
		    <div class="divjies1">
			 <img src="images/xuan.png" width="15" height="15" />人才自荐
			</div>
			<div class="divjies2">
			  <div class="divzijian">
			    <img src="images/rencai.jpg" />
			  </div>
			  <div class="divzijianle">
			    <div class="divzijianle1">个人信息</div>
				<div class="divzijianle2">
				  <div class="divzijianle21">
				    <div class="divzijianle22">个人姓名：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:TextBox ID="txtUsersname" runat="server" BackColor="White"></asp:TextBox>
                        <asp:Label ID="lblusername" runat="server" ForeColor="#FF3333"></asp:Label></div>
				  </div>
				  <div class="divzijianle21">
				    <div class="divzijianle22">求职职位：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:TextBox ID="txtJobTitleName" runat="server" BackColor="White"></asp:TextBox>
                        <asp:Label ID="lnljobtitle" runat="server" ForeColor="#FF3300"></asp:Label></div>
				  </div>
				  <div class="divzijianle21">
				    <div class="divzijianle22">个人性别：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:DropDownList ID="drpSex" runat="server">
                            <asp:ListItem Value="2">选择性别</asp:ListItem>
                            <asp:ListItem Value="1">男</asp:ListItem>
                            <asp:ListItem Value="0">女</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblsex" runat="server" ForeColor="#FF3300"></asp:Label></div>
				  </div>
				  <div class="divzijianle21">
				    <div class="divzijianle22">现在学历：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:TextBox ID="txtXueli" runat="server" BackColor="White"></asp:TextBox>
                        <asp:Label ID="lblxueli" runat="server" ForeColor="#FF3300"></asp:Label></div>
				  </div>
				  <div class="divzijianle21">
				    <div class="divzijianle22">籍 贯：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:TextBox ID="txtJiguan" runat="server" BackColor="White"></asp:TextBox>
                        <asp:Label ID="lbljiguan" runat="server" ForeColor="#FF3300"></asp:Label></div>
				  </div>
				  <div class="divzijianle21">
				    <div class="divzijianle22">出生年月：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:TextBox ID="txtBritday" onfocus="calendar()" runat="server" BackColor="White"></asp:TextBox>
                        <asp:Label ID="lblbriendy" runat="server" ForeColor="#FF3300"></asp:Label></div>
				  </div>
				  <div class="divzijianle21">
				    <div class="divzijianle22">所学专业：</div>
					<div class="divzijianle23">
                        &nbsp;<asp:TextBox ID="txtZhuanye" runat="server" BackColor="White"></asp:TextBox>
                        <asp:Label ID="lnlzhuangye" runat="server" ForeColor="#FF3300"></asp:Label></div>
				  </div>
				</div>
				<div class="divzijianle4">
		          <div class="divzijianle1">教育经历</div>
			      <div class="divzijianle2">
                      &nbsp;<asp:TextBox ID="txtJiaoyu" runat="server" TextMode="MultiLine" Width="636px" Height="120px" BackColor="White"></asp:TextBox>
                  </div>
		        </div>
				
				<div class="divzijianle4">
		          <div class="divzijianle1">工作经验</div>
			      <div class="divzijianle2">
			         &nbsp;<asp:TextBox ID="txtJingyan" runat="server" TextMode="MultiLine" Width="636px" Height="120px" BackColor="White"></asp:TextBox>
			      </div>
		        </div>
				
				
				<div class="divzijianle4">
		          <div class="divzijianle1">自我评价</div>
			      <div class="divzijianle2">
			         &nbsp;<asp:TextBox ID="txtPingjia" runat="server" TextMode="MultiLine" Width="636px" Height="120px" BackColor="White"></asp:TextBox>
			      </div>
		        </div>
				<div class="divzijianle5">
                    <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="提交信息" />&nbsp;
                    &nbsp;<asp:Button ID="btncanel" runat="server" OnClick="btncanel_Click" Text="重置信息" /></div>
			  </div>
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
