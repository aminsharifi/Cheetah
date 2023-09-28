$('.step-menu li').click(function () {
    $('.current').removeClass('current')
    $('.complete').removeClass('complete')
    $(this).addClass('current')
    $(this).prevAll().addClass('complete')
})