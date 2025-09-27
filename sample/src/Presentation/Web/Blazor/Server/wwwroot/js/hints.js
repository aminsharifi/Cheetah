window.startHints = function () {
    const hints = [
        "بپرسید نحوه ثبت اطلاعات چگونه است؟",
        "بپرسید چه افرادی درخواست را بررسی میکنند",
        "بپرسید چه اطلاعاتی برای ثبت درخواست نیاز است",
        "بپرسید چه افرادی در فرایند دخیل هستند",
        "بپرسید فرآیندهایی که ثبت کرده ام را چگونه پیگیری کنم",
        "بپرسید گزارش این فرآیند کجاست که بتوانم درخواستم را بررسی کنم",
        "در خصوص خود فرایند و ماهیتش سوال بپرسید"
    ];

    const hintBox = document.getElementById('hint-box');
    if (!hintBox) return;

    let index = 0;

    function showHint() {
        hintBox.style.opacity = 0;
        setTimeout(() => {
            hintBox.textContent = hints[index];
            hintBox.style.opacity = 1;
            index = (index + 1) % hints.length;
        }, 500);
    }

    showHint();
    setInterval(showHint, 5000);
}
