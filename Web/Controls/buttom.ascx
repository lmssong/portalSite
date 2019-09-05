<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="buttom.ascx.cs" Inherits="Maticsoft.Web.Controls.buttom" %>
<link href="../style/css.css" rel="stylesheet" type="text/css" />

<div class="divbuttom">
     <!--底部内容 -->
	 <div class="divbuttom1">
	     <div class="divbuttom11" style =" margin-left:100px;"><a href="../jieshao.aspx">公司简介</a> |</div>
         <div class="divbuttom11"><a href="../rencai.aspx">人才自荐</a> |</div>
		 <div class="divbuttom11"><a href="../companyway.aspx">联系我们</a> |</div>
		 <div class="divbuttom11"><a href="../huanjing.aspx">公司环境</a> |</div>
		 <div class="divbuttom11"><a href="../message.aspx">在线留言</a> |</div>
		 <div class="divbuttom11"><a href="../Admin/login.aspx" >管理后台</a> |</div>
	    <%--<div style="float:left;"><img src="images/wr.jpg" /></div>--%>
	   
	 </div>
    <div class="divbuttom12">
	     &copy 2004 - <%= DateTime.Now.Year %> 北京三联腾达南京分公司
	 </div>
   </div>