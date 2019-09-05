<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xiangmu.aspx.cs" Inherits="Maticsoft.Web.xiangmu" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市宏润众达科技有限公司-项目咨询</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/lanrenxixi.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="Stylesheet" type="text/css" />
    <link href="../style/lanrenxixi.css" rel="stylesheet" type="text/css" />
    <link href="../style/css.css" rel="stylesheet" type="text/css" />
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
		    <div class="divjies1"><img src="images/xuan.png" width="15" height="15" />项目咨询</div>
			<div class="divjies2">
			  
			  <div class="divNews" style="text-align: center">
			   
               <asp:DataList ID="datazixun" runat="server">
                 <ItemTemplate>
                   <div class="divNewscontent">
			     <div class="divNewscontent1">
				   <div class="divNewscontent11">
				     <img src="images/news.png" />
				      <%#Eval("zixunTitle")%> 
				   </div>
				   <div class="divNewscontent12"><%--( <%#Eval("zixuntime")%> )--%>
				    <%#((DateTime)Eval("zixuntime")).ToString("yyyy-MM-dd")%>
				   </div>
			     </div>
				 <div class="divNewscontent1" align="left" style="text-align:left;" >
				   &nbsp; 答：<%#Eval("ZiXundaan")%>
			     </div>
			   </div>
                 </ItemTemplate>
               </asp:DataList>
                  <asp:Label ID="lblpage" runat="server" Font-Size="9pt"></asp:Label></div>
			 <div class="divzixunxiang">
			   <div class="divzixun">
			      <img src="images/proe.jpg" width="30" height="21" />用户提问
			   </div>
			   <div class="divzixun1">
			     <div class="divzixun2">
				   <div class="divzixun21">提问用户：</div>
				   <div class="divzixun22">
                       &nbsp;<asp:TextBox ID="txtusename" runat="server" BackColor="White"></asp:TextBox>
                       <asp:Label ID="lblusename" runat="server" Font-Size="9pt" ForeColor="#FF3300"></asp:Label></div>
			     </div>
				 <div class="divzixun2">
				   <div class="divzixun21">联系电话：</div>
				   <div class="divzixun22">
                       &nbsp;<asp:TextBox ID="txtlinphoto" runat="server" BackColor="White"></asp:TextBox>
                       <asp:Label ID="lbllinkphoto" runat="server" Font-Size="9pt" ForeColor="#FF3300"></asp:Label></div>
			     </div>
				 <div class="divzixun2">
				   <div class="divzixun21">提问标题：</div>
				   <div class="divzixun22">
                       &nbsp;<asp:TextBox ID="txttitle" runat="server" BackColor="White"></asp:TextBox>
                       <asp:Label ID="lnltitle" runat="server" Font-Size="9pt" ForeColor="#FF3300"></asp:Label></div>
			     </div>
				 <div class="divzixun3">
				   <div class="divzixun23">提问内容：</div>
				   <div class="divzixun22">
                       &nbsp;<asp:TextBox ID="txtcontent" runat="server" TextMode="MultiLine" Width="470px" Height ="150px" BackColor="White"></asp:TextBox></div>
			     </div>
				 <div class="divzixun2" style=" margin-top:20px;">
                     <asp:Button ID="btnok" runat="server" Text="提交信息" OnClick="btnok_Click" />
                     <asp:Button ID="btncanel" runat="server" Text="重置信息" OnClick="btncanel_Click" />
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
    </div>
    </form>
</body>
</html>
