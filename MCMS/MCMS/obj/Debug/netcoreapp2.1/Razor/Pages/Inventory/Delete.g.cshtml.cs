#pragma checksum "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20760ce4770c38ab0243f05403cc9e7806b1e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MCMS.Pages.Inventory.Pages_Inventory_Delete), @"mvc.1.0.razor-page", @"/Pages/Inventory/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Inventory/Delete.cshtml", typeof(MCMS.Pages.Inventory.Pages_Inventory_Delete), null)]
namespace MCMS.Pages.Inventory
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20760ce4770c38ab0243f05403cc9e7806b1e60", @"/Pages/Inventory/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dba728b6cdc8ed7fea7570863a23072f94304f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Inventory_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(92, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Inventories</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 59, false);
#line 16 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.GenericName));

#line default
#line hidden
            EndContext();
            BeginContext(324, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(368, 55, false);
#line 19 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.GenericName));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(467, 57, false);
#line 22 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(524, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(568, 53, false);
#line 25 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(621, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(665, 58, false);
#line 28 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.ExpiryDate));

#line default
#line hidden
            EndContext();
            BeginContext(723, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(767, 54, false);
#line 31 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.ExpiryDate));

#line default
#line hidden
            EndContext();
            BeginContext(821, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(865, 66, false);
#line 34 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.StorageTemperature));

#line default
#line hidden
            EndContext();
            BeginContext(931, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(975, 62, false);
#line 37 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.StorageTemperature));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1081, 60, false);
#line 40 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1185, 56, false);
#line 43 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1285, 56, false);
#line 46 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.Strength));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1385, 52, false);
#line 49 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.Strength));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1481, 56, false);
#line 52 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1581, 52, false);
#line 55 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1677, 57, false);
#line 58 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1778, 53, false);
#line 61 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1875, 55, false);
#line 64 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1974, 51, false);
#line 67 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2069, 60, false);
#line 70 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2129, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2173, 56, false);
#line 73 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2273, 64, false);
#line 76 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.ManufacturedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2337, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2381, 60, false);
#line 79 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.ManufacturedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2441, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2485, 53, false);
#line 82 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2538, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2582, 49, false);
#line 85 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2675, 65, false);
#line 88 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.AddedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2740, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2784, 67, false);
#line 91 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.AddedByNavigation.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2851, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2895, 54, false);
#line 94 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventories.Clinic));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2993, 58, false);
#line 97 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventories.Clinic.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3051, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3089, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ad41d6a8244269b0d97e7e4d6b4e18", async() => {
                BeginContext(3109, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3119, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a754d7383944f6395dcb0f9157c7d37", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 102 "F:\New folder\Client\MCMS\MCMS\Pages\Inventory\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Inventories.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3167, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3251, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09ff96db567e431a877aeffb0be86c6e", async() => {
                    BeginContext(3273, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3289, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3302, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MCMS.Pages.Inventory.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MCMS.Pages.Inventory.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MCMS.Pages.Inventory.DeleteModel>)PageContext?.ViewData;
        public MCMS.Pages.Inventory.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
