#pragma checksum "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53988edb6c5934c8130e894df796a47f84bdb2be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyOrderDetail), @"mvc.1.0.view", @"/Views/Account/MyOrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/MyOrderDetail.cshtml", typeof(AspNetCore.Views_Account_MyOrderDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53988edb6c5934c8130e894df796a47f84bdb2be", @"/Views/Account/MyOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66541b31544ea97532adc383bf2b705c7d6584ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EtradeApp.MvcWebUI.Models.OrderLinesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::EtradeApp.MvcWebUI.TagHelpers.AccountListTagHelper __EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
  
    ViewData["Title"] = "MyOrderDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 820, true);
            WriteLiteral(@"
   <div class=""breadcrumb-area bg-gray"">
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <ul class=""breadcrumb-list"">
                <li class=""breadcrumb-item""><a href=""index.html""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ana Sayfa</font></font></a></li>
                <li class=""breadcrumb-item active""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Siparişlerim</font></font></li>
            </ul>
        </div>
    </div>
</div>
</div>

<div class=""content-wraper"">
    <div class=""container"">
        <div class=""account-dashboard mtb-60"">

            <div class=""row"">
                <div class=""col-md-12 col-lg-2"">
                    <!-- Nav tabs -->
                    ");
            EndContext();
            BeginContext(972, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("account-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53988edb6c5934c8130e894df796a47f84bdb2be5267", async() => {
            }
            );
            __EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper = CreateTagHelper<global::EtradeApp.MvcWebUI.TagHelpers.AccountListTagHelper>();
            __tagHelperExecutionContext.Add(__EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper);
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                 WriteLiteral(Context.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper.PageName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("page-name", __EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper.PageName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1035, 1674, true);
            WriteLiteral(@"


                </div>
                <div class=""col-md-12 col-lg-10"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard-content"">

                        <div id=""orders"" class=""tab-pane fade active show"">
                            <h3><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Tüm Siparişlerim</font></font></h3>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ürün ID</font></font></th>
                                            <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Ürün Adı</font></font></th>
                                            <th><font style=""vertical-align: inherit;""><font styl");
            WriteLiteral(@"e=""vertical-align: inherit;"">Fiyatı</font></font></th>
                                            <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Adet</font></font></th>
                                            <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Toplam</font></font></th>
                                            <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">İşlem</font></font></th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 51 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                         foreach (var Line in Model.OrderLines)
                                        {

#line default
#line hidden
            BeginContext(2833, 180, true);
            WriteLiteral("                                            <tr>\r\n                                                <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3014, 22, false);
#line 54 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                                                                                                             Write(Line.Product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3036, 151, true);
            WriteLiteral("</font></font></td>\r\n                                                <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3188, 24, false);
#line 55 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                                                                                                             Write(Line.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3212, 151, true);
            WriteLiteral("</font></font></td>\r\n                                                <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3364, 22, false);
#line 56 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                                                                                                             Write(Line.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3386, 151, true);
            WriteLiteral("</font></font></td>\r\n                                                <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3538, 13, false);
#line 57 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                                                                                                             Write(Line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3551, 151, true);
            WriteLiteral("</font></font></td>\r\n                                                <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3703, 10, false);
#line 58 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                                                                                                             Write(Line.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3713, 73, true);
            WriteLiteral("</font></font></td>\r\n                                                <td>");
            EndContext();
            BeginContext(3786, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53988edb6c5934c8130e894df796a47f84bdb2be12319", async() => {
                BeginContext(3883, 101, true);
                WriteLiteral("<font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">Ürünü Gör</font></font>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                                                                                                WriteLiteral(Line.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3988, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 61 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrderDetail.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4089, 266, true);
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EtradeApp.MvcWebUI.Models.OrderLinesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
