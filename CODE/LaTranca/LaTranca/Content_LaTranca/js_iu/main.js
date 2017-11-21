try {
    var Mensaje = function (options) {
        try {
            _this = this;
            this.tipo = options.tipo || 'mensaje';
            this.titulo = options.titulo || '';
            this.mensaje = options.mensaje || '';

            switch (this.tipo) {

                case 'exito':
                    this.className = 'with-icon check-circle success';
                    break;
                case 'informacion':
                    this.className = 'with-icon question-circle primary';
                    break;
                case 'advertencia':
                    this.className = 'with-icon exclamation-circle warning';
                    break;
                case 'error':
                    this.className = 'with-icon times-circle danger';
                    break;
            }

            this.enviarMensaje = function () {
                $.gritter.add({
                    title: this.titulo,
                    text: this.mensaje,
                    time: 2000,
                    class_name: this.className
                });
            }
        } catch (e) {

        }
    }
} catch (e) {

}

$(document).ready(function () {


	$("#portfolio-contant-active").mixItUp();


	$("#testimonial-slider").owlCarousel({
	    paginationSpeed : 500,      
	    singleItem:true,
	    autoPlay: 3000,
	});




	$("#clients-logo").owlCarousel({
		autoPlay: 3000,
		items : 5,
		itemsDesktop : [1199,5],
		itemsDesktopSmall : [979,5],
	});

	$("#works-logo").owlCarousel({
		autoPlay: 3000,
		items : 5,
		itemsDesktop : [1199,5],
		itemsDesktopSmall : [979,5],
	});


	// google map
		var map;
		function initMap() {
		  map = new google.maps.Map(document.getElementById('map'), {
		    center: {lat: -34.397, lng: 150.644},
		    zoom: 8
		  });
		}


	// Counter

	$('.counter').counterUp({
        delay: 10,
        time: 1000
    });


});




