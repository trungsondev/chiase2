#pragma checksum "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b64ae8e17ca08ed2d53b36243ba949f0f0d8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b64ae8e17ca08ed2d53b36243ba949f0f0d8ea", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb518cacaf4ec53ed9f28249390631a8e1057105", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b64ae8e17ca08ed2d53b36243ba949f0f0d8ea3883", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>AdminLTE 3 | Dashboard</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/lib/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Tempusdominus Bbootstrap 4 -->
    <link rel=""stylesheet"" href=""/lib/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
    <!-- iCheck -->
    <link rel=""stylesheet"" href=""/lib/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- JQVMap -->
    <link rel=""stylesheet"" href=""/lib/plugins/jqvmap/jqvmap.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/lib/dist/css/adminlte.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""/l");
                WriteLiteral(@"ib/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Daterange picker -->
    <link rel=""stylesheet"" href=""/lib/plugins/daterangepicker/daterangepicker.css"">
    <!-- summernote -->
    <link rel=""stylesheet"" href=""/lib/plugins/summernote/summernote-bs4.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
    <link href=""//cdnjs.cloudflare.com/ajax/libs/select2/4.0.0/css/select2.min.css"" rel=""stylesheet"" />
    <script src=""//cdnjs.cloudflare.com/ajax/libs/select2/4.0.0/js/select2.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/gh/bbbootstrap/libraries@main/choices.min.css"">
    <script src=""https://cdn.jsdelivr.net/gh/bbbootstrap/libraries@main/choices.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.js"" integrity=""sha512-+k1pnlgt4F1H8L7t3z95o3/KO+o78INEcXTbnoJQ/F2VqDVhWoaiVml/OEHv9HsVgxUaVW+IbiZPUJQfF/YxZw=");
                WriteLiteral("=\" crossorigin=\"anonymous\" referrerpolicy=\"no-referrer\"></script>\r\n    ");
#nullable restore
#line 37 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("HeaderSection", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <style>\r\n        #ToastArea {\r\n            visibility: hidden;\r\n            position: fixed;\r\n            top: 50px;\r\n            right: 10px;\r\n            z-index: 10;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b64ae8e17ca08ed2d53b36243ba949f0f0d8ea7613", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"wrapper\">\r\n\r\n        <!-- Navbar -->\r\n        ");
#nullable restore
#line 54 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
   Write(Html.Partial("Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.navbar -->\r\n        <!-- Main Sidebar Container -->\r\n        ");
#nullable restore
#line 57 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
   Write(Html.Partial("SideBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Content Wrapper. Contains page content -->\r\n        <div class=\"content-wrapper\">\r\n            <!-- Content Header (Page header) -->\r\n            ");
#nullable restore
#line 62 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
       Write(Html.Partial("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- /.content-header -->\r\n            <!-- Main content -->\r\n            ");
#nullable restore
#line 65 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
       Write(Html.Partial("Toast"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <section class=\"content\">\r\n                <h1 class=\"text text-primary text-bold text-center\">");
#nullable restore
#line 67 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
                                                               Write(ViewData["TitlePage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                ");
#nullable restore
#line 68 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </section>\r\n            <!-- /.content -->\r\n\r\n        </div>\r\n        <!-- /.content-wrapper -->\r\n        <footer class=\"main-footer\">\r\n            ");
#nullable restore
#line 75 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
       Write(Html.Partial("Bottom"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
");
                WriteLiteral(@"    
    <!-- jQuery UI 1.11.4 -->
    <script src=""/lib/plugins/jquery-ui/jquery-ui.min.js""></script>
    <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
    <script>
        $.widget.bridge('uibutton', $.ui.button)
    </script>
    <!-- Bootstrap 4 -->
    <script src=""/lib/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- ChartJS -->
    <script src=""/lib/plugins/chart.js/Chart.min.js""></script>
    <!-- Sparkline -->
    <script src=""/lib/plugins/sparklines/sparkline.js""></script>
    <!-- JQVMap -->
    <script src=""/lib/plugins/jqvmap/jquery.vmap.min.js""></script>
    <script src=""/lib/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
    <!-- jQuery Knob Chart -->
    <script src=""/lib/plugins/jquery-knob/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""/lib/plugins/moment/moment.min.js""></script>
    <script src=""/lib/plugins/daterangepicker/daterangepicker.js""></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <s");
                WriteLiteral(@"cript src=""/lib/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
    <!-- Summernote -->
    <script src=""/lib/plugins/summernote/summernote-bs4.min.js""></script>
    <!-- overlayScrollbars -->
    <script src=""/lib/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""/lib/dist/js/adminlte.js""></script>
    <!-- AdminLTE dashboard demo (This is only for demo purposes) -->
    <script src=""/lib/dist/js/pages/dashboard.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""/lib/dist/js/demo.js""></script>
    <script src=""/js/DungChung/Toast.js""></script>
    <script");
                BeginWriteAttribute("src", " src=\"", 5396, "\"", 5466, 2);
                WriteAttributeValue("", 5402, "/js/DungChung/ThaoTacMacDinh.js?v=", 5402, 34, true);
#nullable restore
#line 121 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5436, DateTime.Now.Ticks.ToString(), 5436, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" defer></script>    \r\n    ");
#nullable restore
#line 122 "D:\BaiTestPhatTrienPhanMem\QuanLyDiemSinhVien\QuanLyDiemThiSinhVien\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("BottomSection", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
