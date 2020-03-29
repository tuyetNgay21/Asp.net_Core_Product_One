$(document).ready(function () {
    CKEDITOR.replace('editor', {
        height: 400,
        filebrowserUploadUrl: '/Admin/ImgeSave/UpLoadCKEditor'

    });
});

$('.ViewCkEditor').click(()=>{
    var editorText = CKEDITOR.instances['editor'].getData();
    $('#ViewDataCKEditor').html(editorText);
});

$('.SaveCkEditor').click(() => {
    var editorText = CKEDITOR.instances['editor'].getData();
});

