<%@ Control Language="c#" AutoEventWireup="True" Codebehind="top.ascx.cs" Inherits="Maticsoft.Web.Controls.CopyRight1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<link href="../style/css.css" rel="stylesheet" type="text/css" />
<link href="../style/lanrenxixi.css"rel="stylesheet" type="text/css" />
<script type="text/javascript" src ="../js/swfobject.js" ></script>

<div class="divtitle">
     <!--头部内容 -->
	 <div class="divding" style="text-align: right">
      <a  href="../index.aspx" onClick="this.style.behavior='url(#default#homepage)';this.setHomePage('../index.aspx');">设为首页</a>
       <a href="Javascript:window.external.addFavorite(document.location.href,document.title)">加入收藏</a> 
      <a href ="../product.aspx" >产品展示</a>
     </div>
	 <div class="divtop">
	   <div class="divtop01">
	     <img src="../images/首页_04.gif" />
	   </div> 
	  <div class="divtop02">
	    <div class="divtop03">
		  <div class="divtop04"><a href="../index.aspx">网站首页</a></div>
		  <div class="divtop04"><a href="../jieshao.aspx">公司简介</a></div>
		  <div class="divtop04"><a href="../NewsList.aspx">新闻动态</a></div>
		  <div class="divtop04"><a href="../product.aspx">产品欣赏</a></div>
		  <div class="divtop04"><a href="../dinggou.aspx">订购产品</a></div>
		  <div class="divtop04"><a href="../success.aspx">案例展示</a></div>
		  <div class="divtop04"><a href="../NicheList.aspx">行业资讯</a></div>
		  <div class="divtop04"><a href="../companyway.aspx">联系我们</a></div>
		</div>
	  </div>
	 </div>
	 <div class="divtop1">
	  
	   <div id="FocusObj" ></div>
          <script type="text/javascript">
					<!--//
					var focus_width=1000;
					var focus_height=299;
					var text_height=0;
					var swf_height=focus_height + 0;
					var pics="../images/01.jpg###../images/02.jpg###../images/03.jpg###";
					var links="#";
					var texts=" ";
					var descripts=" ";
					var fo = new SWFObject("../images/pix.swf", "_FocusObj", focus_width, swf_height, "7","FFFFFF");
					fo.addVariable("pics", pics);
					fo.addVariable("links", links);
					fo.addVariable("texts", texts); 
					fo.addVariable("descripts", descripts);
					fo.addVariable("borderwidth", focus_width);
					fo.addVariable("borderheight", focus_height);
					//fo.addVariable("textheight", text_height);
					fo.addVariable("border_color", "#FFFFF"); 
					//fo.addVariable("fontsize", "24"); 
					//fo.addVariable("fontcolor", "FFFFFF");
					fo.addVariable("is_border", "");
					fo.addVariable("is_text", "0");
					fo.addParam("wmode", "opaque");
					fo.write("FocusObj");
				//-->
				</script>
	  
	 </div>
	 <!--头部内容 -->
   </div>