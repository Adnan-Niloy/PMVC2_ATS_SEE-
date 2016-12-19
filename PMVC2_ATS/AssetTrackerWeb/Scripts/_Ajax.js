

var __ajax = function () { };

__ajax.prototype._FetchDropDown = function (_callback, _url , _parameter){
    $.ajax({
        type: "POST",
        url: _url,
        data: _parameter,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            _callback(data);
        },
        error: function () {
            alert("Network Connectivity Issue");
        }
    });

}