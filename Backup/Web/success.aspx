<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="Maticsoft.Web.success" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-成功案例</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
     <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
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
			 <img src="images/xuan.png" width="15" height="15" />成功案例
			</div>
			<div class="divjies2" style="text-align: center">
             <asp:DataList ID="datasuccess" runat="server" RepeatColumns="2">
               <ItemTemplate>
                 <div class="divsuccess1">
				  <div class="divsuccess11">
                      <asp:Image ID="Image1" runat="server"  width="280" height="210" ImageUrl='<%#Eval("ImageURL") %>' />
				  </div>
				  <div class="divsuccess12" style="margin-left:30px;">名称：
				   <a href ="successInfo.aspx?SuccessID=<%#Eval("SuccessID") %>"><%#Eval("SuccessTitle") %></a> 
				  </div>
			    </div>
               </ItemTemplate>
             </asp:DataList>
			 
			  
		    </div>
              <asp:Label ID="lblpage" runat="server"></asp:Label></div>
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
    </form>
</body>
</html>
