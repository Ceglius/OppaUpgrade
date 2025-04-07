function addWatermarkToImages() {
    window.addEventListener("click", function (e) {
        const target = e.target;

        function addWatermark() {
            $('.fslightboxs').watermark({
                path: '/images/vandens-zenklas-1.png',
                gravity: "c",
                opacity: 0.6
            });
        }

        // Add watermark on click
        addWatermark();

        function handleArrowKeys(event) {
            if (event.keyCode === 37 || event.keyCode === 39) { // Left and right arrow keys
                addWatermark();
            }
        }

        // Event listener for arrow keys
        document.addEventListener("keydown", handleArrowKeys);
    });



    window.addEventListener("DOMContentLoaded", function () {
        $('.water-mark').watermark({
            path: '/images/vandens-zenklas-2.png',
            gravity: "c",
            opacity: 0.6
        });
    });
}

addWatermarkToImages();
