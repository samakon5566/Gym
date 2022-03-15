var typeId = 0;



OneOnOne();
loaddetail(0, false);




$("#customSwitch1").change(function () {
    flag = $(this).prop("checked");
    if(flag)
        $("#labelswitch").text("熱門")
    else
        $("#labelswitch").text("推薦")
    loaddetail(typeId, flag);
})

$("#category .btn").click(function () {
    typeId = $(this).data('type');
    flag = $("#customSwitch1").prop("checked");
    $("#category .btn").removeClass("clickactive");
    $(this).addClass("clickactive");

    loaddetail(typeId,flag);
})

function loaddetail(id, flag) {
    //refresh
    $(".div-GroupCourse-GroupClass").find("img").removeAttr('src');
    $(".intro-text").text('');
    var url = `/Home/Alldetail?id=${id}&flag=${flag}`;
    $.getJSON(url, function (data) {
        $.each(data, function (index, value) {           
            //input
            $(".div-GroupCourse-GroupClass").eq(index).find("img").attr('src', `/img/CourseDetail/${value.detailinfo.detailpic}`);
            $(".intro-text").eq(index).text(value.detailinfo.detailname);
        }) 
    })
}

function loadnews(data) {
    
    $.each(data, function (index, value) {
        $(".news").eq(index).find("span").text(value.newstitle);
        $(".news").eq(index).find("h1").text(value.newscontent);
    })
}


function OneOnOne() {
    var url = "/Home/OneOnOneCoach"
    $.getJSON(url, function (data) {
        var rank = data.sort(sortItem);
        var count = 3;
        $.each(rank, function (index, value) {        
            if (value.coachscore.length != 0 ) {
                $(".ts-item").eq(count).css("background-image", `url("../img/LoginFigure/${value.coachfigure}")`)
                    .find("h4").text(value.coachname).siblings("span").text(value.coachskill).siblings("div")
                    .find(".fa-star").slice(0, ArrayAvg(value.coachscore)).css('color', '#F36100');
                count++;
            }
            
        })
    })
}


function sortItem(x, y) { 
    ArrayAvg(x.coachscore);
    return -((ArrayAvg(x.coachscore) == ArrayAvg(y.coachscore)) ? 0 : (((ArrayAvg(x.coachscore) > ArrayAvg(y.coachscore)) ? 1 : -1)));
}

function ArrayAvg(myArray) {
    var i = 0, summ = 0, ArrayLen = myArray.length;
    while (i < ArrayLen) {
        summ = summ + myArray[i++];
    }
    if (ArrayLen != 0)
        return (summ / ArrayLen);
    else
        return ;
}