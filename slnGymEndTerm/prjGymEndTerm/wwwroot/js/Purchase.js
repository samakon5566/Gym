$(".nav-item").click(function () {
    $(this).toggleClass("active");
    $(this).siblings().removeClass("active");
})

$(function () { 
            
    //要先勾選按鈕才會取消disabled
    $(".form-check-input").change(function () {
        let checked = $(this).prop("checked");
        if (checked)
            $(".1st-save").removeAttr("disabled");
        else
            $(".1st-save").attr("disabled", "disabled");
    });


    $("#purch-list").on("click", ".lesson-btn", function () {
        const classID = $(this).closest("td").siblings(".classID").text();
        const urllesson = `/Purchase/Orderlessoninfo/${classID}`;
        $.getJSON(urllesson, function (data) {
            $("#exampleModalLabel").text(`${data[0].classname}`);
            const vacancy = $("<span/>").addClass("vacancy").text(`剩餘名額:${data[0].vacancy}/${data[0].classpeople}`);
            const coachname = $("<span/>").addClass("coachname").text(`教練:${data[0].coachname}`);
            $("#exampleModalLabel").append([vacancy, coachname]);
            var modalbody = $("#exampleModal .modal-body");
            modalbody.empty();
            $.each(data[0].lessontime, function (index, value) {
                var comment = $("<div/>").addClass("each-comment").text(value.replaceAll("T", " "));
                modalbody.append(comment);
            })
        })
    })

    $(".1st-save").click(function () {
        //todo防呆
    })


    $(".list-group>.list-group-item").click(function () {
        $(this).toggleClass("active").attr("aria-current", "true").siblings().removeClass("active").removeAttr("aria-current");
    })

    $("#confirm-paidway").click(function () {  
        var itemname = []
        $(".courseclassname").each(function (index, value) {
            itemname += `${$(value).closest("td").siblings(".classID").text()}:${$(value).text()};`;                 
        });
        
        const money = parseInt($("#paidmoney").text().replace("NT$", ""));
        const payway = $(".list-group>.list-group-item[aria-current='true']").text();
        const paywayPara = $(".list-group>.list-group-item[aria-current='true']").data("payway");
        var url = `/Purchase/Ordercheckout?paidway=${paywayPara}&money=${money}&itemname=${itemname}`;
        $("#current-paid-way").text(payway);
        $.getJSON(url, function (data) { 
            $("#returnURL").val(data.returnurl);
            $("#clientBackURL").val(data.backtoURL);
            $("#merchantTradeNo").val(data.tradeNo);
            $("#dealtime").val(data.merchantTradeDate);
            $("#dealmoney").val(data.totalamount);
            $("#CheckMacValue").val(data.checkmacvalue);
            $("#itemName").val(data.itemName);
            $("#choosePayment").val(data.payment);
        })

        if (paywayPara == "cash")
            $("#formCreditCard").attr("action", "https://msit132gym.azurewebsites.net/GroupCourse/課程與選購");
    })
})

Date.prototype.format = function (format) {
    var args = {
        "M+": this.getMonth() + 1,
        "d+": this.getDate(),
        "h+": this.getHours(),
        "m+": this.getMinutes(),
        "s+": this.getSeconds(),
        "q+": Math.floor((this.getMonth() + 3) / 3),  //quarter
        "S": this.getMilliseconds()
    };
    if (/(y+)/.test(format))
        format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var i in args) {
        var n = args[i];
        if (new RegExp("(" + i + ")").test(format))
            format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? n : ("00" + n).substr(("" + n).length));
    }
    return format;
};

