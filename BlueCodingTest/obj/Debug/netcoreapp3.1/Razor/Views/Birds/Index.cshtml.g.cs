#pragma checksum "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b28d457b9af4e822aec26098695496a1ba7a7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birds_Index), @"mvc.1.0.view", @"/Views/Birds/Index.cshtml")]
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
#line 1 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\_ViewImports.cshtml"
using BlueCodingTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\_ViewImports.cshtml"
using BlueCodingTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b28d457b9af4e822aec26098695496a1ba7a7f9", @"/Views/Birds/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bbd0de2b2daeb8037267ffa379f93b5ba2a01bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Birds_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Birds>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table border=\"1\" style=\"border-collapse: separate; border-spacing: 15px;\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Color</th>\r\n            <th>Origin</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 312, "\"", 325, 1);
#nullable restore
#line 14 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml"
WriteAttributeValue("", 317, item.Id, 317, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                ");
#nullable restore
#line 16 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml"
           Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml"
           Write(item.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\abdul.rana\source\repos\BlueCodingTest\BlueCodingTest\Views\Birds\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Birds>> Html { get; private set; }
    }
}
#pragma warning restore 1591