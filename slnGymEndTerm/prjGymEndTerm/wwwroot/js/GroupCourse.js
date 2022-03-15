$("#orderfilter").click(function (target) {
    if ($("#out-filterblock").css('height') != '400px')
        $("#out-filterblock").css('height', 400).css('padding-top', 20).css('padding-bottom', 20);
    else
        $("#out-filterblock").css('height', 0).css('padding-top',0).css('padding-bottom',0);
})
///slider
   
    //event change
$("#out-filterblock").on("mouseup", ".ui-slider-handle", function () {
    console.log($("#slider-range").slider("values"));
})
//////////////////////////////篩選顯示字樣問題
$("#out-filterblock").on("click", "#filterdetail>.order", function () {
    var mycart = [];
    $(".drop").append($(this).clone());
    $(".drop>.btn").each(function (index, value) {
        mycart[index] = '<div class="' + $(this).attr('class') + '"><i class="fas fa-times"></i>' + $(this).text() + '</div>';
    })
    $('.drop').empty();
    $(mycart).each(function (e) {
        var chk = e - 1;
        if ($(mycart[e]).text() != $(mycart[chk]).text()) {
            $('.drop').append(mycart[e]);
        }
    })
    $("#orderby").text("排序:" + $(this).text());
    $(".drop>.btn>.fa-times").click(function () {
        $(this).closest(".btn").remove();
        $("#orderby").text('排序:無');
    })   
})

$(".filterblock>.cate").click(function () {
    const id = $(this).data('type');
    var url = `/GroupCourse/ShowcCorseDetail/${id}`;
    $.getJSON(url, function (data) {
        var filterdetail = $("#filterdetail");
        filterdetail.empty();
        $.each(data, function (index, value) {
            detailbtn = $("<div/>").addClass("btn-secondary btn order btn-22Coach-filter").data("para", value.courseDetailId).text(value.courseDetailName);
            filterdetail.append(detailbtn);
        })
    })
})

function filttext(catename, filtertext) {
    if (catename.length != 0)
        filtertext = "篩選:";
    else
        filtertext = "篩選:無,";
    $.each(catename, function (index, value) {
        filtertext += value + ",";
    })
    $("#filt").text(filtertext);
}

$(function () {
    $(".coach-menu .filter").click(function () {
        $(this).closest(".coach-menu").toggleClass("active");
    });

    $(".topheader-title").css('top','50%').css('transition','.5s');






})