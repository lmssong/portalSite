<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="job.aspx.cs" Inherits="Maticsoft.Web.job" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-人才招聘</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
			 <img src="images/xuan.png" width="15" height="15" />人才招聘
			</div>
			<div class="divjies2" style="text-align: center">
		      <div class="divjob">
			    <div class="divjobti">
				  <div class="divjob1">工作职位</div>
				  <div class="divjob2">工作地点</div>
				  <div class="divjob2">招聘人数</div>
				  <div class="divjob2">发布时间</div>
				  <div class="divjob1">工作要求</div>
				</div>
                  <asp:DataList ID="datajob" runat="server" >
                    <ItemTemplate>
                      <div class="divjobru">
				         <div class="divjob1"><a href="jobInfo.aspx?JobID=<%#Eval("JobID") %>"><%#Eval("JobTitle") %></a></div>
				         <div class="divjob2"><%#Eval("Address") %></div>
				         <div class="divjob2"><%#Eval("Nunber") %>人</div>
				         <div class="divjob2"> 
				          <%#((DateTime)Eval("Starttime")).ToString("yyyy-MM-dd")%>
				         </div>
				         <div class="divjob1"><%#Eval("Zhuanye") %></div>
				      </div>
                    </ItemTemplate>
                  </asp:DataList>
				
				
				
		      </div>
                <asp:Label ID="lblpage" runat="server"></asp:Label></div>
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
           
           
         </td>
       </tr>
       <tr>
         <td>
           <uc1:buttom ID="Buttom1" runat="server" />
         </td>
       </tr>
     </table>
    </div>
    </div>
    </form>
</body>
</html>
