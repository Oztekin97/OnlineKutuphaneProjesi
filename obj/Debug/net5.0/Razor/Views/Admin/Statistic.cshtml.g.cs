#pragma checksum "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4cd9e62488344a67846f68bcb76a963418dff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Statistic), @"mvc.1.0.view", @"/Views/Admin/Statistic.cshtml")]
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
#line 3 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\_ViewImports.cshtml"
using GaziLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4cd9e62488344a67846f68bcb76a963418dff2", @"/Views/Admin/Statistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76a04a78eae82b38dc19f9396404c0820ae56e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Statistic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StatisticModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""mb-5 py-3 text-white"" style=""background-color: yellowgreen"">MEVCUT DURUM</h1>
<div class=""mx-5"">
    <div class=""row text-white"">
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color: aquamarine "">
                <div class=""text-center h3 p-3"">Kitaplar</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 14 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color: blue"">
                <div class=""text-center h3 p-3"">Alınan Kitaplar</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 21 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfBorrowedBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color:burlywood"">
                <div class=""text-center h3 p-3"">Yazarlar</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 28 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfAuthors);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color: firebrick "">
                <div class=""text-center h3 p-3"">Kullanıcılar</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 35 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color: lightcoral "">
                <div class=""text-center h3 p-3"">Kitap Türleri</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 42 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfTypes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color: wheat "">
                <div class=""text-center h3 p-3"">Mesajlar</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 49 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfMessages);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-lg-4 mb-4"">
            <div style=""background-color: midnightblue"">
                <div class=""text-center h3 p-3"">Pozisyonlar</div>
                <hr />
                <div class=""text-center display-2 p-3"">");
#nullable restore
#line 56 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Statistic.cshtml"
                                                  Write(Model.NumberOfPositions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StatisticModel> Html { get; private set; }
    }
}
#pragma warning restore 1591