#pragma checksum "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba95332867b929630d58cb6a03a376d300f73e66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MCMS.Pages.CardPayment.Pages_CardPayment_Card), @"mvc.1.0.razor-page", @"/Pages/CardPayment/Card.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CardPayment/Card.cshtml", typeof(MCMS.Pages.CardPayment.Pages_CardPayment_Card), null)]
namespace MCMS.Pages.CardPayment
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\New folder\Client\MCMS\MCMS\Pages\_ViewImports.cshtml"
using MCMS;

#line default
#line hidden
#line 11 "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba95332867b929630d58cb6a03a376d300f73e66", @"/Pages/CardPayment/Card.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dba728b6cdc8ed7fea7570863a23072f94304f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CardPayment_Card : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml"
  
    ViewData["Title"] = "Card";

#line default
#line hidden
            BeginContext(88, 43, true);
            WriteLiteral("\r\n<h2>Card</h2>\r\n\r\nThis is card payment\r\n\r\n");
            EndContext();
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(241, 513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69a51a315a44ea18b0978ce389685f8", async() => {
                BeginContext(271, 44, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"payment_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 315, "\"", 341, 1);
#line 15 "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml"
WriteAttributeValue("", 323, Model.Payments.Id, 323, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(342, 43, true);
                WriteLiteral(" />\r\n    <article>\r\n        <label>Amount: ");
                EndContext();
                BeginContext(386, 21, false);
#line 17 "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml"
                  Write(Model.Payments.Amount);

#line default
#line hidden
                EndContext();
                BeginContext(407, 139, true);
                WriteLiteral("</label>\r\n    </article>\r\n    <script src=\"//checkout.stripe.com/v2/checkout.js\"\r\n            class=\"stripe-button\"\r\n            data-key=\"");
                EndContext();
                BeginContext(547, 27, false);
#line 21 "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml"
                 Write(Stripe.Value.PublishableKey);

#line default
#line hidden
                EndContext();
                BeginContext(574, 104, true);
                WriteLiteral("\"\r\n            data-locale=\"auto\"\r\n            data-description=\"Medical Fee\"\r\n            data-amount=\"");
                EndContext();
                BeginContext(680, 27, false);
#line 24 "F:\New folder\Client\MCMS\MCMS\Pages\CardPayment\Card.cshtml"
                     Write(Model.Payments.Amount * 100);

#line default
#line hidden
                EndContext();
                BeginContext(708, 39, true);
                WriteLiteral("\" data-currency=\"lkr\">\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<MCMS.Common.MCMS.Common.Utils.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MCMS.Pages.CardPayment.CardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MCMS.Pages.CardPayment.CardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MCMS.Pages.CardPayment.CardModel>)PageContext?.ViewData;
        public MCMS.Pages.CardPayment.CardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591