#pragma checksum "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05b1cfba01f25cf5afd82a798e808a98cc428fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05b1cfba01f25cf5afd82a798e808a98cc428fd", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66541b31544ea97532adc383bf2b705c7d6584ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EtradeApp.Entities.Concrete.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Cart\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
            BeginContext(145, 24, true);
            WriteLiteral("\r\n    <h1>Index</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Cart\Index.cshtml"
     foreach (var item in Model.CartLines)
    {

#line default
#line hidden
            BeginContext(220, 127, true);
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>Ürün adı</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(348, 24, false);
#line 16 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Cart\Index.cshtml"
               Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(372, 44, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 19 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EtradeApp.Entities.Concrete.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
