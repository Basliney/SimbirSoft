#pragma checksum "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\LibraryCards\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3a192b3f1b8bae7ca020d0e0aa7569889a87d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LibraryCards_Post), @"mvc.1.0.view", @"/Views/LibraryCards/Post.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\_ViewImports.cshtml"
using SimbirSoft_Appl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3a192b3f1b8bae7ca020d0e0aa7569889a87d9", @"/Views/LibraryCards/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60bc33b33d6fe204115d03cb79531396bb8dc9b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LibraryCards_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h3>\r\n        ");
#nullable restore
#line 3 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\LibraryCards\Post.cshtml"
   Write(ViewBag.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <div>\r\n        <h3>Книга: ");
#nullable restore
#line 6 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\LibraryCards\Post.cshtml"
              Write(Model.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>Читатель (Имя): ");
#nullable restore
#line 7 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\LibraryCards\Post.cshtml"
                       Write(Model.Human.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>Читатель (Фамилия): ");
#nullable restore
#line 8 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\LibraryCards\Post.cshtml"
                           Write(Model.Human.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>Дата и время подбора: ");
#nullable restore
#line 9 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\LibraryCards\Post.cshtml"
                             Write(Model.PickedUp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
