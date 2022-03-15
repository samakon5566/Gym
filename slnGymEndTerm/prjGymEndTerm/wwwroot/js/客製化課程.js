
$(function () {

    
    //collapse1建立
    //計算TDEE
    $(".btn-calculate").click(function () {
        var height = parseInt($("#inputHeight").val());
        var weight = parseInt($("#inputWeight").val());
        var Age = parseInt($("#inputAge").val());
        var Gender = $("#inputGender>option:selected").text();
        $("#inputConsume").val(BMRcalculator(height, weight, Age, Gender));
        
        if ($(".drop .btn").length != 0) {
            //計算按鈕
            var Consume = BMRcalculator(height, weight, Age, Gender);
            var Consumeval = parseInt(Consume.substring(0, Consume.indexOf("大")));
            if (Consume != "有欄位尚未填寫") {
                var Absorb = 0;
                $(".drop .btn").each(function (index, value) {
                    var qtystring = $(value).text();
                    var qty = qtystring.substr(qtystring.indexOf("X") + 1);
                   
                    if (Number.isInteger(parseInt(qty)))
                        Absorb += $(value).data('cal') * qty;
                    else
                        Absorb += $(value).data('cal')
                })
                $("#inputBalance").val((Consumeval - Absorb) + "大卡/日");
            }
        }
        
    })
    //Demo鍵
    $("#Demo1").click(function () {
        $("#inputHeight").val(155);
        $("#inputWeight").val(62);
        $("#inputAge").val(45);
        $("#inputGender").val("女性")
    })   


    //日常飲食選單
    $("#foodblock>.btn").click(function () {
        var mycart = [];
        $(".drop").append($(this).clone());
        $(".drop>.btn").each(function (index, value) {
            var mynum = $(this).data('num');
            mycart[index] = '<div data-num=' + mynum + ' data-type=' + $(this).attr("data-type") + ' data-cal=' + $(this).data("cal") + ' class="' + $(this).attr('class') + '">' + $(this).text() + '</div>';
        })
        mycart.sort();
        mycart.reverse();
        $('.drop').empty();
        $(mycart).each(function (e) {
            var chk = e - 1;
            if ($(mycart[e]).data('type') != $(mycart[chk]).data('type')) {
                var num = $(mycart[e]).data('num');
                $('.drop').append(mycart[e]);
            }
            else if ($(mycart[e]).data('type') == $(mycart[chk]).data('type')) {
                var qty = $('.drop>.btn:eq(' + chk + ')').data('num');
                qty++;
                var foodname = $('.drop>.btn:eq(' + chk + ')').text();
                var multiply = foodname.indexOf("X");
                var foodqty = $('.drop>.btn:eq(' + chk + ')').text()
                if (multiply < 0)
                    foodqty = foodqty + "X" + qty;
                else
                    foodqty = foodqty.substring(0, multiply) + "X" + qty;
                $('.drop>.btn:eq(' + chk + ')').text(foodqty).data({ num: qty });
            }
        })

        //計算按鈕
        var Consume = $("#inputConsume").val();
        var Consumeval = parseInt(Consume.substring(0, Consume.indexOf("大")));
        if (Consume != "") {
            var Absorb = 0;
            var Balance = $("#inputBalance").val();
            var Balanceval = parseInt(Balance.substring(0, Balance.indexOf("大")));
            Absorb += $(this).data('cal');
            if (Number.isNaN(Balanceval))
                $("#inputBalance").val((Consumeval - Absorb) + "大卡/日");
            else
                $("#inputBalance").val((Balanceval - Absorb) + "大卡/日");
        }
        //取消按鈕

        $(".drop>.btn").click(function () {
            var Balance = $("#inputBalance").val();
            var Balanceval = parseInt(Balance.substring(0, Balance.indexOf("大")));
            var Absorb = 0;
            var btntext = $(this).text();
            var Xindex = btntext.indexOf("X");
            var nowvalue = parseInt(btntext.substr(Xindex + 1));
            if (Number.isNaN(nowvalue))
                $(this).remove();
            else {
                --nowvalue;
                if (nowvalue > 1)
                    $(this).text(btntext.substring(0, Xindex) + "X" + nowvalue);
                else
                    $(this).text(btntext.substring(0, Xindex));
            }
            Absorb += $(this).data('cal');
            if (Consume != "") {
                $("#inputBalance").val((Balanceval + Absorb) + "大卡/日");
            }
        })        
    });

    //要先勾選按鈕才會取消disabled
    $(".form-check-input").change(function () {
        let checked = $(this).prop("checked");
        if (checked)
            $("#1st-save").removeAttr("disabled");
        else
            $("#1st-save").attr("disabled", "disabled");
    });
    //第一個送出按鈕
    $("#1st-save").click(function () {                
        SloganShow();
        if ($("#slogan div").text() == "") {
            $("#collapseOne").toggleClass("show");
            $("#collapseTwo").toggleClass("show");
            $("#headingTwo").find(".btn").attr("data-toggle", "collapse")
        }   

    })

    //collapse2建立

    $(".class-category button").click(function () {

        //建立購買清單
        var tbodylist = $("#purch-list tbody");
        var id = $(this).siblings().data('type');
        var tr = $("<tr/>");        
        const urldetail = `/Experience/Arrangement/${id}`;    
        ///課程細項表格
        loaddetail(tr,urldetail);
        tbodylist.append(tr);
    })



    //dropdown change 
    $("#purch-list").on("change", ".coursedetail", function () {
        const index = $(".coursedetail").index($(this));
        modifyprogressdecreasing(index);
        loadclass($(this).closest("tr"));
    })

    $("#purch-list").on("click", ".close", function () {
        const index = $(".close").index($(this));
        $(this).closest("tr").remove();
        $("#purch-list tbody tr").eq(index - 1).find(".courseclass,.coursedetail").removeAttr("disabled", "disabled");
        console.log($("#purch-list tbody tr").eq(index - 1));
        modifyprogressdecreasing(index);
    })


})
//計算機
function BMRcalculator(height, weight, age, gender) {
    if (isNaN(height) || isNaN(weight) || isNaN(age)) {
        return "有欄位尚未填寫";
    }
    var BMR = "";
    if (gender == "男性") {
        BMR = (13.7 * weight) + (5 * height) - (6.8 * age) + 66;
    }
    else if (gender == "女性") {
        BMR = (9.6 * weight) + (1.8 * height) - (4.7 * age) + 655;
    }
    $("#inputExpection").val(weight);
    return Math.round(BMR) + "大卡/日";
}

//辨別確認是否都有輸入參數
function SloganShow() {
    $("#slogan div").text("");
    //BMR計算機
    const BMRtxt = $(".div-purchase-BMR input");
    var countBMR = 0;
    BMRtxt.each(function (index, value) {       
        if ($(value).val() == "") {
            countBMR++;
            $("#slogan1").text(`BMR區域尚有${countBMR}個空缺欄位`);
        }        
    })
    //飲食習慣
    const meal = $(".drop .btn");
    if (meal.text() == "")
        $("#slogan2").text(`請選取您平常的飲食餐點`);
    const Expection = $("#inputExpection").val();
    const Weight = $("#inputWeight").val();
    if (Expection == "")
        $("#slogan3").text(`請輸入您的目標體重`);
    else if (parseInt(Expection) >= parseInt(Weight))
        $("#slogan3").text(`體重不符合`);
    const deadline = $("#inputExpire").val();
    if (deadline == "")
        $("#slogan4").text(`請輸入您的達標日期`);
    else if (new Date(deadline) <= new Date())
        $("#slogan4").text(`只能輸入今天以後的日期,並且日期至少要3個月過後`);
    else if (new Date(deadline) <= dateWithMonthsDelay(3))
        $("#slogan4").text(`達標日期至少要3個月過後`);

    
    //progress-bar進度條
    var weight = parseInt($("#inputWeight").val());
    var Expectionval = parseInt(Expection);
    var Balance = $("#inputBalance").val();
    var Balanceval = parseInt(Balance.substring(0, Balance.indexOf("大")));
    var day1 = new Date();
    var day2 = new Date(deadline);
    const totaldiffcal = datediffMultiplyCal(Balanceval, day1, day2);
    $("#progress-bar").attr("aria-valuemax", (weight - Expectionval) * 7700 - Math.round(totaldiffcal));
    $("#txt-notice").text("");
    if ((weight - Expectionval) * 7700 - Math.round(totaldiffcal) < 0) {
        $("#txt-notice").text("按照這個飲食方式,就可以達標了");
    }
        
}

function dateWithMonthsDelay(months) {
    const date = new Date()
    date.setMonth(date.getMonth() + months)
    return date
}

function datediffMultiplyCal(cal,day1, day2) {
    var difference = Math.abs(day2 - day1);
    days = difference / (1000 * 3600 * 24);    
    return cal * days;
}

function loadlesson(tr) {    
    var index = tr.index();
    $("#purch-list").on("click", ".lesson-btn", function () {
        const selectclass = $(".courseclass>option:selected").eq(index).text();
        const urllesson = `/Experience/ArrangementLesson/${selectclass}`;             
        $.getJSON(urllesson, function (data) {
            $("#exampleModalLabel").text(`${selectclass}`);
            const vacancy = $("<span/>").addClass("vacancy").text(`剩餘名額:${data[0].vacancy}/${data[0].coursepeople}`);
            const coachname = $("<span/>").addClass("coachname").text(`教練:${data[0].coachname}`);
            $("#exampleModalLabel").append([vacancy, coachname]);
            var modalbody = $(".modal-body");            
            modalbody.empty();
            $.each(data[0].lessontime, function (index, value) {
                var comment = $("<div/>").addClass("each-comment").text(value.replaceAll("T"," "));
                modalbody.append(comment);
            })
        })
    })
}

function loadclass(tr) {
    tr.find("td").slice(3, 7).remove();    
    var index = tr.index();
    var classflag = [];    
    const existclass = tr.prevAll().find(".courseclass>option:selected");
    existclass.each(function (index, value) {
        classflag.push($(value).text());
    })
    //////////////課程班別表格
    var params = {};    
    const selectdetail = $(".coursedetail>option:selected").eq(index).text();
    params.id = selectdetail;
    params.classnames = classflag;
    const urlclass = '/Experience/ArrangementClassName';
    $.getJSON(urlclass, $.param(params, true), function (data) {
        if (data.length != 0) {
            var classselect = $("<select/>").addClass("courseclass");
            $.each(data, function (index, value) {
                var opt = $("<option/>").text(value.classname);
                classselect.append(opt);
            })
            var id = $("<td/>").addClass("classid").append(data[0].classid).attr("hidden","hidden");
            var Class = $("<td/>").append(classselect);
            var hyperlink = $("<a/>").attr('href', '#exampleModal').text("點我").addClass("btn btn-primary lesson-btn").attr('data-toggle', 'modal');
            var btn = $("<td/>").append(hyperlink);
            var money = $("<td/>").append(data[0].money);
            modifyprogressincreasing(data[0].classcal);
            tr.append([id,Class, btn, money]);
            loadlesson(tr);
            tr.prevAll().find(".courseclass,.coursedetail").attr("disabled", "disabled");
        }
        else {
            tr.remove();
            alert("比對不到可以上課的班級");
        }
            
        
    })
}

function loaddetail(tr,url) {
    $.getJSON(url, function (data) {
        if (data.length==0)
            alert("該課程目前尚未有開班");
        var close = $("<i/>").addClass("fas fa-times close").attr("type","button");
        var btn = $("<button/>").addClass("btn").append(close);
        var btn_close = $("<td/>").append(btn);
        //課程種類表格
        var category = $("<td/>").text(data[0].coursecategory);
        //課程細項表格       
        var detailselect = $("<select/>").addClass("coursedetail");
        $.each(data, function (index, value) {
            var opt = $("<option/>").text(value.coursedetail);
            detailselect.append(opt);
        })
        var detail = $("<td/>").append(detailselect);
        tr.append([btn_close, category, detail]);
        loadclass(tr);
    })
}


var calArray = [];
function modifyprogressincreasing(classcal) {
    const maxvalue = parseInt($("#progress-bar").attr("aria-valuemax"))
    var nowvalue =  parseInt($("#progress-bar").attr("aria-valuenow"));
    nowvalue += classcal * 10;
    calArray.push(classcal * 10);
    percentprogress = nowvalue * 100 / maxvalue
    $("#progress-bar").attr("aria-valuenow", nowvalue).css("width", `${percentprogress}%`);
    if (percentprogress<100)
        $("#txt-notice").text(`您已經達成${Math.round(percentprogress)}%了`);
    else
        $("#txt-notice").text(`您已經達標了,可以準備進入購買頁面了`);

}

function modifyprogressdecreasing(index) {
    const maxvalue = parseInt($("#progress-bar").attr("aria-valuemax"))
    var nowvalue = parseInt($("#progress-bar").attr("aria-valuenow"));
    nowvalue -= calArray[index];
    if (index > -1) {
        calArray.splice(index, 1);
    }
    $("#progress-bar").attr("aria-valuenow", nowvalue).css("width", `${nowvalue * 100 / maxvalue}%`);
    $("#txt-notice").text(`您已經達成${Math.round(nowvalue * 100 / maxvalue)}%了`);
}
