/*

Template: Real Villa - Real Estate HTML5 Template
Author: potenzaglobalsolutions
Design and Developed by: potenzaglobalsolutions.com

NOTE: This file contains all scripts for the actual Template.

*/

/*================================================
[  Table of contents  ]
================================================

:: Menu
:: Tooltip
:: Counter
:: Owl carousel
:: Slickslider
:: Magnific Popup
:: Datetimepicker
:: Select2
:: BgSlider
:: Range Slider
:: Countdown
:: Scrollbar
:: Back to top

======================================
[ End table content ]
======================================*/
//POTENZA var

(function ($) {
    "use strict";
    var POTENZA = {};

    /*************************
      Predefined Variables
    *************************/
    var $window = $(window),
        $document = $(document),
        $body = $('body'),
        $countdownTimer = $('.countdown'),
        $counter = $('.counter');
    //Check if function exists
    $.fn.exists = function () {
        return this.length > 0;
    };

    /*************************
          Menu
      *************************/
    POTENZA.dropdownmenu = function () {


        if ($('.navbar').exists()) {
            $('.dropdown-menu a.dropdown-toggle').on('click', function (e) {
                if (!$(this).next().hasClass('show')) {
                    $(this).parents('.dropdown-menu').first().find('.show').removeClass("show");
                }
                var $subMenu = $(this).next(".dropdown-menu");
                $subMenu.toggleClass('show');
                $(this).parents('li.nav-item.dropdown.show').on('hidden.bs.dropdown', function (e) {
                    $('.dropdown-submenu .show').removeClass("show");
                });
                return false;
            });


        }
    };

    /*************************
             sticky
    *************************/
    //POTENZA.isSticky = function () {
    //    $(window).scroll(function () {
    //        if ($(this).scrollTop() > 150) {
    //            $('.header-sticky').addClass('is-sticky');
    //        } else {
    //            $('.header-sticky').removeClass('is-sticky');
    //        }
    //    });
    //};
    POTENZA.isSticky = function () {
        let prevScrollPos = $(window).scrollTop();

        function handleScroll() {
            const currentScrollPos = $(window).scrollTop();
            const header = $(".header");

            if (prevScrollPos > currentScrollPos) {
                header.addClass("_visible").removeClass("_hidden");
            } else {
                header.addClass("_hidden").removeClass("_visible");
            }

            prevScrollPos = currentScrollPos;
        }

        $(window).scroll(handleScroll);
    }


    /*************************
          Tooltip
    *************************/
    $('[data-toggle="tooltip"]').tooltip();
    $('[data-toggle="popover"]').popover()

    /*************************
           counter
    *************************/
    POTENZA.counters = function () {
        var counter = jQuery(".counter");
        if (counter.length > 0) {
            $counter.each(function () {
                var $elem = $(this);
                $elem.appear(function () {
                    $elem.find('.timer').countTo();
                });
            });
        }
    };

    /*************************
           Owl carousel
    *************************/
    POTENZA.carousel = function () {
        var owlslider = jQuery("div.owl-carousel");
        if (owlslider.length > 0) {
            owlslider.each(function () {
                var $this = $(this),
                    $items = ($this.data('items')) ? $this.data('items') : 1,
                    $loop = ($this.attr('data-loop')) ? $this.data('loop') : true,
                    $navdots = ($this.data('nav-dots')) ? $this.data('nav-dots') : false,
                    $navarrow = ($this.data('nav-arrow')) ? $this.data('nav-arrow') : false,
                    $autoplay = ($this.attr('data-autoplay')) ? $this.data('autoplay') : true,
                    $autospeed = ($this.attr('data-autospeed')) ? $this.data('autospeed') : 5000,
                    $smartspeed = ($this.attr('data-smartspeed')) ? $this.data('smartspeed') : 1000,
                    $autohgt = ($this.data('autoheight')) ? $this.data('autoheight') : false,
                    $space = ($this.attr('data-space')) ? $this.data('space') : 30,
                    $animateOut = ($this.attr('data-animateOut')) ? $this.data('animateOut') : false;

                $(this).owlCarousel({
                    loop: $loop,
                    items: $items,
                    responsive: {
                        0: {
                            items: $this.data('xx-items') ? $this.data('xx-items') : 1
                        },
                        480: {
                            items: $this.data('xs-items') ? $this.data('xs-items') : 1
                        },
                        768: {
                            items: $this.data('sm-items') ? $this.data('sm-items') : 2
                        },
                        980: {
                            items: $this.data('md-items') ? $this.data('md-items') : 3
                        },
                        1200: {
                            items: $items
                        }
                    },
                    dots: $navdots,
                    autoplayTimeout: $autospeed,
                    smartSpeed: $smartspeed,
                    autoHeight: $autohgt,
                    margin: $space,
                    nav: $navarrow,
                    navText: ["<i class='fas fa-chevron-left'></i>", "<i class='fas fa-chevron-right'></i>"],
                    autoplay: $autoplay,
                    autoplayHoverPause: true
                });
            });
        }
    }

    /*************************
            Swiper thumbs slider
    *************************/

    var swiper = new Swiper(".swiper-nav", {
        spaceBetween: 10,
        slidesPerView: 3.5,
        freeMode: true,
        watchSlidesProgress: true,
        loop: true,
    });

    var swiper2 = new Swiper(".swiper-for", {
        spaceBetween: 10,
        effect: "fade",
        loop: true,
        navigation: {
            nextEl: ".next_slick",
            prevEl: ".previous_slick",
        },

        thumbs: {
            swiper: swiper,
        },
    });

    /*************************
        Magnific Popup
    *************************/
    POTENZA.mediaPopups = function () {
        if ($(".popup-single").exists() || $(".popup-gallery").exists() || $('.modal-onload').exists() || $(".popup-youtube, .popup-vimeo, .popup-gmaps").exists()) {
            if ($(".popup-single").exists()) {
                $('.popup-single').magnificPopup({
                    type: 'image'
                });
            }
            if ($(".popup-gallery").exists()) {
                $('.popup-gallery').magnificPopup({
                    delegate: '.owl-item:not(.cloned) a.portfolio-img',
                    type: 'image',
                    tLoading: 'Loading image #%curr%...',
                    mainClass: 'mfp-img-mobile',
                    gallery: {
                        enabled: true,
                        navigateByImgClick: false,
                        preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
                    },

                });
            }
            if ($(".popup-youtube, .popup-vimeo, .popup-gmaps").exists()) {
                $('.popup-youtube, .popup-vimeo, .popup-gmaps').magnificPopup({
                    disableOn: 700,
                    type: 'iframe',
                    mainClass: 'mfp-fade',
                    removalDelay: 160,
                    preloader: false,
                    fixedContentPos: false
                });
            }
            var $modal = $('.modal-onload');
            if ($modal.length > 0) {
                $('.popup-modal').magnificPopup({
                    type: 'inline'
                });
                $(document).on('click', '.popup-modal-dismiss', function (e) {
                    e.preventDefault();
                    $.magnificPopup.close();
                });
                var elementTarget = $modal.attr('data-target');
                setTimeout(function () {
                    $.magnificPopup.open({
                        items: {
                            src: elementTarget
                        },
                        type: "inline",
                        mainClass: "mfp-no-margins mfp-fade",
                        closeBtnInside: !0,
                        fixedContentPos: !0,
                        removalDelay: 500
                    }, 0)
                }, 1500);
            }
        }
    }

    /*************************
        datetimepicker
    *************************/
    POTENZA.datetimepickers = function () {
        if ($('.datetimepickers').exists()) {
            $('#datetimepicker-01, #datetimepicker-02').datetimepicker({
                format: 'L'
            });
            $('#datetimepicker-03, #datetimepicker-04').datetimepicker({
                format: 'LT'
            });
        }
    };

    /*************************
        select2
    *************************/
    POTENZA.select2 = function () {
        if ($('.basic-select').exists()) {
            var select = jQuery(".basic-select");
            if (select.length > 0) {
                $('.basic-select').select2({ dropdownCssClass: 'bigdrop' });
            }

        }
    };

    /*************************
        Range Slider
    *************************/
    POTENZA.rangesliders = function () {
        if ($('.property-price-slider').exists()) {
            var rangeslider = jQuery(".rangeslider-wrapper");
            $("#property-price-slider").ionRangeSlider({
                type: "double",
                min: 0,
                max: 10000,
                from: 1000,
                to: 8000,
                prefix: "$",
                hide_min_max: true,
                hide_from_to: false
            });
        }
    };

    /*************************
             Countdown
    *************************/
    POTENZA.countdownTimer = function () {
        if ($countdownTimer.exists()) {
            $countdownTimer.downCount({
                date: '12/25/2020 12:00:00', // Month/Date/Year HH:MM:SS
                offset: -4
            });
        }
    }

    /*************************
             BgSlider
    *************************/
    POTENZA.bgSlider = function () {
        var $bgSlider = $('#bg-slider');
        if ($bgSlider.exists()) {
            $("#bg-slider").kenburnsy({
                fullscreen: false
            });
        }
    }

    /*************************
        scrollbar
    *************************/
    POTENZA.scrollbar = function () {
        var scrollbar = jQuery(".scrollbar");
        if (scrollbar.length > 0) {
            //Sidebar Scroll
            var scroll_light = jQuery(".scroll_light");
            if (scroll_light.length > 0) {
                $(scroll_light).niceScroll({
                    cursorborder: 0,
                    cursorcolor: "rgba(255,255,255,0.25)"
                });
                $(scroll_light).getNiceScroll().resize();
            }
            // Chat Scroll
            var scroll_dark = jQuery(".scroll_dark");
            if (scroll_dark.length > 0) {
                $(scroll_dark).niceScroll({
                    cursorborder: 0,
                    cursorcolor: "rgba(0,0,0,0.1)"
                });
                $(scroll_dark).getNiceScroll().resize();
            }
        }
    }

    /*************************
        streetview
    *************************/
    POTENZA.streetview = function () {
        var panorama;
        var streetview = jQuery("#street-view");
        if (streetview.length > 0) {
            panorama = new google.maps.StreetViewPanorama(
                document.getElementById('street-view'),
                {
                    position: { lat: 37.869260, lng: -122.254811 },
                    pov: { heading: 165, pitch: 0 },
                    zoom: 1
                }
            );
        }
    };

    /*************************
          streetviewtabs
    *************************/
    POTENZA.streetviewtabs = function () {
        jQuery('.nav-tabs a').on('shown.bs.tab', function (event) {
            var tabName = $(event.target).text();
            if (tabName == 'Street view') {
                POTENZA.streetview();
            }
        });
    }

    /*************************
         Back to top
    *************************/
    POTENZA.goToTop = function () {
        var $goToTop = $('#back-to-top');
        $goToTop.hide();
        $window.scroll(function () {
            if ($window.scrollTop() > 100) $goToTop.fadeIn();
            else $goToTop.fadeOut();
        });
        $goToTop.on("click", function () {
            $('body,html').animate({
                scrollTop: 0
            }, 1000);
            return false;
        });
    }

    /****************************************************
     Serch block rooms section
     ****************************************************/
    POTENZA.searhBlock = function () {


        function checkInputValues(block) {
            const allInputsInBlock = document.querySelectorAll(`${block} input`);
            if (allInputsInBlock) {
                allInputsInBlock.forEach(el => {
                    const title = el.nextElementSibling;
                    if (el.value.trim() !== "") {
                        title.classList.add("active-input");
                    }
                    el.addEventListener("focus", () => {
                        const title = el.nextElementSibling;
                        title.classList.add("active-input");
                    });

                    el.addEventListener("blur", () => {
                        const title = el.nextElementSibling;
                        if (el.value.trim() === "") {
                            title.classList.remove("active-input");
                        }
                    });

                    el.addEventListener("input", () => {
                        const title = el.nextElementSibling;
                        if (el.value.trim() !== "") {
                            title.classList.add("active-input");
                        } else {
                            title.classList.remove("active-input");
                        }
                    });
                });
            }

        }
        function hideBlockIfTextMatches(blockElement, ...stringsToMatch) {
            // Function to hide or show the block based on the selected value
            function updateBlockVisibility() {
                if (stringsToMatch.includes($("#tipas-select").val())) {
                    $(blockElement).show();
                    const select = document.querySelector(`${blockElement} > select`)

                    $(select).select2({
                        dropdownParent: $(blockElement),

                    });

                } else {
                    if ($(blockElement).find('input, select').length > 0) {
                        // Loop through input and select elements and set their values to null or an empty string
                        $(blockElement).find('input, select').each(function () {
                            if ($(this).is('input')) {
                                // Check if it's an input element
                                $(this).val('');
                            } else if ($(this).is('select')) {
                                $(this).val('');
                                $(`${blockElement} > .select2-selection__rendered`).attr('title', 'Visi').text('Visi');
                            }
                        });
                    }
                    $(blockElement).hide();
                }
            }

            // Call the function on page load
            updateBlockVisibility();

            // Add a change event listener to the #tipas-select element
            $("#tipas-select").change(updateBlockVisibility);

        }


        hideBlockIfTextMatches("#kambariu-skaicius-select", "namasSodybaSodoNamas", "butas");
        hideBlockIfTextMatches("#metru-skaicius-select", "patalpos", "butas");
        hideBlockIfTextMatches("#aru-skaicius-select", "sklypas");
        hideBlockIfTextMatches("#namo-tipas-select", "namasSodybaSodoNamas");
        hideBlockIfTextMatches("#sklypo-paskirtis", "sklypas");
        hideBlockIfTextMatches("#patalpu-paskirtis", "patalpos");
        checkInputValues(".advanced-search")

    }

    /****************************************************
   Visi partneriai
   ****************************************************/

    POTENZA.partneriai = function () {
        var $partneriaiVisi = $("#partneriai-visi");
        var $visiPartneriaiBtn = $(".visi-partneriai")
        var $partneriaiOwl = $("#partneriai-owl");

        $partneriaiVisi.css("display", "grid");

        $partneriaiVisi.hide();

        $visiPartneriaiBtn.click(function () {

            $visiPartneriaiBtn.slideToggle()
            $partneriaiVisi.slideToggle();

            $partneriaiOwl.slideToggle();

        });
    }
    /****************************************************
    Serch block rooms section
    ****************************************************/
    POTENZA.select2Width = function () {

        function initializeSelect2(selectElement, dropdownParentElement, dir) {

            $(selectElement).select2({
                dropdownParent: $(dropdownParentElement),
                dir: `${dir}`,
                width: "100%",
                escapeMarkup: function (text) { return text; }
            });
        }
        initializeSelect2("#tipas-select", "#tipas-select-parent")
        initializeSelect2("#tipas", "#tipas-parent")
        initializeSelect2("#namo-tipas", "#namo-tipas-select")
        initializeSelect2("#sklypo-paskirtis-select", "#sklypo-paskirtis")
        initializeSelect2("#patalpu-paskirtis-select", "#patalpu-paskirtis")
        initializeSelect2("#paganation-items", "#paganation-items-parent", 'rtl')
        initializeSelect2("#savivaldybe-select", "#savivaldybe")
        initializeSelect2("#miestas-select", "#miestas")
        initializeSelect2("#mikrorajonas-select", "#mikrorajonas")
        initializeSelect2("#gatve-select", "#gatve")

    }
    /****************************************************
         POTENZA Window load and functions
    ****************************************************/
    //Window load functions
    $window.on("load", function () {
        document.querySelectorAll(".documents__item-folder").forEach(el => {
            el.addEventListener("click", () => {
                el.classList.toggle("active-item-folder")
            })
        })
    });

    const clickDropdownMenuMobile = () => {
        if (window.innerWidth < 992) {
            // Get the anchor element
            var anchorElement = document.getElementById("navbarDropdownMenuLink");



            if (anchorElement) {
                anchorElement.setAttribute("data-toggle", "dropdown");
                anchorElement.addEventListener("click", function (event) {
                    event.preventDefault();
                    var obj = this;

                    if (obj.getAttribute("data-clicked") === "true") {
                        location.href = obj.getAttribute("href");
                    } else {
                        obj.setAttribute("data-clicked", "true");
                    }
                });
            }
        }
    }

    document.addEventListener("DOMContentLoaded", clickDropdownMenuMobile);
    window.addEventListener("resize", clickDropdownMenuMobile);
    window.addEventListener('pageshow', function (event) {

        if (document.querySelector('#izangos-paieska')) {
            document.querySelector('#izangos-paieska').reset();

        }
    });
    window.addEventListener('click', function (e) {

    })

    //Document ready functions
    $document.ready(function () {
        POTENZA.counters(),
            POTENZA.datetimepickers(),
            POTENZA.select2(),
            POTENZA.dropdownmenu(),
            POTENZA.isSticky(),
            POTENZA.scrollbar(),
            POTENZA.goToTop(),
            POTENZA.bgSlider(),
            POTENZA.countdownTimer(),
            POTENZA.mediaPopups(),
            POTENZA.rangesliders(),
            POTENZA.streetviewtabs(),
            POTENZA.carousel();
        POTENZA.searhBlock()
        POTENZA.partneriai()
        POTENZA.select2Width()

    });
})(jQuery);

// Sticky header
function hideHeader() {
    let prevScrollPos = window.scrollY;

    function handleScroll() {
        const currentScrollPos = window.scrollY;
        const header = document.querySelector(".header");

        if (prevScrollPos > currentScrollPos) {
            header.classList.add("_visible");
            header.classList.remove("_hidden");
        } else {
            header.classList.add("_hidden");
            header.classList.remove("_visible");
        }

        prevScrollPos = currentScrollPos;
    }

    window.addEventListener("scroll", handleScroll);
}

hideHeader()

// slick for estate card
$(document).ready(function () {

    const thumbSliders = $(".image-hover");

    if (thumbSliders.length > 0) {
        thumbSliders.each(function (index, element) {
            var slider = tns({
                container: element,
                items: 1,
                slideBy: 'page',
                autoplay: true, // Set autoplay to false initially
                controls: false,
                mode: 'gallery',
                autoplayButtonOutput: false,
                nav: false,
                autoplayTimeout: 1300,
            });

            slider.pause();
            $(element).on('mouseenter', function () {
                slider.play();
            });
            $(element).on('mouseleave', function () {
                slider.pause();
            });
        });
    }
});
// filtrai
$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    const savivaldybeValue = urlParams.get('savivaldybe');
    const miestasValue = urlParams.get('miestas');
    const mikrorajonasValue = urlParams.get('mikrorajonas');
    const gatveValue = urlParams.get('gatve');
    const adresuFiltraiApiUrl = "https://localhost:44394//Umbraco/Api/AdresuFiltrai/AdresaiJson";
    const savivaldybesSelect = $("#savivaldybe-select");
    const miestasSelect = $("#miestas-select");
    const mikrorajonasSelect = $("#mikrorajonas-select");
    const gatveSelect = $("#gatve-select");
    const miestas = $("#miestas");
    const mikrorajonas = $("#mikrorajonas");
    const gatve = $("#gatve");

    function showIfNotEmpty(value, element) {
        if (value !== "") {
            setQueryValue(value, element)
            element.show();
        }
    }
    function setQueryValue(value, element) {
        element.find('option').each(function () {
            if ($(this).val() === value) {
                $(this).prop('selected', true);
            }
        });
    }
    function visi(select, container) {
        select.empty();
        const option = $("<option>").text("Visi").val("");
        select.append(option);
        container.hide();

    }

    function streets(streetsArray) {
        const streetCounts = {};

        streetsArray.streets.forEach(street => {
            streetCounts[street] = (streetCounts[street] || 0) + 1;

        });

        Object.keys(streetCounts).forEach(street => {
            const count = streetCounts[street];
            if (count === 1) {

                const objectsInStreet = $("<span>").text(`^${count}`);
                const option = $("<option>").val(street).text(street);

                if (gatveValue === street) {
                    option.attr("selected", true);
                }

                option.append(objectsInStreet);
                gatveSelect.append(option);
            }
        });

        Object.keys(streetCounts).forEach(street => {
            const count = streetCounts[street];
            if (count > 1) {
                const objectsInStreet = $("<span>").text(`^${count}`);
                const option = $("<option>").val(street).text(street);

                if (gatveValue === street) {
                    option.attr("selected", true);
                }

                option.append(objectsInStreet);
                gatveSelect.append(option);
            }
        });

        gatveSelect.select2({
            templateResult: formatState,
            templateSelection: formatSelection
        })
        function formatState(state) {

            const text = state.text;

            if (text === "Visi") {
                return text; // Return the text unchanged if it's "Visi"
            } else {
                const parts = text.split('^'); // Split the text into parts
                const state = $(
                    `<span>${parts[0]}</span><span class="street-count">${parts[1]}</span>`
                );

                return state;
            }
        }

        function formatSelection(selection) {
            const text = selection.text;

            if (text === "Visi") {
                return text; // Return the text unchanged if it's "Visi"
            } else {
                const parts = text.split('^');
                const state = $('<span>').text(parts[0]); // Construct the span element with the street name only

                // Set attributes for customization
                state.attr('title', parts[0]); // Set title attribute for tooltip


                return state;
            }
        }
    }

    showIfNotEmpty(miestasValue, miestas)
    showIfNotEmpty(mikrorajonasValue, mikrorajonas)
    showIfNotEmpty(gatveValue, gatve)
    visi(miestasSelect, miestas);
    visi(mikrorajonasSelect, mikrorajonas);
    visi(gatveSelect, gatve);


    let data;

    fetch(adresuFiltraiApiUrl)
        .then(res => res.json())
        .then(responseData => {
            data = responseData;

            const savivaldybesList = [...new Set(data.map(item => item.municipality))];
            savivaldybesList.sort((a, b) => {
                if (a === "Vilnius" || a === "Vilniaus rajono sav.") return -1; // Vilnius and Vilniaus R. Sav come first
                if (b === "Vilnius" || b === "Vilniaus rajono sav.") return 1; // Vilnius and Vilniaus R. Sav come first
                return a.localeCompare(b);
            });
            savivaldybesList.forEach(el => {
                const option = $("<option>").val(el).text(el);
                if (savivaldybeValue === el) {
                    option.attr("selected", true);
                }
                savivaldybesSelect.append(option);
            });

            if (miestasValue) {

                miestas.show()
                const selectedMunicipality = savivaldybeValue;
                const selectedData = data.find(sav => sav.municipality === selectedMunicipality);
                if (selectedData) {
                    selectedData.cities.forEach(item => {
                        const option = $("<option>").val(item.city).text(item.city);
                        if (miestasValue === item.city) {
                            option.attr("selected", true);
                        }
                        miestasSelect.append(option);
                    });
                }
            }

            if (mikrorajonasValue) {

                mikrorajonas.show()
                const selectedMunicipality = savivaldybeValue;
                const selectedData = data.find(sav => sav.municipality === selectedMunicipality);

                if (selectedData) {

                    if (selectedData.mikrorajonai.length > 0) {
                        selectedData.mikrorajonai.forEach(item => {
                            const option = $("<option>").val(item.mikrorajonas).text(item.mikrorajonas);
                            if (mikrorajonasValue === item.mikrorajonas) {
                                option.attr("selected", true);
                            }
                            mikrorajonasSelect.append(option);
                        });
                    }
                }
            }

            if (gatveValue) {

                gatve.show()
                const selectedMunicipality = savivaldybeValue;
                const selectedData = data.find(sav => sav.municipality === selectedMunicipality);
                if (selectedData) {

                    const filterStreets = selectedData.mikrorajonai.find(sav => sav.mikrorajonas === mikrorajonasSelect.val());
                    const filterStreetsCity = selectedData.cities.find(sav => sav.city === miestasSelect.val());

                    if (filterStreets !== undefined && filterStreets.streets.length > 0) {
                        gatve.show();
                        streets(filterStreets)
                    }
                    else if (filterStreetsCity !== undefined && filterStreetsCity.streets.length > 0) {
                        gatve.show();
                        streets(filterStreetsCity)
                    }
                }
            }
        });

    savivaldybesSelect.on("change", () => {

        if (savivaldybesSelect.val()) {
            visi(miestasSelect, miestas);
            visi(mikrorajonasSelect, mikrorajonas);
            visi(gatveSelect, gatve);
            const selectedMunicipality = savivaldybesSelect.val();
            const selectedData = data.find(sav => sav.municipality === selectedMunicipality);
            if (selectedData) {
                if (selectedData.cities.length > 0) {
                    miestas.show();

                }
                selectedData.cities.forEach(item => {
                    const option = $("<option>").val(item.city).text(item.city);

                    miestasSelect.append(option);
                });
            }
        } else {
            visi(miestasSelect, miestas);
            visi(mikrorajonasSelect, mikrorajonas);
            visi(gatveSelect, gatve);
        }
    });

    miestasSelect.on("change", () => {
        if (miestasSelect.val()) {
            visi(mikrorajonasSelect, mikrorajonas);
            visi(gatveSelect, gatve);
            const selectedMunicipality = savivaldybesSelect.val();
            const selectedData = data.find(sav => sav.municipality === selectedMunicipality);

            if (selectedData) {
                if (selectedData.mikrorajonai[0].mikrorajonas !== null) {
                    mikrorajonas.show();

                    selectedData.mikrorajonai.forEach(item => {
                        const option = $("<option>").val(item.mikrorajonas).text(item.mikrorajonas);
                        mikrorajonasSelect.append(option);
                    });
                }

                else if (selectedData.cities[0].streets.length > 0) {

                    gatve.show();
                    const filterStreets = selectedData.cities.find(sav => sav.city === miestasSelect.val());
                    streets(filterStreets)

                }
            }
        } else {
            visi(mikrorajonasSelect, mikrorajonas);
            visi(gatveSelect, gatve);
        }
    });

    mikrorajonasSelect.on("change", () => {

        if (mikrorajonasSelect.val()) {

            visi(gatveSelect, gatve);
            const selectedMunicipality = savivaldybesSelect.val();
            const selectedData = data.find(sav => sav.municipality === selectedMunicipality);

            if (selectedData) {

                const filterStreets = selectedData.mikrorajonai.find(sav => sav.mikrorajonas === mikrorajonasSelect.val());

                if (filterStreets.streets.length > 0) {
                    gatve.show();
                    streets(filterStreets)
                }
            }
        } else {
            visi(gatveSelect, gatve);
        }
    })
});


const hasGallerry = document.querySelector("[data-fslightbox]")

if (hasGallerry)
{
    fsLightbox.props.showThumbsOnMount = true;
}

