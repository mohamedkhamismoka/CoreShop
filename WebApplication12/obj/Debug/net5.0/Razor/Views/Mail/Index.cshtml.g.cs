#pragma checksum "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8ebaf023c49b7a7a3608bfda5adcb7af8e10b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mail_Index), @"mvc.1.0.view", @"/Views/Mail/Index.cshtml")]
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
#line 1 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\_ViewImports.cshtml"
using WebApplication12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\_ViewImports.cshtml"
using WebApplication12.BL.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\_ViewImports.cshtml"
using WebApplication12.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ebaf023c49b7a7a3608bfda5adcb7af8e10b0a", @"/Views/Mail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d41d6eb90e28106da427a5271669b2d7d6cf9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Mail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication12.BL.VM.Product_orderVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n \r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8ebaf023c49b7a7a3608bfda5adcb7af8e10b0a4925", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Order Details</title>\r\n    \r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8ebaf023c49b7a7a3608bfda5adcb7af8e10b0a6000", async() => {
                WriteLiteral("\r\n    <center>\r\n\r\n\r\n    <h4 style=\"margin-top:100px;color:red\">Order Details</h4>\r\n    <hr />\r\n    <div id=\"Grid\">\r\n        <h1 style=\"text-align:center;color:red\"> ");
#nullable restore
#line 19 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
                                            Write(TempData["x"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
        <table style=""font-size: 12pt;width:500px"" class=""table table-hover table-striped table-bordered text-center"">
            <tr>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">Product ID</th>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">Product Name</th>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">quantity</th>
                <th style=""background-color: #B8DBFD;border: 1px solid #ccc"">Unit Price</th>
            </tr>
");
#nullable restore
#line 27 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 30 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
                                                              Write(item.pro_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 31 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
                                                              Write(item.product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 32 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
                                                              Write(item.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"width:120px;border: 1px solid #ccc\">");
#nullable restore
#line 33 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
                                                              Write(item.product.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr style=\"color:red\">\r\n              <td>\r\n                Total Price\r\n              </td>\r\n              <td colspan=\"3\"> ");
#nullable restore
#line 40 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8ebaf023c49b7a7a3608bfda5adcb7af8e10b0a9996", async() => {
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"tblHtml\" />\r\n                <input type=\"hidden\" name=\"mail\"");
                    BeginWriteAttribute("value", " value=\"", 2016, "\"", 2037, 1);
#nullable restore
#line 57 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
WriteAttributeValue("", 2024, ViewBag.mail, 2024, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"orderNo\"");
                    BeginWriteAttribute("value", " value=\"", 2094, "\"", 2118, 1);
#nullable restore
#line 58 "C:\Users\EL-Masria\Desktop\flash\WebApplication12\WebApplication12\Views\Mail\Index.cshtml"
WriteAttributeValue("", 2102, ViewBag.orderNo, 2102, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-pill btn-success btnSend\"> Send Mail </button>\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
     </center>
    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
    <script type=""text/javascript"">
        $(function () {
            $("".btnSend"").click(function () {
              
                $(""input[name='tblHtml']"").val($(""#Grid"").html());
            });
        });
    </script>
");
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
