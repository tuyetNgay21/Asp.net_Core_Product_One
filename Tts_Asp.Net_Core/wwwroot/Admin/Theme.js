$(document).ready(function(){
    $(".Exit").click(function () {
        var id = $(this).data("id");
        var MaChuDe = $('#MaChuDe-' + id + '').text();
        var TenChuDe = $("#TenChuDe-" + id + "").text();
        var TieuDeChuDe = $("#TieuDeChuDe-" + id + "").text();
        var AnhChuDe = $("#AnhChuDe-" + id + "").attr("src");

        $('#MaTieuDe').val(MaChuDe);
        $('#TenTieuDe').val(TenChuDe);
        $('#NoiDungTieuDe').val(TieuDeChuDe);
        $('#AnhTieuDe').attr("src", AnhChuDe);
    });
});