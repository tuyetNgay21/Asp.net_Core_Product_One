$(document).ready(function () {
    CKEDITOR.replace('editor', {
        height: 400,
        filebrowserUploadUrl: '/Admin/Home/UpLoadCKEditor'

    });
});