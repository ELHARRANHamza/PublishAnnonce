#pragma checksum "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc09d186a0859996212a1629f78d50d8e89e57a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Annoces_Delete), @"mvc.1.0.view", @"/Views/Annoces/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Annoces/Delete.cshtml", typeof(AspNetCore.Views_Annoces_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc09d186a0859996212a1629f78d50d8e89e57a", @"/Views/Annoces/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Annoces_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Annonce_Asp.netCore.Models.Annonces>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:500px;height:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("genric-btn danger-border circle arrow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 308, true);
            WriteLiteral(@"<br>
<br>
<br>
<h3 class=""alert alert-danger"">Are you sure you want to delete this? <i class=""fas fa-info-circle"" style=""margin-left:50%""></i></h3>
<div>
    <h4>Annonces</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            Description :
        </dt>
        <dd>
            ");
            EndContext();
            BeginContext(397, 41, false);
#line 18 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ann_Texte));

#line default
#line hidden
            EndContext();
            BeginContext(438, 116, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Email :\r\n        </dt>\r\n        <dd>\r\n            <p style=\"color:black\">");
            EndContext();
            BeginContext(555, 15, false);
#line 24 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
                              Write(Model.Ann_Email);

#line default
#line hidden
            EndContext();
            BeginContext(570, 107, true);
            WriteLiteral("</p>\r\n        </dd>\r\n        <dt>\r\n            N° Du Telephone :\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 41, false);
#line 30 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(719, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Code Postal :\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(819, 43, false);
#line 36 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code_Postal));

#line default
#line hidden
            EndContext();
            BeginContext(862, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Image :\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(955, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3b34f561090417c9a1109ab4a138ce4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 965, "~/Image_Ann/", 965, 12, true);
#line 42 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
AddHtmlAttributeValue("", 977, Model.images, 977, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1027, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1071, 51, false);
#line 45 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.date_Publiciter));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1166, 47, false);
#line 48 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Annoces\Delete.cshtml"
       Write(Html.DisplayFor(model => model.date_Publiciter));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1247, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663a7ceb1d7541a4a0eba1d3f1fac130", async() => {
                BeginContext(1273, 99, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"genric-btn danger circle arrow\" /> |\r\n        ");
                EndContext();
                BeginContext(1372, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710a1143eae241038ab427ed9a882d21", async() => {
                    BeginContext(1440, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1456, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1469, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            DefineSection("principal", async() => {
                BeginContext(1498, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Annonce_Asp.netCore.Models.Annonces> Html { get; private set; }
    }
}
#pragma warning restore 1591
