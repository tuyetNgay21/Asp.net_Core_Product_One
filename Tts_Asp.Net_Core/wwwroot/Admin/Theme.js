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
        $('#AnhChuDe').val(AnhChuDe);
    });
    $(".Delete").click(function () {
        var id = $(this).data("id");
        $.ajax({
            url:"/XoaChuDe",
            data: {   id : id  },
            type: "post",
            success: function () {
                alert("Đã xóa thành công");
            },
            error: function () {
                alert("Có biến rồi đại vương");
            }
            
        });
    });


    $(".LoaiExit").click(function () {
        var id = $(this).data("id");
        var MaChuDe = $('#MaLoaiChuDe-' + id + '').text();
        var TenChuDe = $("#TenLoaiChuDe-" + id + "").text();
        var TieuDeChuDe = $("#TieuDeLoaiChuDe-" + id + "").text();
        var AnhChuDe = $("#AnhLoaiChuDe-" + id + "").attr("src");
        var MaCuaChuDe = $("#MaChuDeLoai-" + id + "").text();

        $('#MaTieuDe').val(MaChuDe);
        $('#TenTieuDe').val(TenChuDe);
        $('#NoiDungTieuDe').val(TieuDeChuDe);
        $('#AnhTieuDe').attr("src", AnhChuDe);
        $('#AnhChuDe').val(AnhChuDe);
        $('#MaChuDeCuaLoaiChude').val(MaCuaChuDe);
    });
    $(".LoaiDelete").click(function () {
        var id = $(this).data("id");
        $.ajax({
            url: "/Loai-XoaChuDe",
            data: { id: id },
            type: "post",
            success: function () {
                alert("Đã xóa thành công");
            },
            error: function () {
                alert("Có biến rồi đại vương");
            }

        });
    });
});