﻿window.CreateToolTip = (type) => {

    if (type == "Destroy") {

        //$('.MyTable').each(function () {
        //    $(this).DataTable().destroy();
        //});

    }
    else if (type == "Create") {

        //$('.MyTable').each(function () {
        //    $(this).addClass("CustomTable");
        //});

    }
}

window.ShowToastr = (type, message) => {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": true,
        "progressBar": true,
        "positionClass": "toast-top-left",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    if (type === "success") {
        toastr.success(message, "موفق", { timeOut: 5000 });
    }
    if (type === "error") {
        toastr.error(message, "خطا", { timeOut: 5000 });
    }
}


window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Success Notification!',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Error Notification!',
            message,
            'error'
        )
    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}



window.CreateNavBar = () => {
    $("#menu-toggle").click(function (e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
    });

    $(window).resize(function (e) {
        if ($(window).width() <= 768) {
            $("#wrapper").removeClass("toggled");
        } else {
            $("#wrapper").addClass("toggled");
        }
    });
}

