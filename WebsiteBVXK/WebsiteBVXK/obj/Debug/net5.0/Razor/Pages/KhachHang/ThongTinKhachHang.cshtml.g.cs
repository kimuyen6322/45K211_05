#pragma checksum "D:\Website\Web Ban ve xe khach\BackEnd\WebsiteBVXK\WebsiteBVXK\Pages\KhachHang\ThongTinKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b402f1ccef9a05d6facc8c28736592f224a761cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebsiteBVXK.Pages.KhachHang.Pages_KhachHang_ThongTinKhachHang), @"mvc.1.0.razor-page", @"/Pages/KhachHang/ThongTinKhachHang.cshtml")]
namespace WebsiteBVXK.Pages.KhachHang
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
#line 1 "D:\Website\Web Ban ve xe khach\BackEnd\WebsiteBVXK\WebsiteBVXK\Pages\_ViewImports.cshtml"
using WebsiteBVXK;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b402f1ccef9a05d6facc8c28736592f224a761cd", @"/Pages/KhachHang/ThongTinKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a7e65950eb984363104a8fb7d73e67e545b5eb", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_KhachHang_ThongTinKhachHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/KhachHang/XacNhanThongTin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Website\Web Ban ve xe khach\BackEnd\WebsiteBVXK\WebsiteBVXK\Pages\KhachHang\ThongTinKhachHang.cshtml"
  
    Layout = "_Layout";
    ViewData["Tittle"] = "Thông Tin Khách Hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"banner\">\r\n    <div class=\"noidung\">\r\n        <div class=\"form\">\r\n            <h2><b>Thông Tin Khách Hàng</b></h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b402f1ccef9a05d6facc8c28736592f224a761cd4414", async() => {
                WriteLiteral(@"
                <div class=""input-form"">
                    <span>Tên Khách Hàng<sup>*</sup></span>
                    <input type=""text"" placeholder=""Nhập họ và tên của bạn"" required>
                </div>
                <div class=""input-form"">
                    <span>Số điện thoại<sup>*</sup></span>
                    <input type=""text"" placeholder=""Nhập số điện thoại của bạn"" required>
                </div>
                <div class=""input-form"">
                    <span>Email<sup>*</sup></span>
                    <input type=""text"" placeholder=""Nhập địa chỉ email của bạn"" required>
                </div>
                <div class=""input-form"">
                    <span>CMND/CCCD<sup>*</sup></span>
                    <input type=""text"" placeholder=""Nhập CMND CCCD của bạn"" required>
                </div>
                <div class=""input-form"">
                    <span>Số lượng<sup>*</sup></span>
                    <input type=""number""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1293, "\"", 1307, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"input-form\">\r\n                    <span>Ghi chú</span>\r\n                    <textarea name=\"ghichu\" id=\"ghichu\" cols=\"45\" rows=\"5\"></textarea>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <section>
                <div class=""notes-container"">
                    <span class=""title"">Lưu ý</span> <br>
                    (*) Quý khách vui lòng mang email có chứa mã vé đến văn phòng để đổi vé lên xe trước giờ xuất bến ít nhất
                    <span class=""high-light"">60 phút</span>
                    để chúng tôi trung chuyển.
                    <p class=""txt"">(*) Thông tin hành khách phải chính xác, nếu không sẽ không thể lên xe hoặc hủy/đổi vé.</p>
                </div>
            </section>
        </div>
    </div>
    <div class=""content"">
        <button type=""checkbox"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b402f1ccef9a05d6facc8c28736592f224a761cd7822", async() => {
                WriteLiteral("\r\n            <span>Tiếp tục</span>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBVXK.Pages.KhachHang.ThongTinKhachHangModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebsiteBVXK.Pages.KhachHang.ThongTinKhachHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebsiteBVXK.Pages.KhachHang.ThongTinKhachHangModel>)PageContext?.ViewData;
        public WebsiteBVXK.Pages.KhachHang.ThongTinKhachHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591