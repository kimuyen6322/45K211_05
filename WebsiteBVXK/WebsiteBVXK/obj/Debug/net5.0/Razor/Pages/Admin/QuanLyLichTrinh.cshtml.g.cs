#pragma checksum "D:\Website\Web Ban ve xe khach\BackEnd\WebsiteBVXK\WebsiteBVXK\Pages\Admin\QuanLyLichTrinh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a685fdaf4ee88a1bc6447b5a5cee2be9d48dcd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebsiteBVXK.Pages.Admin.Pages_Admin_QuanLyLichTrinh), @"mvc.1.0.razor-page", @"/Pages/Admin/QuanLyLichTrinh.cshtml")]
namespace WebsiteBVXK.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a685fdaf4ee88a1bc6447b5a5cee2be9d48dcd6e", @"/Pages/Admin/QuanLyLichTrinh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a7e65950eb984363104a8fb7d73e67e545b5eb", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_QuanLyLichTrinh : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Website\Web Ban ve xe khach\BackEnd\WebsiteBVXK\WebsiteBVXK\Pages\Admin\QuanLyLichTrinh.cshtml"
  
    Layout = "_Layout";
    ViewData["Tittle"] = "Quản Lý Lịch Trình";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""head-title"">
    <div class=""left"">
        <h1>Trang Quản lý</h1>
        <ul class=""breadcrumb"">
            <li>
                <a href=""#"">Trang Quản lý</a>
            </li>
            <li><i class='bx bx-chevron-right'></i></li>
            <li>
                <a class=""active"" href=""#"">");
#nullable restore
#line 17 "D:\Website\Web Ban ve xe khach\BackEnd\WebsiteBVXK\WebsiteBVXK\Pages\Admin\QuanLyLichTrinh.cshtml"
                                      Write(ViewData["Tittle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            </li>
        </ul>
    </div>
    <a href=""#"" class=""btn-download"">
        <i class='bx bxs-cloud-download'></i>
        <span class=""text"">Download PDF</span>
    </a>
</div>



<div class=""table-data"">

    <div class=""todo"">
        <div class=""head"">
            <h3>Thông tin lịch trình</h3>
        </div>

        <ul class=""input-list"">
            <table class=""inputable"">
                <tr>
                    <td> Mã lịch trình:</td>
                    <td>
                        <input type=""text"">
                    </td>
                </tr>
                <tr>

                    <td>	Mã xe:  </td>
                    <td>
                        <input type=""text"">
                    </td>
                </tr>

                <tr>
                    <td> Nơi xuất phát:  </td>
                    <td>
                        <select name=""noixuatphat""");
            BeginWriteAttribute("id", " id=\"", 1418, "\"", 1423, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a685fdaf4ee88a1bc6447b5a5cee2be9d48dcd6e5015", async() => {
                WriteLiteral("Đà Nẵng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a685fdaf4ee88a1bc6447b5a5cee2be9d48dcd6e6002", async() => {
                WriteLiteral("Hà Tĩnh");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td> Nơi đến: </td>\r\n                    <td>\r\n                        <select name=\"noiden\"");
            BeginWriteAttribute("id", " id=\"", 1754, "\"", 1759, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a685fdaf4ee88a1bc6447b5a5cee2be9d48dcd6e7363", async() => {
                WriteLiteral("Đà Nẵng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a685fdaf4ee88a1bc6447b5a5cee2be9d48dcd6e8350", async() => {
                WriteLiteral("Hà Tĩnh");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </td>
                </tr>
                <tr>
                    <td> Ngày đi: </td>
                    <td> <input type=""date"" name=""ngaydi"" /> 	</td>
                </tr>
                <tr>
                    <td> Thời gian đi: </td>
                    <td> <input type=""time"" name=""thoigiandi"" /> </td>
                </tr>
                <tr>
                    <td>Thời gian đến: </td>
                    <td><input type=""time"" name=""thoigianden"" />
                    <td>

                </tr>
            </table>
        </ul>
        <table class=""table-button"">
            <tr>
                <td>
                    <button class=""buttontsx"">Thêm</button>
                    <button class=""buttontsx"">Xóa</button>
                    <button class=""buttontsx"">Sửa</button>
                </td>

            </tr>
        </table>

    </div>

    <div class=""order"">
        <div class=""head"">
       ");
            WriteLiteral(@"     <h3>Danh sách lịch trình</h3>
        </div>
        <table>
            <thead>
                <tr>
                    <th>Mã lịch trình</th>
                    <th>Mã xe</th>
                    <th>Nơi xuất phát</th>
                    <th>Nơi đến</th>
                    <th>Ngày đi</th>
                    <th>Thời gian đi</th>
                    <th>Thời gian đến</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><span class=""status pending""> LT0001</span></td>
                    <td>X00001</td>
                    <td>Hà Tĩnh</td>
                    <td>Đà Nẵng</td>
                    <td>22/08/2021</td>
                    <td>13:00</td>
                    <td>22:00</td>
                </tr>
                <tr>
                    <td><span class=""status pending""> LT0002</span></td>
                    <td>X00002</td>
                    <td>Hà Tĩnh</td>
                    <td>Đà Nẵng</td>
     ");
            WriteLiteral(@"               <td>22/08/2021</td>
                    <td>13:00</td>
                    <td>22:00</td>
                </tr>
                <tr>
                    <td><span class=""status pending""> LT0003</span></td>
                    <td>X00003</td>
                    <td>Hà Tĩnh</td>
                    <td>Đà Nẵng</td>
                    <td>22/08/2021</td>
                    <td>13:00</td>
                    <td>22:00</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBVXK.Pages.QuanLyLichTrinhModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebsiteBVXK.Pages.QuanLyLichTrinhModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebsiteBVXK.Pages.QuanLyLichTrinhModel>)PageContext?.ViewData;
        public WebsiteBVXK.Pages.QuanLyLichTrinhModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591