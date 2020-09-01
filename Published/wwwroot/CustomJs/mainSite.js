window.global = {
    openModal: function (name) {
        name = '#' + name;
        $(name).modal('show')
    },
    closeModal: function (name) {
        name = '#' + name;
        $(name).modal('hide')
    },
    showNavMenu: function () {
        $("#sidebarToggle, #sidebarToggleTop").on('click', function (e) {
            $("body").toggleClass("sidebar-toggled");
            $(".sidebar").toggleClass("toggled");
            if ($(".sidebar").hasClass("toggled")) {
                $('.sidebar .collapse').collapse('hide');
            }
            ;
        });
    },
    showCalender: function (name) {
        $('#' + name).datepicker();
    },
    showTimer: function (duration, timerShowTag, flag) {
        display = document.getElementById(timerShowTag);
        startTimer(duration, display, flag);
    }
}

function confirmDelete(uniqueId, isTrue) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;
    if (isTrue) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}

function startTimer(duration, display, flag) {
    if (flag == true) {
        var timer = duration, minutes, seconds;
        var intervalId = setInterval(function () {
            minutes = parseInt(timer / 60, 10);
            seconds = parseInt(timer % 60, 10);

            minutes = minutes < 10 ? "0" + minutes : minutes;
            seconds = seconds < 10 ? "0" + seconds : seconds;

            display.innerText = minutes + ":" + seconds;

            if (--timer < 0) {
                timer = duration;
            }
        }, 1000);
        localStorage.setItem("firstOtp", intervalId);
    } else {
        var clearPrevious = localStorage.getItem("firstOtp");
        clearInterval(clearPrevious);
    }
}

$(document).ready(function () {
    localStorage.clear();
    // $('#file1').change(function () {
    //     if (input.files && input.files[0]) {
    //         var reader = new FileReader();

    //         reader.onload = function (e) {
    //             $('#file1').attr('src', e.target.result);
    //         }

    //         reader.readAsDataURL(input.files[0]); // convert to base64 string
    //     }
    // });
});

function isNumber(evt) {
    evt = (evt) ? evt : window.event;
    let charCode = (evt.which) ? evt.which : evt.keyCode;
    return !(charCode > 31 && (charCode < 48 || charCode > 57));    
}

function lettersOnly(evt) {
    evt = (evt) ? evt : event;
    let charCode = (evt.charCode) ? evt.charCode : ((evt.keyCode) ? evt.keyCode : ((evt.which) ? evt.which : 0));
    return !(charCode > 31 && charCode > 32 && (charCode < 65 || charCode > 90) && (charCode < 97 || charCode > 122));
}



