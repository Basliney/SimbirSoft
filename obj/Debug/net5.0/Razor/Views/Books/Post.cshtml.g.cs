#pragma checksum "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a8357d8e92f425ff4ff98214c6ba67e080ca9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Post), @"mvc.1.0.view", @"/Views/Books/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5a8357d8e92f425ff4ff98214c6ba67e080ca9e", @"/Views/Books/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60bc33b33d6fe204115d03cb79531396bb8dc9b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 1 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
Write(ViewBag.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("    <div>\r\n            <h3>ID: ");
#nullable restore
#line 4 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h2>Название: ");
#nullable restore
#line 5 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h3>Жанр: ");
#nullable restore
#line 6 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
                 Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>ID автора: ");
#nullable restore
#line 7 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
                      Write(Model.AuthorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Имя автора: ");
#nullable restore
#line 8 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
                       Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Фамилия автора: ");
#nullable restore
#line 9 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Books\Post.cshtml"
                           Write(Model.Author.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n");
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
