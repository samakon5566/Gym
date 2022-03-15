
$("#orderfilter").click(function (target) {
    if ($("#out-filterblock").css('height') != '400px')
        $("#out-filterblock").css('height', 400).css('padding-top',20).css('padding-bottom',20);
    else
        $("#out-filterblock").css('height', 0).css('padding-top', 0).css('padding-bottom', 0);
})

//////////////////////////////篩選顯示字樣問題
$(".filterblock>.order").click(function () {
    var mycart = [];
    $(".drop").append($(this).clone());
    $(".drop>.btn").each(function (index, value) {
        mycart[index] = '<div class="' + $(this).attr('class') + '"data-para="' + $(this).attr('data-para') + '"data-type="' + $(this).attr('data-type') + '"><i class="fas fa-times"></i>' + $(this).text() + '</div>';
    })
    $('.drop').empty();
    var count = 0
    $(mycart).each(function (e) {
        var chk = e - 1;
        if ($(mycart[e]).text() != $(mycart[chk]).text() && count < 1) {
            $('.drop').append(mycart[e]);
            if ($(mycart[e]).hasClass("order"))
                count++;
        }                   
    })
    $("#orderby").text("排序:" + $('.drop>.order').text());


})
$(".drop").on("click", ".fa-times", function () {
    $(this).closest(".btn").remove();
    $("#orderby").text('排序:無');
})
$(".filterblock>.cate").click(function () {
    var catename = [];
    var mycart = [];
    var count = 0
    var filtertext = "篩選:";
    $(".drop").append($(this).clone());
    $(".drop>.btn").each(function (index, value) {
        mycart[index] = '<div class="' + $(this).attr('class') + '"data-para="' + $(this).attr('data-para') + '"data-type="' + $(this).attr('data-type')+ '"><i class="fas fa-times"></i>' + $(this).text() + '</div>';
    })
    $('.drop').empty();    
    $(mycart).each(function (e) {
        console.log($(mycart[e]).text());
        var chk = e - 1;
        if ($(mycart[e]).text() != $(mycart[chk]).text()&&count<2) {
            $('.drop').append(mycart[e]);            
            if ($(mycart[e]).hasClass("cate"))
                count++;
        }
    })
    catename.push($(".drop>.cate").text());
    filttext(catename, filtertext);
    $(".drop>.btn>.fa-times").click(function () {
        $(this).closest(".btn").remove();
        catename.pop();
        filttext(catename, filtertext);
    })

})

function filttext(catename, filtertext) {
    if (catename.length!=0)
        filtertext = "篩選:";
    else
        filtertext = "篩選:無,";
    $.each(catename, function (index, value) {
        filtertext += value + ",";
    })
    $("#filt").text(filtertext);
}


