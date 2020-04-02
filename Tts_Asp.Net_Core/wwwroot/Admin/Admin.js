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


