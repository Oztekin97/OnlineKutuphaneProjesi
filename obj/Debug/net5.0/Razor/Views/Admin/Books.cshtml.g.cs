#pragma checksum "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "906c5950db5db5347f883081c41ad8af4addb524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Books), @"mvc.1.0.view", @"/Views/Admin/Books.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906c5950db5db5347f883081c41ad8af4addb524", @"/Views/Admin/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76a04a78eae82b38dc19f9396404c0820ae56e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""py-3 text-white"" style=""background-color: #3a393f "">KİTAPLAR</h1>
<div class=""mx-5"">
    <a href=""/Admin/AddBook"" class=""btn btn-success my-4 float-end"" >Yeni Kitap Ekle</a>

    <table class=""table table-bordered table-striped table-hover"">
        <thead class=""table-dark"">
            <tr>
                <th>AD</th>
                <th>YAZAR</th>
                <th>TÜR</th>
                <th>SAYFA</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
             foreach (var book in Model.Books)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 26 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
                   Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
                   Write(book.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
                                          Write(book.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
                   Write(book.Type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
                   Write(book.NumberOfPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 895, "\"", 928, 2);
            WriteAttributeValue("", 902, "/Admin/UpdateBook/", 902, 18, true);
#nullable restore
#line 30 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
WriteAttributeValue("", 920, book.Id, 920, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Düzenle</a></td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1037, 2);
            WriteAttributeValue("", 1011, "/Admin/DeleteBook/", 1011, 18, true);
#nullable restore
#line 31 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
WriteAttributeValue("", 1029, book.Id, 1029, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Sil</a></td>\n                </tr>\n");
#nullable restore
#line 33 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Admin\Books.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
