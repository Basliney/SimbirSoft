#pragma checksum "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d8b23cc9c98f5399fe93a13330c842acf64e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Humans_Get), @"mvc.1.0.view", @"/Views/Humans/Get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d8b23cc9c98f5399fe93a13330c842acf64e0c", @"/Views/Humans/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60bc33b33d6fe204115d03cb79531396bb8dc9b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Humans_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 1 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
Write(ViewBag.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 2 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
  
    foreach (var human in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h3>ID: ");
#nullable restore
#line 6 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
               Write(human.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h2>Фамилия: ");
#nullable restore
#line 7 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
                    Write(human.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h3>Имя: ");
#nullable restore
#line 8 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
                Write(human.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Отчество: ");
#nullable restore
#line 9 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
                     Write(human.Patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Дата рождения: ");
#nullable restore
#line 10 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
                          Write(human.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\PC\source\repos\SimbirSoft_Appl\SimbirSoft_Appl\Views\Humans\Get.cshtml"
    }

#line default
#line hidden
#nullable disable
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