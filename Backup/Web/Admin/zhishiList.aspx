<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zhishiList.aspx.cs" Inherits="Maticsoft.Web.Admin.zhishiList" %>
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
	<uc1:top ID="top1" runat ="server" />
	
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
	       <a href ="../index.aspx" >网站首页</a>
	      </div>
		  <div class="adminrighttit2">
		    <a href =main.aspx >管理首页</a>
		  </div>
	    </div>
	    
	    <div class="adminNewslist">
		  <div class="adminNewslist1">围栏知识列表 </div>
		  <div class="adminNewslist2"></div>
	    </div>
		<div class="adminNewslist3"></div>
		
		<div class="adminNewslist4">
		  <div class="adminNewslist41">标题名称</div>
		  <div class="adminNewslist42">发布时间</div>
		  <div class="adminNewslist42">发布人</div>
		  <div class="adminNewslist42">编辑</div>
		</div>
		 <asp:DataList ID="dataweilan" runat="server" OnDeleteCommand="dataweilan_DeleteCommand"  >
          <ItemTemplate >
            <div class="adminNewslist43">
		  <div class="adminNewslist431">
		    <a href ="zhishiInfo.aspx?WeiID=<%#Eval("WeiID") %>">
		      <%#Eval("WeiTitle")%>
		    </a>
		  </div>
		  <div class="adminNewslist432">
		     <%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>
		  </div>
		  <div class="adminNewslist432">
		   
            <asp:Label ID="lbltype" runat="server" Text=<%#Eval("Write")%>></asp:Label>
		  </div>
		  <div class="adminNewslist432">
		   <a href ="zhishiModify.aspx?WeiID=<%#Eval("WeiID") %>"  style="color :#0099FF"> 修改
		   </a>
		   <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#0099FF"  CommandName="Delete" OnClientClick="return confirm('确认要删除此行信息吗？')">删除</asp:LinkButton>

		  </div>
		</div>
          </ItemTemplate>
        </asp:DataList><br /><br />
          <asp:Label ID="lblpage" runat="server" ></asp:Label>
		
		
		
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
