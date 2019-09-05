<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jobInfo.aspx.cs" Inherits="Maticsoft.Web.jobInfo" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left2.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-人才招聘</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
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
			 <img src="images/xuan.png" width="15" height="15" />人才招聘
			</div>
			<div class="divjies2">
		      <div class="divjobbiao">
                  <asp:Label ID="lblJobTitle" runat="server"></asp:Label>
		      </div>   
			  <div class="divjobcontent">
			    <table width="730" border="0" cellspacing="0" cellpadding="0">
                 <tr>
                   <td height="30" colspan="4" bgcolor="#E7E7E7">
				     <img src="images/xuan.png" />招聘信息： </td>
                  </tr>
                 <tr>
				  <td width="182" height="30" align="right">招聘对象：</td>
				  <td width="182" align="left">
                      &nbsp;<asp:Label ID="lblDuxiang" runat="server"></asp:Label>
				  </td>
				  <td width="182" align="right">年龄范围：</td>
				  <td width="182" align="left">
                      <asp:Label ID="lblAge" runat="server"></asp:Label>
				  </td>
				 </tr>
				 <tr>
				  <td height="30" align="right">学历要求：</td>
				  <td align="right" style="text-align: left">
                      <asp:Label ID="lblXueli" runat="server"></asp:Label>
				  </td>
				  <td align="right">薪金范围：</td>
				  <td align="right" style="text-align: left">
                      <asp:Label ID="lblMonery" runat="server"></asp:Label>
				  </td>
				 </tr>
				 <tr>
				  <td height="30" align="right">相关专业：</td>
				  <td align="right" style="text-align: left">
                      <asp:Label ID="lblZhuanye" runat="server"></asp:Label>
				  </td>
				  <td align="right">结束时间：</td>
				  <td align="right" style="text-align: left">
                      <asp:Label ID="lblEndtime" runat="server"></asp:Label>
				  </td>
				 </tr>
			   </table>
			   <div class="divjobcontenttd">
			     <div class="divjobcontenttd1"> <img src="images/xuan.png" />职位描述：</div>
				 <div class="divjobcontenttd2">
                     <asp:Label ID="lblMiaoshu" runat="server"></asp:Label>
				 </div>
			   </div>
			   
			   <div class="divjobcontenttd">
			     <div class="divjobcontenttd1"> <img src="images/xuan.png" />联系方式：</div>
				 <div class="divjobcontenttd2">
                     <asp:Label ID="lblLianxi" runat="server"></asp:Label>
				 </div>
			   </div>
			  </div>
			</div>
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
    </form>
</body>
</html>
