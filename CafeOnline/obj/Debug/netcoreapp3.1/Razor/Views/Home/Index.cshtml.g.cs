#pragma checksum "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e01004be9bbd3633e5014296279b04974033d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\projects\CafeOnline\CafeOnline\Views\_ViewImports.cshtml"
using CafeOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\CafeOnline\CafeOnline\Views\_ViewImports.cshtml"
using CafeOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e01004be9bbd3633e5014296279b04974033d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bf080a444708959942572560d516cf76c94d03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 6 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
       Write(p.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <span>");
#nullable restore
#line 7 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
         Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 8 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
         Write(p.Thumbnail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 9 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
         Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 10 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
         Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 13 "D:\projects\CafeOnline\CafeOnline\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
