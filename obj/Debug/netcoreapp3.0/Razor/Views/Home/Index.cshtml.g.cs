#pragma checksum "D:\Git\Tf\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e38d2acef60cd01af82a61acb721ed304375e8"
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
#line 1 "D:\Git\Tf\Views\_ViewImports.cshtml"
using Triggerfish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\Tf\Views\_ViewImports.cshtml"
using Triggerfish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e38d2acef60cd01af82a61acb721ed304375e8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a071e8dcb01fd32824aa4e1a4bc03510a03fce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Triggerfish.Models.PageViewModels.HomePageViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git\Tf\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e38d2acef60cd01af82a61acb721ed304375e83231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 8 "D:\Git\Tf\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddressList);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\r\n        <hr />\r\n\r\n        <div>\r\n            <ul>\r\n");
#nullable restore
#line 13 "D:\Git\Tf\Views\Home\Index.cshtml"
                  
                    foreach (AddressModel address in Model.AddressList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 17 "D:\Git\Tf\Views\Home\Index.cshtml"
                       Write(address.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <b>");
#nullable restore
#line 17 "D:\Git\Tf\Views\Home\Index.cshtml"
                                             Write(address.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </li>\r\n");
#nullable restore
#line 19 "D:\Git\Tf\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <hr />\r\n        <div>\r\n            <h1 class=\"display-4\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e38d2acef60cd01af82a61acb721ed304375e85767", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "D:\Git\Tf\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostcodeList);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\r\n            <ul>\r\n");
#nullable restore
#line 27 "D:\Git\Tf\Views\Home\Index.cshtml"
                  
                    foreach (string postcode in Model.PostcodeList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <b>");
#nullable restore
#line 31 "D:\Git\Tf\Views\Home\Index.cshtml"
                          Write(postcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </li>\r\n");
#nullable restore
#line 33 "D:\Git\Tf\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Triggerfish.Models.PageViewModels.HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
