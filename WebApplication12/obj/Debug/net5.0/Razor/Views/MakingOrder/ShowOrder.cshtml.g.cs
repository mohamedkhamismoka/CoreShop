#pragma checksum "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032b14b4d8f95f67ea0fd03b362212c98e9e0fef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MakingOrder_ShowOrder), @"mvc.1.0.view", @"/Views/MakingOrder/ShowOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\_ViewImports.cshtml"
using WebApplication12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\_ViewImports.cshtml"
using WebApplication12.BL.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\_ViewImports.cshtml"
using WebApplication12.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032b14b4d8f95f67ea0fd03b362212c98e9e0fef", @"/Views/MakingOrder/ShowOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d41d6eb90e28106da427a5271669b2d7d6cf9d", @"/Views/_ViewImports.cshtml")]
    public class Views_MakingOrder_ShowOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication12.BL.VM.Product_orderVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-pill btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n \r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032b14b4d8f95f67ea0fd03b362212c98e9e0fef5483", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Order Details</title>\r\n    <style>\r\n        label{\r\n            float:left\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032b14b4d8f95f67ea0fd03b362212c98e9e0fef6638", async() => {
                WriteLiteral("\r\n    <center>\r\n\r\n\r\n    <h4 style=\"margin-top:100px;color:red\">Order Details</h4>\r\n    <hr />\r\n    <div id=\"Grid\">\r\n        <h1 style=\"text-align:center;color:red\"> ");
#nullable restore
#line 23 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
                                            Write(TempData["x"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <center>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032b14b4d8f95f67ea0fd03b362212c98e9e0fef7393", async() => {
                    WriteLiteral("\r\n                <label style=\"float:left\">Name:</label><br />\r\n             <input  type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 625, "\"", 654, 1);
#nullable restore
#line 27 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
WriteAttributeValue("", 633, ViewBag.customerName, 633, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" disabled/> <br />\r\n             <label>phone:</label><br />\r\n         <input  type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 766, "\"", 796, 1);
#nullable restore
#line 29 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
WriteAttributeValue("", 774, ViewBag.customerphone, 774, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" disabled/>\r\n         <br />\r\n           <label>Mail:</label><br />\r\n          <input  type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 916, "\"", 945, 1);
#nullable restore
#line 32 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
WriteAttributeValue("", 924, ViewBag.customermail, 924, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" disabled/>\r\n         \r\n          ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </center>
       
        <table style=""font-size: 12pt;width:500px;margin-top:50px"" class=""table table-hover table-striped table-bordered text-center"">
            <tr>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">Product ID</th>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">Product Name</th>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">quantity</th>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">Unit Price</th>
            </tr>
");
#nullable restore
#line 44 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 47 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
                                                              Write(item.pro_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 48 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
                                                              Write(item.product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 49 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
                                                              Write(item.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 50 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
                                                              Write(item.product.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr style=\"color:red\">\r\n              <td>\r\n                Total Price\r\n              </td>\r\n              <td colspan=\"3\"> ");
#nullable restore
#line 57 "C:\Users\EL-Masria\Desktop\Sales_office\WebApplication12\Views\MakingOrder\ShowOrder.cshtml"
                          Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
          </tr>
          <tr style=""text-align:center"">
              <td colspan=""4"">
                       With best Wishes From Mohamdia Co
              </td>
         
          </tr>
        </table>
    </div>
    <br />
        </center>
        <center>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032b14b4d8f95f67ea0fd03b362212c98e9e0fef13726", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </center>\r\n      \r\n\r\n       \r\n  \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication12.BL.VM.Product_orderVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
