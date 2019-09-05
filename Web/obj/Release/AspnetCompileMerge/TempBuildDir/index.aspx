<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Maticsoft.Web.Default" %>
<%@ Register Src="~/Controls/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/buttom.ascx" TagName="buttom" TagPrefix="ucl" %>
<%@ Register Src="~/Controls/left.ascx" TagName="left" TagPrefix="ucl" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>北京三联腾达南京分公司</title>
    <link href="style/css.css" rel="stylesheet" type="text/css" />
    <link href="style/lanrenxixi.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jssty.js"></script>
    <script src="js/jquery-1.4a2.min.js" type="text/javascript"></script>
<script src="js/jquery.KinSlideshow-1.2.1.min.js" type="text/javascript"></script>
<script type="text/javascript">
$(function(){
	$("#KinSlideshow").KinSlideshow();
})
</script>
</head>
<body>
    <form id="form1" runat="server">
     <div align="center">
       <table width="1000" border ="0" cellpadding ="0" cellspacing ="0">
         <tr>
          <td align="left"> 
           <uc1:top ID="Top1" runat="server" />
          </td>
         </tr>
         <tr>
          <td align="left" valign="top">
            <div class="divzhong">
     <!--中间内容 -->
	 <div class="divxun">
	  <!--中间内容 -->

          <div class="divzhongleft">
		    <!--左边内容 -->
		     <ucl:left ID="left1" runat ="server" />
			<!--左边内容 -->
		  </div>
		  
		  <div class="divzhongjian" align="center">
		    <!--中间内容 -->
			<div class="divzhongjian1">
			  <div class="divzhongxun1">
			    <div class="divzhongxun11">公司动态</div>
				<div class="divzhongxun12">
				  <div class="divzhongzhuan" style="float:left">
				   <div id="KinSlideshow" style="visibility:hidden;">
        <a href="#" target="_blank"><img src="images/1.jpg" alt=" " width="200" height="180" /></a>
        <a href="#" target="_blank"><img src="images/2.jpg" alt=" " width="200" height="180" /></a>
        <a href="#" target="_blank"><img src="images/3.jpg" alt=" " width="200" height="180" /></a>
 </div>
 
				  </div>
				  <div class="divzhongzhuan1" style="float:left">
				     <asp:DataList ID="datanews" runat="server">
                       <ItemTemplate>
                         <div class="divzhongzhuan11">
					      <div class="divzhongzhuan12" align="left" >
					       <a href ="NewsInfo.aspx?NewsID=<%#Eval("NewsID") %>">
					         <%#Eval("NewsTitle")%>
					       </a>
					      </div>
					      <div class="divzhongzhuan13">
					         <%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>
					      </div>
				          </div>
                       </ItemTemplate>
                      </asp:DataList>
                  </div>
				</div>
			  </div>
			  <div class="divzhongxun2">
			    <div class="divzhongxun21">
				  <div class="divzhongxun2left">
				   <img src="images/topleft.jpg" width="14" height="27" />
				  </div>
				  <div class="divzhongxun2zhong">
				    <div class="divzhongxun2zhong11">行业资讯</div>
				    <div class="divzhongxun2zhong1">mone</div>
				  </div>
				  <div class="divzhongxun2left">
				    <img src="images/topright.jpg" width="14" height="27" />
				  </div>
				</div>
				<div class="divlel">
				  <div class="cell1">
                    <div class="up1"> </div>
                    <div class="up2"> </div>
                    <div class="up31"> </div>
                    <div class="content1">
					  
					    <asp:DataList ID="dataniche" runat="server">
                          <ItemTemplate >
                            <div class="content11">
					         <div class="content13"  align="left"  style="text-align:left ">
					           <img src="images/news.png" />    
						       <a href="NicheInfo.aspx?NicheID=<%#Eval("NicheID") %>"><%#Eval("NicheTitle") %></a>
						     </div>
						     <div class="content12">
						      (<%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>)
						     </div>
					         </div>
                          </ItemTemplate>
                        </asp:DataList>
                        </div>
                    <div class="down1">  </div>
                    <div class="down2">  </div>
                    <div class="down3">  </div>
                  </div>
				</div>
			  </div>
			  <div class="divzhongxun3">
			    <div class="dhooo_tab">
                 <ul class="tab_btn" id="myTab_btns1">
                  <li class="hot">产品展示</li><li>行业知识</li>
				  <li>推荐产品</li><li>项目咨询</li>
				  <li>技术资料</li>
                 </ul>
                 <div class="main" id="main1">
                 <div class="shell">
                  <ul id="content1">
                   <li>
					<div class="content1li">
                        <asp:DataList ID="datapro" runat="server" RepeatDirection="Horizontal">
                          <ItemTemplate>
                            <div class="content1li1">
					         <div class="content1li2">
                                 <asp:Image ID="Image1" runat="server"   width="110" height="120" ImageUrl =<%#Eval("ImageURL") %> />
					          </div>
					          <div class="content1li3" style="text-align:left; padding-left:20px;">名称：
					            <a href="productInfo.aspx?ProID=<%#Eval("ProID") %>"><%#Eval("ProName") %></a>
					          </div>
					          <div class="content1li3" style="text-align:left; padding-left:20px;">价格：
					            <%#Eval("ProMonery")%>
					          </div>
					        </div>
                          </ItemTemplate>
                        </asp:DataList>
                        
					</div>
									
				   </li>
                    <li>
					  
                     <asp:DataList ID="dataweilan" runat="server">
                      <ItemTemplate >
                        <div class="indexpro">
					    <div class="indexpro1"> 
						  <img src="images/news.png" />
				          <a href="zhishiInfo.aspx?WeiID=<%#Eval("WeiID") %>"><%#Eval("WeiTitle")%></a>
						</div>
						<div class="indexpro2">
						   (<%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>)
						</div>
					  </div>
                      </ItemTemplate>
                     </asp:DataList>
                     </li>
                    <li>
					  <div class="content1li">
					<asp:DataList ID="datatoujian" runat="server" RepeatDirection="Horizontal">
                          <ItemTemplate>
                            <div class="content1li1">
					         <div class="content1li2">
                                 <asp:Image ID="Image1" runat="server"   width="110" height="120" ImageUrl =<%#Eval("ImageURL") %> />
					          </div>
					          <div class="content1li3">名称：
					            <a href="productInfo.aspx?ProID=<%#Eval("ProID") %>"><%#Eval("ProName") %></a>
					          </div>
					          <div class="content1li3">价格：
					            <%#Eval("ProMonery")%>
					          </div>
					        </div>
                          </ItemTemplate>
                        </asp:DataList>
					</div>
					</li>
                    <li>
					  <asp:DataList ID="dataxiangmo" runat="server">
                         <ItemTemplate>
                           <div class="indexpro">
					        <div class="indexpro1"> 
						     <a href="xiangmu.aspx"> <%#Eval("zixunTitle")%> </a>
						    </div>
						   <div class="indexpro2">
						     <%#((DateTime)Eval("zixuntime")).ToString("yyyy-MM-dd")%>
						   </div>
					      </div>  
                         </ItemTemplate>
                      </asp:DataList>
					    
					</li>
                    <li>
					   <asp:DataList ID="datajishu" runat="server">
                         <ItemTemplate>
                           <div class="indexpro">
					        <div class="indexpro1"> 
						     <a href="jishu.aspx"><asp:Label ID="lblJishuTitle" runat="server" Text =<%# Eval("JishuTitle") %>></asp:Label></a>
						    </div>
						    <div class="indexpro2">
						     <asp:Label ID="lblFatime" runat="server" Text =<%#((DateTime)Eval("Fatime")).ToString("yyyy-MM-dd")%>  ></asp:Label>
						    </div>
					       </div>
                         </ItemTemplate>
                        </asp:DataList>
					 </li> 
                   </ul>
                  </div>
                 </div>
				 <script type="text/javascript" src="js/scroll.js"></script>
                </div>
			  </div>
			</div>
			<!--中间内容 -->
		  </div>
		  <div class="divzhongleft">
		    <!--右边内容 -->
			<div class="divright">
			  <div class="divzhongleft1">
			  <div class="divzhongleft11">
			    网站公告
			  </div>
			  <div class="divzhuce">
			   <marquee direction="up" onmousemove="this.stop();" onmouseout="this.start();" 
			    width="200" height="160">
				<div class="marquee1">
				   <asp:Label ID="lblgonggao" runat="server" ></asp:Label>		
				</div>
			   </marquee>
			  </div>
			</div>
			
			<div class="divrightlian1">
			  <div class="divzhongleft22">
			    推荐服务
			  </div>
			  <div class="divduwu">
			   
			  </div>
                <asp:DataList ID="datafuwu" runat="server">
                <ItemTemplate>
                 <div class="divduwu" style="padding-left:10px;">
			      <img src="images/bi.gif" width="6" height="6" />
			      <a href="fuwuInfo.aspx?fuwuID=<%#Eval("fuwuID") %>" ><%# Eval("fuwuTitle")%></a>
			     </div>
               </ItemTemplate>
               <ItemStyle  HorizontalAlign="Left" />
                </asp:DataList>
			</div>
			<div class="divrightlian">
			  <img src="images/ewrw.jpg" />
			</div>
			<div class="divrightlian">
			   <img src="images/fre.jpg" />
			</div>
			<div class="divrightlian">
			   <img src="images/fre.jpg" />
			</div>
			</div>
			<!--右边内容 -->
		  </div>

	  <!--中间内容 -->
	 </div>
	 <!--中间内容 -->
   </div>
          </td>
         </tr>
         <tr>
          <td align="left">
            <ucl:buttom ID="buttom1" runat="server" />
          </td>
         </tr>
       </table>
       
       
    </div>
    </form>
</body>
</html>
