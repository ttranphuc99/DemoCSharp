#pragma checksum "E:\App\DemoWeb\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "966bfee48ca19831680529eb4d7341328690a623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Index.cshtml", typeof(AspNetCore.Views_Projects_Index))]
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
#line 1 "E:\App\DemoWeb\Views\_ViewImports.cshtml"
using DemoWeb;

#line default
#line hidden
#line 2 "E:\App\DemoWeb\Views\_ViewImports.cshtml"
using DemoWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966bfee48ca19831680529eb4d7341328690a623", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1eed71ab82a9216d928000508c35f19e8f411c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoWeb.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(116, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "966bfee48ca19831680529eb4d7341328690a6234562", async() => {
                BeginContext(139, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(153, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(246, 41, false);
#line 16 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonVi));

#line default
#line hidden
            EndContext();
            BeginContext(287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(343, 48, false);
#line 19 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NamQDDauTuBD));

#line default
#line hidden
            EndContext();
            BeginContext(391, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(447, 49, false);
#line 22 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CoQDDieuChinh));

#line default
#line hidden
            EndContext();
            BeginContext(496, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(552, 46, false);
#line 25 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhanLoaiDV));

#line default
#line hidden
            EndContext();
            BeginContext(598, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(654, 46, false);
#line 28 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TKChuDauTu));

#line default
#line hidden
            EndContext();
            BeginContext(700, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(756, 51, false);
#line 31 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ChuongTrinhMTQG));

#line default
#line hidden
            EndContext();
            BeginContext(807, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(863, 42, false);
#line 34 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaQHNS));

#line default
#line hidden
            EndContext();
            BeginContext(905, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(961, 45, false);
#line 37 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TinhTrang));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1062, 43, false);
#line 40 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1161, 50, false);
#line 43 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HinhThucQuanLy));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1267, 49, false);
#line 46 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HinhThucDauTu));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1372, 47, false);
#line 49 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NganhKinhTe));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1475, 44, false);
#line 52 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NhomDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1575, 44, false);
#line 55 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ChuDauTu));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1675, 43, false);
#line 58 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BQLDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1774, 54, false);
#line 61 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VaiTroChuaGanQuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1884, 50, false);
#line 64 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SuDungNguonVon));

#line default
#line hidden
            EndContext();
            BeginContext(1934, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1990, 58, false);
#line 67 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.XacNhanDuLieuMoiTuNgay));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2104, 59, false);
#line 70 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.XacNhanDuLieuMoiDenNgay));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2219, 44, false);
#line 73 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(2263, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 79 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2381, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2430, 40, false);
#line 82 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DonVi));

#line default
#line hidden
            EndContext();
            BeginContext(2470, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2526, 47, false);
#line 85 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NamQDDauTuBD));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2629, 48, false);
#line 88 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CoQDDieuChinh));

#line default
#line hidden
            EndContext();
            BeginContext(2677, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2733, 45, false);
#line 91 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhanLoaiDV));

#line default
#line hidden
            EndContext();
            BeginContext(2778, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2834, 45, false);
#line 94 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TKChuDauTu));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2935, 50, false);
#line 97 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ChuongTrinhMTQG));

#line default
#line hidden
            EndContext();
            BeginContext(2985, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3041, 41, false);
#line 100 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaQHNS));

#line default
#line hidden
            EndContext();
            BeginContext(3082, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3138, 44, false);
#line 103 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TinhTrang));

#line default
#line hidden
            EndContext();
            BeginContext(3182, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3238, 42, false);
#line 106 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(3280, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3336, 49, false);
#line 109 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HinhThucQuanLy));

#line default
#line hidden
            EndContext();
            BeginContext(3385, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3441, 48, false);
#line 112 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HinhThucDauTu));

#line default
#line hidden
            EndContext();
            BeginContext(3489, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3545, 46, false);
#line 115 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NganhKinhTe));

#line default
#line hidden
            EndContext();
            BeginContext(3591, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3647, 43, false);
#line 118 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NhomDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(3690, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3746, 43, false);
#line 121 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ChuDauTu));

#line default
#line hidden
            EndContext();
            BeginContext(3789, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3845, 42, false);
#line 124 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BQLDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(3887, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3943, 53, false);
#line 127 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VaiTroChuaGanQuyen));

#line default
#line hidden
            EndContext();
            BeginContext(3996, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4052, 49, false);
#line 130 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SuDungNguonVon));

#line default
#line hidden
            EndContext();
            BeginContext(4101, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4157, 57, false);
#line 133 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.XacNhanDuLieuMoiTuNgay));

#line default
#line hidden
            EndContext();
            BeginContext(4214, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4270, 58, false);
#line 136 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.XacNhanDuLieuMoiDenNgay));

#line default
#line hidden
            EndContext();
            BeginContext(4328, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4384, 43, false);
#line 139 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoaiDuAn));

#line default
#line hidden
            EndContext();
            BeginContext(4427, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4482, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "966bfee48ca19831680529eb4d7341328690a62321833", async() => {
                BeginContext(4527, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 142 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4535, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4555, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "966bfee48ca19831680529eb4d7341328690a62324143", async() => {
                BeginContext(4603, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 143 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4614, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4634, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "966bfee48ca19831680529eb4d7341328690a62326459", async() => {
                BeginContext(4681, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 144 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4691, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 147 "E:\App\DemoWeb\Views\Projects\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4730, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoWeb.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
