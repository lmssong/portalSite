<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NicheInfo.aspx.cs" Inherits="Maticsoft.Web.NicheInfo" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-商业资讯</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
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


        <div class="content2">
         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		 <div class="divjies">
		    <div class="divjies1">
			  <img src="images/xuan.png" width="15" height="15" />行业资讯
			</div>
			<div class="divjies2">
			  <div class="divNewinfo">　
                  <asp:Label ID="lblNicheTitle" runat="server"></asp:Label></div>
			  
			  <div class="divNewinfo2">
			    <div class="divNewinfo21">
                    发布时间：<asp:Label ID="lblFatime" runat="server"></asp:Label>
				</div>
				
				<div class="divNewinfo21">
                    发布人：<asp:Label ID="lblWrite" runat="server"></asp:Label>
                </div>
                <div class="divNewinfo21">
                  行业类型：<asp:Label ID="lblNicheTypeTitle" runat="server"></asp:Label>
				</div>
			  </div>
			  <div class="divNewinfo1">
                  <asp:Label ID="lblNicheContent" runat="server"></asp:Label></div>
 
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
