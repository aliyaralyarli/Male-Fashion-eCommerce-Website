"use strict";!function(a){a(window).on("load",function(){if(a(".loader").fadeOut(),a("#preloder").delay(200).fadeOut("slow"),AOS.init(),a(".filter__controls li").on("click",function(){a(".filter__controls li").removeClass("active"),a(this).addClass("active")}),a(".product__filter").length>0){var e=document.querySelector(".product__filter");mixitup(e)}}),a(".set-bg").each(function(){var e=a(this).data("setbg");a(this).css("background-image","url("+e+")")}),a(".search-switch").on("click",function(){a(".search-model").fadeIn(400)}),a(".search-close-switch").on("click",function(){a(".search-model").fadeOut(400,function(){a("#search-input").val("")})}),a(".mobile-menu").slicknav({prependTo:"#mobile-menu-wrap",allowParentLinks:!0}),a(".collapse").on("shown.bs.collapse",function(){a(this).prev().addClass("active")}),a(".collapse").on("hidden.bs.collapse",function(){a(this).prev().removeClass("active")}),a(".canvas__open").on("click",function(){a(".offcanvas-menu-wrapper").addClass("active"),a(".offcanvas-menu-overlay").addClass("active")}),a(".offcanvas-menu-overlay").on("click",function(){a(".offcanvas-menu-wrapper").removeClass("active"),a(".offcanvas-menu-overlay").removeClass("active")}),a(".hero__slider").owlCarousel({loop:!0,margin:0,items:1,dots:!1,nav:!0,navText:["<span class='arrow_left'><span/>","<span class='arrow_right'><span/>"],animateOut:"fadeOut",animateIn:"fadeIn",smartSpeed:1200,autoHeight:!1,autoplay:!1}),a("select").niceSelect(),a(".product__color__select label, .shop__sidebar__size label, .product__details__option__size label").on("click",function(){a(".product__color__select label, .shop__sidebar__size label, .product__details__option__size label").removeClass("active"),a(this).addClass("active")}),a(".nice-scroll").niceScroll({cursorcolor:"#0d0d0d",cursorwidth:"5px",background:"#e5e5e5",cursorborder:"",autohidemode:!0,horizrailenabled:!1});var e=new Date,n=String(e.getDate()).padStart(2,"0"),t=String(e.getMonth()+1).padStart(2,"0"),s=e.getFullYear();12==t?(t="01",s+=1):(t=parseInt(t)+1,t=String(t).padStart(2,"0"));var i,o=t+"/"+n+"/"+s;a("#countdown").countdown(o,function(e){a(this).html(e.strftime("<div class='cd-item'><span>%D</span> <p>Days</p> </div><div class='cd-item'><span>%H</span> <p>Hours</p> </div><div class='cd-item'><span>%M</span> <p>Minutes</p> </div><div class='cd-item'><span>%S</span> <p>Seconds</p> </div>"))}),a(".video-popup").magnificPopup({type:"iframe"}),(i=a(".pro-qty")).prepend('<span class="fa fa-angle-up dec qtybtn"></span>'),i.append('<span class="fa fa-angle-down inc qtybtn"></span>'),i.on("click",".qtybtn",function(){var e=a(this),n=e.parent().find("input").val();if(e.hasClass("inc"))var t=parseFloat(n)+1;else if(n>0)t=parseFloat(n)-1;else t=0;e.parent().find("input").val(t)}),(i=a(".pro-qty-2")).prepend('<span class="fa fa-angle-left dec qtybtn"></span>'),i.append('<span class="fa fa-angle-right inc qtybtn"></span>'),i.on("click",".qtybtn",function(){var e=a(this),n=e.parent().find("input").val();if(e.hasClass("inc"))var t=parseFloat(n)+1;else if(n>0)t=parseFloat(n)-1;else t=0;e.parent().find("input").val(t)}),a(".cn_num").each(function(){a(this).prop("Counter",0).animate({Counter:a(this).text()},{duration:4e3,easing:"swing",step:function(e){a(this).text(Math.ceil(e))}})})}(jQuery);