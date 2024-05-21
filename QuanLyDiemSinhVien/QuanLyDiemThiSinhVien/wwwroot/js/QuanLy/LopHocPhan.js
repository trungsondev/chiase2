$(function () {

    //$('select').select2({
    //    dropdownParent: $('#MonHocID')
    //});
    
    LoadDataTable()
})

function SuaDuLieu(ID) {
    $('#tieuDeModal').text('Cập nhật lớp học phần');
    const data = NTS.getAjaxMacDinh('/LopHocPhan/GetOnlyLopHP', { ID: ID });
    console.log(data)
    $('#mdThemMoi').modal('show');
    $('#LopHPID').val(data.LopHPID);
    $('#TenLopHP').val(data.TenLopHp);
    $('#MaLopHP').val(data.MaLopHp);
    $('#SoluongSv').val(data.SoluongSv);
    $('#MonHocID').val(data.MonHocId);
    $('#HocKyID').val(data.HocKyId);
    $('#GiangVienID').val(data.GiangVienId);
    
    $("#form").attr("action", "/LopHocPhan/SuaDuLieu");
    tempthem = "sua";
}
var tempthem = "them";
function ThemDuLieu() {
    $("#form").attr("action", "/LopHocPhan/NhanDuLieu");
    $('#mdThemMoi').modal('show');
    $('#tieuDeModal').text("Thêm mới thông tin lớp học phần");
    //$('#HuyenID').val("");
    //$('#TenVietTat').val("");
    //LoadTinh();
    //resetForm('#mdThemMoi');
    //$('#DangSD').prop('checked', true);
    //UpdateLabelDangSD('#DangSD');
    //const MaTuTang = NTS.getAjax("/DanhMuc/DungChung/LayMaTuTang", { strKyTu: '', strCotTang: 'MaHuyen', strBangTang: 'Huyen', strDinhDang: '000' });
    //if (!MaTuTang.Err) {
    //    $('#MaHuyen').value(MaTuTang.Result);
    //}
    tempthem = "them";
}

function LoadDataTable() {
    table.clearData();
    debugger;
    const GetAll =NTS.getAjaxBang("/LopHocPhan/GetAllLopHP", {});
    console.log(GetAll);
    table.setData(GetAll);
}

var fmThaoTac = function (cell) {
    return NTS.formaterbtnThaoTac3(cell.getData().LopHPID, "btnSuaGrid1","btnXoaGrid1");
}
var dulieuloc = "";
$(document).on('keyup', '#timKiem', function (e) {
    if (e.keyCode == '13') {
        Search($(this).val());
    }
});

function Search(data) {
    if (data == '' || data == undefined) {
        data = $('#timKiem').val();
    }
    dulieuloc = data;
    table.setFilter(NTS.matchAny, {
        value: $('#timKiem').val()
    });
}

var table = new Tabulator("#Grid1", {
    layout: "fitColumns",
    pagination: true,
    paginationSize: 50,
    paginationSizeSelector: [50, 100, 150, 200, 500, true],
    height: "350",
    HeaderVertAlign: "center",
    columns: [
        { title: '<i class="fa fa-ellipsis-h"></i>', headerHozAlign: "center", hozAlign: "center", formatter: fmThaoTac, width: 60, headerSort: false, frozen: true, vertAlign: "middle", print: false },
        { title: "LopHPID", field: "LopHPID", visible: false, print: false },
        { title: "Mã", field: "MaLopHP", formatter: 'textarea', headerHozAlign: "center", hozAlign: "left", vertAlign: "middle", visible: true, width: 150, minWidth: 80 },
        { title: "Tên lớp", field: "TenLopHP", formatter: 'textarea', headerHozAlign: "center", hozAlign: "left", vertAlign: "middle", width: 350, minWidth: 150 },
        { title: "Tên giảng viên", field: "HoTenGV", formatter: 'textarea', headerHozAlign: "center", hozAlign: "left", vertAlign: "middle", width: 250, minWidth: 120 },
        { title: "Môn học", field: "TenMonHoc", formatter: 'textarea', headerHozAlign: "center", hozAlign: "left", vertAlign: "middle", width: 280, minWidth: 150 },
        /*{ title: "Diễn giải", field: "DienGiai", hozAlign: "left", headerHozAlign: "center", formatter: "textarea", vertAlign: "middle", minWidth: 300 },*/
        /*{ title: "Trạng thái sử dụng", field: "DangSD", headerWordWrap: true, hozAlign: "center", vertAlign: "middle", formatter: fmDangSD, headerSort: false, width: 135, headerHozAlign: "center" }*/
    ],
    locale: true,
    paginationCounter: "rows",
    langs: NTS.TabulatorLangsVi,
    placeholder: 'Không có dữ liệu',
});

table.on("rowDblClick", function (e, row) {
    $('#LopHPID').val(row.getData().LopHPID);
   /* SuaDuLieu(row.getData().HuyenID);*/
});
$(document).on('click', '#btnThemMoi', function () {
    ThemDuLieu();
});
$(document).on('click', '.btnSuaGrid1', function () {
    $('#LopHPID').val($(this).attr('data'));
    SuaDuLieu($(this).attr('data'));
});
$(document).on('click', '.btnXoaGrid1', function () {
    var ID = $(this).attr('data');
    XoaDuLieu(ID);
});
function donglai(e) {
    $('#mdThemMoi').modal('hide');
}

