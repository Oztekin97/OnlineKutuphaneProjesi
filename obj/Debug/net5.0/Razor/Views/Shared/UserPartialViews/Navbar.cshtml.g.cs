#pragma checksum "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Shared\UserPartialViews\Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15643638a47d26d1cf60d112ae08a445babb3dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_UserPartialViews_Navbar), @"mvc.1.0.view", @"/Views/Shared/UserPartialViews/Navbar.cshtml")]
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
#nullable restore
#line 1 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Shared\UserPartialViews\Navbar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15643638a47d26d1cf60d112ae08a445babb3dac", @"/Views/Shared/UserPartialViews/Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76a04a78eae82b38dc19f9396404c0820ae56e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_UserPartialViews_Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DefaultPicture/defaultAvatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-align:middle; width:40px; height:40px; border-radius:50%; margin-right:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Shared\UserPartialViews\Navbar.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Shared\UserPartialViews\Navbar.cshtml"
  
    var name = String.Format("{0} {1}", HttpContextAccessor.HttpContext.Session.GetString("name"), HttpContextAccessor.HttpContext.Session.GetString("lastname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-light"" style=""background-color: darkcyan"">
    <div class=""container p-0"">
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <i class=""fas fa-bars text-white"" style=""font-size:1.75rem""></i>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                <li class=""nav-item""><a class=""nav-link active text-white"" href=""/User/Books"" style=""padding-left:0px;"">Kitap Listeleri</a></li>
                <li class=""nav-item""><a class=""nav-link active text-white"" href=""/User/EditProfil"">Profil Düzenleme</a></li>
                <li class=""nav-item""><a class=""nav-link active text-white"" href=""/User/RulesOfLibrary"">Uyulacak Kurallar</a></li>
                <li class=""nav-item""><a class=""nav-link active te");
            WriteLiteral("xt-white\" href=\"/User/Contact\">İletişim</a></li>\n                <li class=\"nav-item\"><a class=\"nav-link active text-white\" href=\"/Auth/Logout\">Çıkış</a></li>\n            </ul>\n            <div class=\"d-flex\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15643638a47d26d1cf60d112ae08a445babb3dac5997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <ul class=\"navbar-nav me-auto mb-2 mb-lg-0\">\n                    <li class=\"nav-item nav-link active text-white\" style=\"padding-right:0px;\">");
#nullable restore
#line 28 "C:\Users\aoztk\source\repos\GaziLibrary-master\GaziLibrary\Views\Shared\UserPartialViews\Navbar.cshtml"
                                                                                          Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                </ul>\n            </div>\n        </div>\n    </div>\n</nav>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
