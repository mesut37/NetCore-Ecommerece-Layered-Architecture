$(document).ready(function () {




    $("#delete").click(function () {
        $(".preview-images-zone").fadeOut(function myFunction() {
            setTimeout(function () { $(".preview-images-zone").html(""); }, 100);
        });

        $(".preview-images-zone").fadeIn();

        $("#pro-image").val('');
    });


    document.getElementById('pro-image').addEventListener('change', readImage, false);
  
    $(".preview-images-zone").sortable();

    $(document).on('click', '.image-cancel', function () {
        let no = $(this).data('no');
        $(".preview-image.preview-show-" + no).remove();
    });

   

   
});

function deletePhoto(id) {

    alertify.confirm("Silmek istediğinizden emin misiniz ?",
        function () {
            $.ajax({
                url: "/AdminProduct/PhotoDelete",
                type: "POST",
                dataType: "json",
                data: {
                    id: id
                },
                success: function (data) {
                    setTimeout(function () {
                        $("#line-" + id).remove();
                        alertify.success('Silindi');

                    }, 200)
                }

            });
        },
        function () {

        });


};







var num = 4;
function readImage() {
    if (window.File && window.FileList && window.FileReader) {
        var files = event.target.files; //FileList object
        var output = $(".preview-images-zone");

        for (let i = 0; i < files.length; i++) {
            var file = files[i];
            if (!file.type.match('image')) continue;

            var picReader = new FileReader();

            picReader.addEventListener('load', function (event) {
                var picFile = event.target;
                var html = '<div class="preview-image preview-show-' + num + '">' +
                    '<div class="image-cancel" data-no="' + num + '">x</div>' +
                    '<div class="image-zone"><img id="pro-img-' + num + '" src="' + picFile.result + '"></div>' +
                    
                    '</div>';

                output.append(html);
                num = num + 1;
            });

            picReader.readAsDataURL(file);
        }
      
    } else {
        console.log('Browser not support');
    }
}
