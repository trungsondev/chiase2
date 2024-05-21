var NTS = {
    matchAny: function (data, filterParams) {
        //data - the data for the row being filtered
        //filterParams - params object passed to the filter
        var regex = /^[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$/i;
        var match = false;
        for (var key in data) {
            try {
                if (data[key] != "" && !regex.test(data[key])) {
                    if (data[key].toLowerCase().indexOf(filterParams.value.toLowerCase()) !== -1) {
                        match = true;
                        return match;
                    }
                }
            }
            catch (e) { }
        }
        return match;
    },
    loadding: function (obj) {
        $('#Loadding').html('<div class="message-loading-overlay"><img class="ace-icon" src="../../Images/loading.gif" width="48" height="48" alt="Vui lòng chờ..." /></div>');
        $('#Loadding').show();
    },
    unloadding: function (obj) {
        $('#Loadding').html('').hide();
    },
    TabulatorLangsVi: {
        "vi": {
            "columns": {
                "name": "Name", //replace the title of column name with the value "Name"
            },
            "ajax": {
                "loading": "Đang tải...", //ajax loader text
                "error": "Lỗi tải dữ liệu", //ajax error text
            },
            "groups": { //copy for the auto generated item count in group header
                "item": "dòng", //the singular  for item
                "items": "dòng", //the plural for items
            },
            "pagination": {
                "page_size": "Kích thước", //label for the page size select element
                "page_title": "Hiển thị",//tooltip text for the numeric page button, appears in front of the page number (eg. "Show Page" will result in a tool tip of "Show Page 1" on the page 1 button)
                "first": '<i class="fa fa-step-backward" aria-hidden="true"></i>', //text for the first page button
                "first_title": "Trang đầu", //tooltip text for the first page button
                "last": '<i class="fa fa-step-forward" aria-hidden="true"></i>',
                "last_title": "Trang cuối",
                "prev": '<i class="fa fa-chevron-left" aria-hidden="true"></i>',
                "prev_title": "Lùi lại",
                "next": '<i class="fa fa-chevron-right" aria-hidden="true"></i>',
                "next_title": "Kế tiếp",
                "all": "All",
            },
            "headerFilters": {
                "default": "filter column...", //default header filter placeholder text
                "columns": {
                    "name": "filter name...", //replace default header filter text for column name
                }
            }
        }
    },
    formaterbtnThaoTac: function(ID) {
        return `<div class="show-or-hide"><a class='text-primary btnSuaGrid1' title="Sửa" data='${ID}'><i class="fa fa-pencil"></i></a></b>&ensp;<a class='text-danger btnXoaGrid1 btn-nts-xoa' title="Xoá" data='${ID}'><i class='fa fa-trash-o'></i></a></div>`;
    },
    formaterbtnThaoTacXoa: function (ID, btnXoaGrid1) {
        return `<div class="show-or-hide"><a class='text-danger ${btnXoaGrid1} btn-nts-xoa' title="Xoá" data='${ID}'><i class='fa fa-trash-o'></i></a></div>`;
    },
    formaterbtnThaoTacXem: function (ID, btnXemGrid) {
        return `<div class="show-or-hide"><a class='text-success ${btnXemGrid}' title="Xem" data='${ID}'><i class='fa fa-eye'></i></a></div>`;
    },
    formaterbtnThaoTac3: function (ID, btnSuaGrid1, btnXoaGrid1) {
        return `<div class="show-or-hide"><a class='text-primary ${btnSuaGrid1}' title="Sửa" data='${ID}'><i class='fa fa-pencil'></i></a></b>&ensp;<a class='text-danger ${btnXoaGrid1}' title="Xoá" data='${ID}'><i class='fa fa-trash'></i></a></div>`;
    },
    getAjaxBang: function (duongDanAjax, duLieuGui) {
        var result = null;
        $.ajax({
            type: "POST",
            url: duongDanAjax,
            data: JSON.stringify(duLieuGui),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: false,
            timeout:100000,
            beforeSend: function (request) {
                try {
                    request.setRequestHeader("__RequestVerificationToken", document.querySelector('input[name=__RequestVerificationToken]').value);
                } catch (e) { }
            },
            success: function (response) {
                result = response;
            },
            error: function (response) {
                result = null;
            },
            complete: function () {
            }
        });
        return JSON.parse(result.result);
    },
    getAjaxMacDinh: function (duongDanAjax, duLieuGui) {
        var result = null;
        $.ajax({
            type: "POST",
            url: duongDanAjax,
            contentType: 'application/x-www-form-urlencoded',
            data: duLieuGui,
            async: false,
            timeout: 100000,
            beforeSend: function (request) {
                try {
                    request.setRequestHeader("__RequestVerificationToken", document.querySelector('input[name=__RequestVerificationToken]').value);
                } catch (e) { }
            },
            success: function (response) {
                result = response;
            },
            error: function (response) {
                result = null;
            },
            complete: function () {
            }
        });
        return JSON.parse(result.result);
    },
}
