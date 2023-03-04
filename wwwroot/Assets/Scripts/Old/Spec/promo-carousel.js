$(function() {
	
	/* CAROUSEL/PROMO
		- DOCUMENTATION: 
			http://sorgalla.com/projects/jcarousel/
	-------------------------------------------------- */	
	function promoCarouselInitCallback(carousel) {
		//Activate buttons
	    jQuery('.carouselControls a').bind('click', function() {
	        carousel.scroll(jQuery.jcarousel.intval(jQuery(this).text()));
	        carousel.startAuto(0);
	        return false;
	    });
	    
		//next btn
	    jQuery('#carouselNext').bind('click', function() {
	        carousel.next();
	        carousel.startAuto(0);
	        return false;
	    });
	    
		//prev btn
	    jQuery('#carouselPrev').bind('click', function() {
	        carousel.prev();
	        carousel.startAuto(0);
	        return false;
	    });
	
	    /* PAUSE ON HOVER
		-------------------------------------------------- */
	    carousel.clip.hover(function() {
	        carousel.stopAuto();
	    }, function() {
	        carousel.startAuto();
	    });
	    
	}; // end: promoCarouselInitCallback
	
	
	function promoCarouselItemFirstInCallback(carousel, item, idx, state) {
		var sNum = idx;
		//switch(sNum){
//			case 1:
//	        	$('ul.carouselControls li a').removeClass('active');
//	        	$('a.slide1').toggleClass('active');
//        	break;
//        	
//        	case 2:
//	        	$('ul.carouselControls li a').removeClass('active');
//	        	$('a.slide2').toggleClass('active');
//			break;
//			
//			case 3:
//	        	$('ul.carouselControls li a').removeClass('active');
//	        	$('a.slide3').toggleClass('active');
//        	break;
//        	
//			case 4:
//	        	$('ul.carouselControls li a').removeClass('active');
//	        	$('a.slide4').toggleClass('active');
//        	break;
//        	
//			case 5:
//	        	$('ul.carouselControls li a').removeClass('active');
//	        	$('a.slide5').toggleClass('active');
//        	break;
//        	
//			case 6:
//	        	$('ul.carouselControls li a').removeClass('active');
//	        	$('a.slide6').toggleClass('active');
//        	break;

			
	        	$('ul.carouselControls li a').removeClass('active');
	        	$('a.slide'+sNum).toggleClass('active');
        	
		//}
	};
	
    jQuery("#promoCarousel").jcarousel({
        scroll: 1,
        auto: 5,
        wrap: 'both',
        initCallback: promoCarouselInitCallback,
        itemFirstInCallback: promoCarouselItemFirstInCallback,
        // This tells jCarousel NOT to autobuild prev/next buttons
        buttonNextHTML: null,
        buttonPrevHTML: null
    });
    
});