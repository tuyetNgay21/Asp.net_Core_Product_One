$(document).ready(function () {
    CKEDITOR.replace('editor', {
        height: 400,
        filebrowserUploadUrl: '/Admin/ImgeSave/UpLoadCKEditor'

    });

   
});
$('.ViewCkEditor').click(() => {
    var editorText = CKEDITOR.instances['editor'].getData();
    $('#ViewDataCKEditor').html(editorText);
    $('#Content').val(editorText);
});

$('#LoaiChuDe').change(function () {
    var id = $(this).val();
    $('#SpeciesId').val(id);
});

$('.SaveCkEditor').click(() => {
    var editorText = CKEDITOR.instances['editor'].getData();
});
$(".IdThemeSearch").click(function () {
    var noidung = $("#IdThemeSearch").val();
    if (noidung == undefined) {
        alert("Bạn cần nhập mã của chủ đề");
    }
    else {
        $.ajax({
            url: "/ViewPost",
            data: { numberSearch: noidung }
        });
    }
});

$(".contentThemeSearch").click(function () {
    var noidung = $("#contentThemeSearch").val();
    if (noidung == undefined) {
        alert("Bạn cần nhập mã của chủ đề");
    }
    else {
        $.ajax({
            url: "/ViewPost",
            data: { contentSearch: noidung }
        });
    }
});


