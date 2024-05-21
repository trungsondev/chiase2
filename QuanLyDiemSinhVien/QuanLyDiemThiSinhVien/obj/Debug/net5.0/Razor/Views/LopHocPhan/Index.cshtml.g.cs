#pragma checksum "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5815d19d547ee080d5f0550bd9df483da682b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LopHocPhan_Index), @"mvc.1.0.view", @"/Views/LopHocPhan/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\_ViewImports.cshtml"
using QuanLyDiemThiSinhVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\_ViewImports.cshtml"
using QuanLyDiemThiSinhVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5815d19d547ee080d5f0550bd9df483da682b3", @"/Views/LopHocPhan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb518cacaf4ec53ed9f28249390631a8e1057105", @"/Views/_ViewImports.cshtml")]
    public class Views_LopHocPhan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/LopHocPhan/NhanDuLieu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
  
    ViewData["Title"] = "Lớp học phần";
    ViewData["TitlePage"] = "Quản lý lớp học phần";
    var dataHK = ViewData["DataHocKy"] as List<Model.Models.HocKy>;
    var dataMH = ViewData["DataMonHoc"] as List<Model.Models.MonHoc>;
    var dataGV = ViewData["DataGiangVien"] as List<Model.Models.GiangVien>;

#line default
#line hidden
#nullable disable
            DefineSection("HeaderSection", async() => {
                WriteLiteral(@"


    <link href=""https://unpkg.com/tabulator-tables/dist/css/tabulator.min.css"" rel=""stylesheet"">
    <script type=""text/javascript"" src=""https://unpkg.com/tabulator-tables/dist/js/tabulator.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.2/css/all.min.css"" integrity=""sha512-SnH5WK+bZxgPHs44uWIX+LLJAJ9/2PkPKZ5QiAj6Ta86w+fsb2TkcmfRyVX3pBnMFcV7oQPJkl9QevSCWr3W6A=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />


");
            }
            );
            WriteLiteral(@"<style>
    .modal-footer {
        display: unset !important;
    }

    #Grid1 {
        height: 100px;
    }

    .select2-selection.select2-selection--single {
        height: 35px !important;
    }
</style>
<div>
    <div class=""col-mb-12 d-flex justify-content-end"">
        <div");
            BeginWriteAttribute("class", " class=\"", 1137, "\"", 1145, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <input width=\"200px\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1193, "\"", 1201, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder=""Nội dung tìm kiếm ..."" id=""timKiem"" autocomplete=""off"">

        </div>
        <div>
            <button type=""button"" class=""ml-3 btn btn-primary btn-md"" id=""btnThemMoi""><i class=""fa fa-plus""></i>&ensp;Thêm mới (F2)</button>
        </div>



");
            WriteLiteral(@"
    </div>
</div>

<div class=""row mt-3"">
    <div class=""col-md-12"">
        <div id=""Grid1""></div>
    </div>
    <div class=""modal modal-blur fade"" id=""mdThemMoi"" tabindex=""-1"" aria-modal=""true"" role=""dialog"" data-bs-backdrop=""static"">
        <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header nts-modal"">
                    <h5 class=""modal-title"" id=""tieuDeModal""></h5>
                    <button onclick=""donglai(this)"" type=""button"" class=""btn-close btn-danger"" data-bs-dismiss=""modal"" aria-label=""Close""> &times;</button>
                </div>
                <div class=""modal-body"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b37954", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <input type=""hidden"" id=""LopHPID"" name=""LopHPID"" />
                            <div class=""col-lg-6"">
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""MaLopHP"">Mã lớp</label>
                                    <input name=""MaLopHP"" type=""text"" class=""form-control"" id=""MaLopHP"" required>
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""TenLopHP"">Tên lớp</label>
                                    <input name=""TenLopHP"" type=""text"" class=""form-control"" id=""TenLopHP"" required>
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""mb-3"">
              ");
                WriteLiteral(@"                      <label class=""form-label"" for=""SoluongSv"">Số lượng</label>
                                    <input name=""SoluongSv"" type=""number"" class=""form-control"" id=""SoluongSv"">
                                </div>
                            </div>

                            <div class=""col-lg-12"">
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""MonHocID"">Môn học</label>
                                    <select name=""MonHocID"" class=""form-control"" id=""MonHocID"" tabindex=""0"" required>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b39971", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 97 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                         foreach (var item in dataMH)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b311521", async() => {
#nullable restore
#line 99 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                                                      Write(item.TenMonHoc);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                               WriteLiteral(item.MonHocId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""HocKyID"">Học kỳ</label>
                                    <select name=""HocKyID"" class=""form-control"" id=""HocKyID"" tabindex=""0"" required>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b314230", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                         foreach (var item in dataHK)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b315782", async() => {
#nullable restore
#line 111 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                                                     Write(item.TenHocKy);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                               WriteLiteral(item.HocKyId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""GiangVienID"">Giảng viên</label>
                                    <select name=""GiangVienID"" class=""form-control"" id=""GiangVienID"" tabindex=""0"" required>

                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b318510", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 123 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                         foreach (var item in dataGV)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5815d19d547ee080d5f0550bd9df483da682b320062", async() => {
#nullable restore
#line 125 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                                                         Write(item.HoTenGv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                               WriteLiteral(item.GiangVienId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 126 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div style=""display: flex; align-items: center; justify-content: space-between"">
                            <div class=""col-md-6"" style=""display: flex; align-items: center;visibility:hidden"">
                                <label style=""margin-bottom: unset"" class=""form-check form-switch"">
                                    <input class=""form-check-input"" type=""checkbox"" id=""DangSD"">
                                    <label class=""form-check-label"" for=""DangSD"">Đang sử dụng</label>
                                </label>
                            </div>
                            <div class=""col-md-6"">
                                <div style=""float:right;text-align: right"">
                                    <a onclick=""donglai(this)"" href=""#"" class=""btn btn-outline-danger"" data-bs-dismiss=""modal"">
          ");
                WriteLiteral(@"                              <i class=""fa fa-close""></i>&nbsp;Đóng (F4)
                                    </a>
                                    <button type=""submit"" id=""btnLuuVaDong"" class=""btn btn-success ms-auto"">
                                        <i class=""fa fa-save""></i>&ensp;Lưu và đóng (F9)
                                    </button>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n                </div>\r\n                <div class=\"modal-footer\">\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("BottomSection", async() => {
                WriteLiteral("\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 9690, "\"", 9753, 2);
                WriteAttributeValue("", 9696, "/js/QuanLy/LopHocPhan.js?v=", 9696, 27, true);
#nullable restore
#line 180 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\LopHocPhan\Index.cshtml"
WriteAttributeValue("", 9723, DateTime.Now.Ticks.ToString(), 9723, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" defer></script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591