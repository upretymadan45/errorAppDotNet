#pragma checksum "/Users/madanuprety/Documents/videos/Views/Home/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a215baaffa4fee2d37ac9acc779f55568833b48e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Error), @"mvc.1.0.view", @"/Views/Home/Error.cshtml")]
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
#line 1 "/Users/madanuprety/Documents/videos/Views/_ViewImports.cshtml"
using videos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/madanuprety/Documents/videos/Views/_ViewImports.cshtml"
using videos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a215baaffa4fee2d37ac9acc779f55568833b48e", @"/Views/Home/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538f800f6f67c2e6baf4ea7b172adab1738b6c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<p>\n    ");
#nullable restore
#line 4 "/Users/madanuprety/Documents/videos/Views/Home/Error.cshtml"
Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br/>\n    <hr>\n    ");
#nullable restore
#line 7 "/Users/madanuprety/Documents/videos/Views/Home/Error.cshtml"
Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <hr>\n    ");
#nullable restore
#line 10 "/Users/madanuprety/Documents/videos/Views/Home/Error.cshtml"
Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
