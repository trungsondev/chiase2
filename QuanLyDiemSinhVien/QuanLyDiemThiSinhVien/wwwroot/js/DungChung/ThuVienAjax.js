$(function () {
   
})
function GetAjaxTVBP(Url, FormData) {
    var ResultTCBP = null;
    var token = document.querySelector('input[name=__RequestVerificationToken]').value;
    /*    var token ="my3HEKUqNlUm51do66GcJnIIJz3BeQdX1LXQPJ6yC8Gi0V3rG3A79JBwBZceB-25QJgPj7LGs3EoOHICIY5i0oQoPr05ob37Hk8T4J5f3i41";*/
    $.ajax({
        //processData: false,
        //contentType: false,
        method: "POST",
        url: Url,
        data: FormData,
        contentType: "aplication/json; charset=utf-8",
        dataType: "json",
        async: true,
        timeout: 10000,
        beforeSend: function (request) {
            try {
                request.setRequestHeader("__RequestVerificationToken", token)

            } catch (e) {

            }
        },
        success: function (result) {
            ResultTCBP = result;
            AlertStatic.Success();

        },
        error: function (result) {
            AlertStatic.Error();

        }

    });
    return ResultTCBP;
}
function GetAjaxTVBPJson(Url, FormData) {
    let ResultTCBP = null;
    $.ajax({
        processData: false,
        contentType: false,
        method: "POST",
        url: Url,
        data: JSON.stringify(FormData),
        contentType: "aplication/json; charset=utf-8",
        dataType: "json",
        async: false,
        timeout: 100000,
        beforeSend: function (request) {
            try {
                request.setRequestHeader("__RequestVerificationToken", document.querySelector('input[name=__RequestVerificationToken]').value)

            } catch (e) {

            }
        },
        success: function (result) {
            ResultTCBP = result;
        },
        error: function (result) {
            AlertStatic.Error();
        }

    });
    return JSON.parse(ResultTCBP);

}