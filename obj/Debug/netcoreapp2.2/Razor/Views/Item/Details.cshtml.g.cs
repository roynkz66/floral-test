#pragma checksum "D:\asp.net\Floral\Views\Item\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "419e0f422f034245c0ee0dafbb65ced4a0cacdbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Details), @"mvc.1.0.view", @"/Views/Item/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/Details.cshtml", typeof(AspNetCore.Views_Item_Details))]
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
#line 1 "D:\asp.net\Floral\Views\_ViewImports.cshtml"
using Floral;

#line default
#line hidden
#line 2 "D:\asp.net\Floral\Views\_ViewImports.cshtml"
using Floral.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e0f422f034245c0ee0dafbb65ced4a0cacdbc", @"/Views/Item/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a7283948e10e5fae2118a4f019a14b93ef0369", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Floral.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\asp.net\Floral\Views\Item\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Item</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(200, 40, false);
#line 14 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(240, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(304, 36, false);
#line 17 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(340, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(403, 40, false);
#line 20 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(443, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(507, 36, false);
#line 23 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(543, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(606, 48, false);
#line 26 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.sellingPrice));

#line default
#line hidden
            EndContext();
            BeginContext(654, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(718, 44, false);
#line 29 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.sellingPrice));

#line default
#line hidden
            EndContext();
            BeginContext(762, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(825, 47, false);
#line 32 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(872, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(936, 43, false);
#line 35 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(979, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1042, 41, false);
#line 38 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.image));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1147, 37, false);
#line 41 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.image));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1247, 41, false);
#line 44 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.stock));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1352, 37, false);
#line 47 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.stock));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1452, 40, false);
#line 50 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cost));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1556, 36, false);
#line 53 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.cost));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1655, 44, false);
#line 56 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.discount));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1763, 40, false);
#line 59 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.discount));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1866, 49, false);
#line 62 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isSellingItem));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1979, 45, false);
#line 65 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.isSellingItem));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2087, 41, false);
#line 68 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isTag));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2192, 37, false);
#line 71 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.isTag));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2292, 43, false);
#line 74 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isStock));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2399, 39, false);
#line 77 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.isStock));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2501, 45, false);
#line 80 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.isPackage));

#line default
#line hidden
            EndContext();
            BeginContext(2546, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2610, 41, false);
#line 83 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.isPackage));

#line default
#line hidden
            EndContext();
            BeginContext(2651, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2714, 44, false);
#line 86 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(2758, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2822, 48, false);
#line 89 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.address));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2933, 49, false);
#line 92 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FlowerPackage));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3046, 48, false);
#line 95 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.FlowerPackage.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3094, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3157, 50, false);
#line 98 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.createDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(3207, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3271, 46, false);
#line 101 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.createDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(3317, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3380, 50, false);
#line 104 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.updateDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(3430, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3494, 46, false);
#line 107 "D:\asp.net\Floral\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.updateDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(3540, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3587, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "419e0f422f034245c0ee0dafbb65ced4a0cacdbc16482", async() => {
                BeginContext(3633, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "D:\asp.net\Floral\Views\Item\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(3641, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3649, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "419e0f422f034245c0ee0dafbb65ced4a0cacdbc18769", async() => {
                BeginContext(3671, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3687, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Floral.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
