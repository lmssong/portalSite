<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productInfo.aspx.cs" Inherits="Maticsoft.Web.productInfo" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-产品展示</title>
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
			 <img src="images/xuan.png" width="15" height="15" />产品展示</div>
			<div class="divjies2">
			  <div class="divchanping">
			    <div class="divchanping1">
				  <div class="divchanping11">
				   <strong style="padding-left:40px;"> 
                       <asp:Label ID="lblProName" runat="server"></asp:Label>
                   </strong>
                  </div>
				  <div class="divchanping11">
				    <div class="divchanping12">
					<img src="images/proe.jpg" width="30" height="21" />产品名称：</div>
					<div class="divchanping13">
                        <asp:Label ID="lblProName1" runat="server"></asp:Label></div>
				  </div>
				  <div class="divchanping11">
				    <div class="divchanping12">
					<img src="images/proe.jpg" width="30" height="21" />产品型号：</div>
					<div class="divchanping13">
                        <asp:Label ID="lblProXingTitle" runat="server"></asp:Label></div>
				  </div>
				  <div class="divchanping11">
				    <div class="divchanping12">
					<img src="images/proe.jpg" width="30" height="20" />产品类型：</div>
					<div class="divchanping13">
                        <asp:Label ID="lblProTypeTitle" runat="server"></asp:Label></div>
				  </div>
				  <div class="divchanping11">
				    <div class="divchanping12">
					<img src="images/proe.jpg" width="30" height="21" />发布时间：</div>
					<div class="divchanping13">
                        <asp:Label ID="lblFatime" runat="server"></asp:Label></div>
				  </div>
				  <div class="divchanping11">
				    <div class="divchanping12">
					<img src="images/proe.jpg" width="30" height="21" />点击次数：</div>
					<div class="divchanping13">
                        <asp:Label ID="lblHitNum" runat="server" ></asp:Label></div>
				  </div>
				</div>
			    <div class="divchanping2">
                    <asp:Image ID="ImgImageURL" runat="server"  width="200" height="200" />
				</div>
			  </div>
			<div class="divchanping4">
			  <div class="divchanping41">
			    <img src="images/proe.jpg" />
				产品描述
			  </div>
			  <div class="divchanping42">
                  <asp:Label ID="lblProcontent" runat="server"></asp:Label></div>
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
