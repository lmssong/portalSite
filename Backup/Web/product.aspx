<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Maticsoft.Web.product" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-产品展示</title>
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

        <div class="content2">
         <div class="divzhongleft">
		  <!--左边内容 -->
		    <uc2:left ID="Left1" runat="server" />
          <!--左边内容 -->
		 </div>
		 <div class="divjies"> 
		    <div class="divjies1">
			 <img src="images/xuan.png" width="15" height="15" />
                产品展示
			</div>
			<div class="divjies2" style="text-align: center">
			  <div class="divproduct">
               <asp:DataList ID="datapro" runat="server" RepeatColumns="2" OnItemDataBound="datapro_ItemDataBound">
                 <ItemTemplate>
                   <div class="divproductjia1" align="left" style="text-align:left;">
				      <div class="divproductjia2">
                        <asp:Image ID="ImgImageURL" runat="server" width="150" height="150" ImageUrl='<%#Eval("ImageURL") %>' />
					  </div>
					  <div class="divproductjia4">
					   <div class="divproductjia3">产品名称：
					   <a href ="productInfo.aspx?ProID=<%#Eval("ProID") %>">  
					     <%#GetCut(Eval("ProName"),6) %>
					   </a>
					  </div>
					   <div class="divproductjia3">产品类型：
					     <asp:Label ID="lblProTypeID" runat="server" Text= <%#Eval("ProTypeID")%>></asp:Label>
					  </div>
					   <div class="divproductjia3">产品型号：
					    
                        <asp:Label ID="lnlProXingID" runat="server" Text=<%#Eval("ProXingID") %>></asp:Label>
					  </div>
				 	  <div class="divproductjia3">
                         <%--<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/cha.jpg" width="85" height="25" PostBackUrl ='productInfo.aspx?ProID=<%#Eval("ProID") %> '   /> --%>
                        <a href ="productInfo.aspx?ProID=<%#Eval("ProID") %>"> 
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/cha.jpg" width="85" height="25" />
                        </a> 
				 	  </div>
				    </div>
				  </div>
                 </ItemTemplate>
                 <ItemStyle HorizontalAlign="Left" />
               </asp:DataList>
                
			  </div>
                <asp:Label ID="lblpage" runat="server"></asp:Label></div>
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
