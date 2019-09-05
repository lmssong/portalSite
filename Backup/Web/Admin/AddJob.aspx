<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="Maticsoft.Web.Admin.AddJob" %>

<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" /> 
     <script src ="js/Calendar1.js" type ="text/javascript" ></script>  
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
  <div class="admindiv">
    <!--内容部分 -->
	<uc1:top ID="Top1" runat="server" />
	
	<div class="adminzhong">
	  <!--中部内容 -->
	  <div class="adminleft">
	   <!--左边内容 -->
	   <uc2:left ID="Left1" runat="server" />
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
		  <div class="adminNewslist1">添加招聘 </div>
		  <div class="adminNewslist2">
              </div>
	    </div>
		<div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘职位：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtJobTitleName" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lbljobtitle" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">工资地点：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtAddress" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblAddress" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘人数：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtNunber" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblNumber" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘时间：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txttime" runat="server" onfocus="calendar()" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblstarttime" runat="server"></asp:Label></span>
		  </div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10">招聘对象：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtduxiang" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblduxiang" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">现在年龄：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtage" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblage" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">学历要求：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtxueli" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblxueli" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">薪水待遇：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtmonery" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblmonery" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">专业要求：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtzhuangye" runat="server" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblzhuanye" runat="server"></asp:Label></span></div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">结束时间：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtEndtime" runat="server" onfocus="calendar()" BackColor="White"></asp:TextBox><span
                  style="color: #ff3333">*<asp:Label ID="lblEndtime" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div style="width:720px; height:150px; border-bottom-width: 1px; border-bottom-style: solid; border-bottom-color: #75C8FF;">
		  <div style="float:left; width:190px; height:150px; background-color: #D0E3FF;"><br/>
	      职位描述：</div>
		  <div style="float:left; width:500px;" align="left">
            <asp:TextBox ID="txtmiaoshu" runat="server" Height="140px" TextMode="MultiLine" Width="380px" style=" margin-left:15px;" BackColor="White"></asp:TextBox></div>
		</div>
		
		<div style="width:720px; height:150px; border-bottom-width: 1px; border-bottom-style: solid; border-bottom-color: #75C8FF;">
		  <div style="float:left; width:190px; height:150px; background-color: #D0E3FF;"><br/>
	      联系公司：</div>
		  <div style="float:left; width:500px;" align="left">
		    <asp:TextBox ID="txtlink" runat="server" Height="140px" TextMode="MultiLine" Width="380px" style=" margin-left:15px;" BackColor="White"></asp:TextBox></div>
		</div>
	   <div style="width:720px; height:30px;  ">
           <asp:Button ID="Button1" runat="server" Text="提交信息" OnClick="Button1_Click" />&nbsp; &nbsp;<asp:Button ID="btncanel"
               runat="server" Text="重置信息" OnClick="btncanel_Click" />&nbsp;</div>

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
