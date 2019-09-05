<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addfuwu.aspx.cs" Inherits="Maticsoft.Web.Admin.Addfuwu" %>

<%@ Register Src="contents/left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="contents/top.ascx" TagName="top" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <title>后台管理</title>
    <link rel="stylesheet" href="style/css.css" type="text/css" /> 
    <script src ="js/Calendar1.js" type ="text/javascript" ></script> 

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
		  <div class="adminNewslist1">添加服务资料 </div>
		  <div class="adminNewslist2"><a href ="fuwuList.aspx">服务列表</a></div>
	    </div>
	    
	    <div class="adminNewslist3 STYLE1"> 带有“<span class="STYLE2">*</span>”为必填项</div>
		<div class="adminNewslist3 STYLE1"> 
		 </div>
		 <div class="adminNewslist3 STYLE1">添加服务类型：<asp:TextBox ID="txtaddtype" runat="server"></asp:TextBox>
             <asp:Button ID="btntype" runat="server" Text="添加类型" OnClick="btntype_Click" />
             <asp:Label ID="lbladdtype" runat="server"></asp:Label></div>
		
		<div class="adminNewslist3 STYLE1"> 
		 </div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">服务标题：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtfuwuTitle" runat="server" BackColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblfuwutitle" runat="server"></asp:Label></span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">服务类型：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:DropDownList ID="DrpFuwuType" runat="server">
              </asp:DropDownList>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布时间：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtFatime" runat="server" onfocus="calendar()" BackColor="White" Width="200px"></asp:TextBox>
              <span style="color: #ff3333">*<asp:Label ID="lblfuwutime" runat="server"></asp:Label>
              </span>
		  </div>
		</div>
		<div class="adminNewslist3">
		  <div class="adminNewslist10">发布人：</div>
		  <div class="adminNewslist5">
              &nbsp;<asp:TextBox ID="txtWrite" runat="server" BackColor="White" Width="200px"></asp:TextBox><span
                style="color: #ff3333"> * 
                <asp:Label ID="lblfuwuwrite" runat="server"></asp:Label></span></div>
		</div>
		
		<div class="adminNewslist3">
		  <div class="adminNewslist10"> 服务图片：</div>
		  <div class="adminNewslist5">
              &nbsp;
              <asp:FileUpload ID="txtFile" runat="server" />
              <asp:Button ID="btnup" runat="server" OnClick="btnup_Click1" Text="上传" />
              <asp:Label ID="lblInfo" runat="server"></asp:Label><br/>　
           </div>  
		</div>
		<div visible ="false"  style="width:720px; height:200px; border-bottom-width: 1px; border-bottom-style: solid; border-bottom-color: #75C8FF;" id ="tu" runat ="server" >
             <div style="float:left; width:190px; height:200px; background-color: #D0E3FF;"> </div>
             <div style="float:left; width:500px;" align="left">
                 &nbsp;<asp:Image ID="Image1" runat="server" Height ="200px"   />
             </div>
          </div> 
		
		<div class="adminNewslist6">
		  <div class="adminNewslist61"> 
		  服务描述：</div>
		  <div class="adminNewslist62">
              &nbsp;<asp:TextBox ID="txtFuwucontent" runat="server" Height="238px" TextMode="MultiLine"　Width="405px" BackColor="White"></asp:TextBox></div>
		</div>
	   <div class="adminNewslist31">
           &nbsp; &nbsp; &nbsp;<asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="提交信息" />&nbsp;
           <asp:Button ID="btncanel" runat="server" OnClick="btncanel_Click" Text="重置信息" />
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
