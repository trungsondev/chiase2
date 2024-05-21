const toastFunc = (noidungToast, checkToast) => {
    $("#ToastBody").html(noidungToast);
    $("#ToastArea").css("visibility", "visible");
    $("#ToastMain").removeClass("toast-success").removeClass("toast-error");
    if (checkToast) {
        $("#ToastMain").addClass("toast-success");
    } else {
        $("#ToastMain").addClass("toast-error");
    }
    $('#toastSuccess').toast("show");
}
const toastFuncS = () => {
    $("#ToastBody").html("Thao tác thành công!");
    $("#ToastArea").css("visibility", "visible");
    $("#ToastMain").css("background-color", "green");
    $('#toastSuccess').toast("show");
}
const toastFuncE = () => {
    $("#ToastBody").html("Thao tác thất bại!");
    $("#ToastArea").css("visibility", "visible");
    $("#ToastMain").css("background-color", "red");
    $('#toastSuccess').toast("show");
}

$(document).ready(function () {
    $("#myBtn").click(function () {
        toastFuncS();
    });
});