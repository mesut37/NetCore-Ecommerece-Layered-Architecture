#pragma checksum "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c6493b06376c1d9bd8564215859030715a035e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyOrders), @"mvc.1.0.view", @"/Views/Account/MyOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/MyOrders.cshtml", typeof(AspNetCore.Views_Account_MyOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c6493b06376c1d9bd8564215859030715a035e3", @"/Views/Account/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66541b31544ea97532adc383bf2b705c7d6584ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EtradeApp.MvcWebUI.Models.OrderListViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
  
    ViewData["Title"] = "MyOrders";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 948, true);
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
            BeginContext(1092, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("account-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c6493b06376c1d9bd8564215859030715a035e34168", async() => {
            }
            );
            __EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper = CreateTagHelper<global::EtradeApp.MvcWebUI.TagHelpers.AccountListTagHelper>();
            __tagHelperExecutionContext.Add(__EtradeApp_MvcWebUI_TagHelpers_AccountListTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
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
            BeginContext(1155, 1644, true);
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
                                                <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Sipariş No</font></font></th>
                                                <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Tarih</font></font></th>");
            WriteLiteral(@"
                                                <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Durum</font></font></th>
                                                <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Toplam</font></font></th>
                                                <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">İşlem</font></font></th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
            EndContext();
#line 49 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
                                             foreach (var order in Model.Orders)
                                            {

#line default
#line hidden
            BeginContext(2928, 188, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3117, 17, false);
#line 52 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
                                                                                                                                 Write(order.OrderNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3134, 155, true);
            WriteLiteral("</font></font></td>\r\n                                                    <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3290, 15, false);
#line 53 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
                                                                                                                                 Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3305, 156, true);
            WriteLiteral("</font></font></td>\r\n                                                    <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\"> ");
            EndContext();
            BeginContext(3462, 42, false);
#line 54 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
                                                                                                                                  Write(Html.DisplayFor(model => order.OrderState));

#line default
#line hidden
            EndContext();
            BeginContext(3504, 156, true);
            WriteLiteral(" </font></font></td>\r\n                                                    <td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(3661, 11, false);
#line 55 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
                                                                                                                                 Write(order.Total);

#line default
#line hidden
            EndContext();
            BeginContext(3672, 93, true);
            WriteLiteral(" </font></font></td>\r\n                                                    <td><a class=\"view\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3765, "\"", 3800, 2);
            WriteAttributeValue("", 3772, "/siparisdetay/", 3772, 14, true);
#line 56 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
WriteAttributeValue("", 3786, order.OrderId, 3786, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3801, 165, true);
            WriteLiteral(" ><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">Detay</font></font></a></td>\r\n                                                </tr>\r\n");
            EndContext();
#line 58 "C:\Users\mesut\Desktop\ETradeApp\ETradeApp\EtradeApp.MvcWebUI\Views\Account\MyOrders.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4013, 333, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EtradeApp.MvcWebUI.Models.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
