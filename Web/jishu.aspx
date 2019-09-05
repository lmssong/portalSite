<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jishu.aspx.cs" Inherits="Maticsoft.Web.jishu" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/left1.ascx" TagName="left" TagPrefix="uc2" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司-技术资料</title>
    <link href="style/css.css" rel="Stylesheet" type="text/css" />
    <link href="style/lanrenxixi.css" rel="Stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server" method =post >
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
			 <img src="images/xuan.png" width="15" height="15" />下载专区
			</div>
			<div class="divjies2" style="text-align: center">
			  <div class="xiazai">
			    <img src="images/proe.jpg" />技术资料下载
			  </div>
			  
                <asp:DataList ID="datajishu" runat="server" OnItemCommand="datajishu_ItemCommand" OnItemDataBound="datajishu_ItemDataBound">
                 <ItemTemplate>
                    <div class="xiazaicontent">
			    <div class="xiazaicontent1">
                    <asp:Image ID="Image1" runat="server"  width="140" height="140" ImageUrl=<%# Eval("ImageURL") %> />
				</div>
			    <div class="xiazaicontent2">
				  <div class="xiazaicontent3">
				    <div class="xiazaicontent31">文件名称：</div>
				    <div class="xiazaicontent32" style="text-align:left">
                        <asp:Label ID="lblJishuTitle" runat="server" Text =<%# Eval("JishuTitle") %>></asp:Label>
				    </div>
				  </div>
				  <div class="xiazaicontent3">
				    <div class="xiazaicontent31">文件大小：</div>
				    <div class="xiazaicontent32" style="text-align:left">
                        <asp:Label ID="lblJishuNum" runat="server" Text =<%# Eval("JishuNum") %>></asp:Label>
				    </div>
				  </div>
				  <div class="xiazaicontent3">
				    <div class="xiazaicontent31">发布日期：</div>
				    <div class="xiazaicontent32" style="text-align:left">
                        <asp:Label ID="lblFatime" runat="server" Text =<%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>  ></asp:Label>
				    </div>
				  </div>
				  <div class="xiazaicontent3">
				    <div class="xiazaicontent31">下载类别：</div>
				    <div class="xiazaicontent32" style="text-align:left">
                        <asp:Label ID="lbljishuType" runat="server" Text =<%# Eval("jishuType") %>></asp:Label>
				    </div>
				  </div>
				  <div class="xiazaicontent3">
				    <div class="xiazaicontent31">点击下载：</div>
				    <div class="xiazaicontent32" style="text-align:left">
                       
                       <asp:ImageButton ID="btndon" runat="server" ImageUrl="~/images/aniu.png" CommandArgument =<%#Eval("JishuID") %> CommandName="download" /> 
                      
				    </div>
				  </div>
				</div>
			  </div>
                 </ItemTemplate>
                </asp:DataList>
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
    </form>
</body>
</html>
