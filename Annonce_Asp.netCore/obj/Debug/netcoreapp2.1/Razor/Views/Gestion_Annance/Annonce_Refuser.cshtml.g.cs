#pragma checksum "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d42aac9db73fd324de1f645502f5b055d392489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestion_Annance_Annonce_Refuser), @"mvc.1.0.view", @"/Views/Gestion_Annance/Annonce_Refuser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestion_Annance/Annonce_Refuser.cshtml", typeof(AspNetCore.Views_Gestion_Annance_Annonce_Refuser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d42aac9db73fd324de1f645502f5b055d392489", @"/Views/Gestion_Annance/Annonce_Refuser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestion_Annance_Annonce_Refuser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Annonce_Asp.netCore.Models.Annonces>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:90px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1642, true);
            WriteLiteral(@"<h1 class=""h3 mb-2 text-gray-800 alert alert-danger"">Liste Des Annonces Refuser</h1>
<p class=""mb-4"">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the <a target=""_blank"" href=""https://datatables.net"">official DataTables documentation</a>.</p>

<!-- DataTales Example -->
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary""><span class=""fa fa-table""></span> Annonces Refuser</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Description</th>
                        <th>Telephone</th>
                        <th>Email</th>
                        <th>Ville</th>
                        <th>Region</th>
                        <th>Date Publicité</t");
            WriteLiteral(@"h>
                        <th>Images</th>
                        <th>Catégories</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Description</th>
                        <th>Telephone</th>
                        <th>Email</th>
                        <th>Ville</th>
                        <th>Region</th>
                        <th>Date Publicité</th>
                        <th>Images</th>
                        <th>Catégories</th>
                    </tr>
                </tfoot>
                <tbody>
");
            EndContext();
#line 38 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1766, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1829, 31, false);
#line 41 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.Ann_Texte.Substring(0, 50));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 45, true);
            WriteLiteral("......</td>\r\n                            <td>");
            EndContext();
            BeginContext(1906, 14, false);
#line 42 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(1920, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1960, 14, false);
#line 43 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.Ann_Email);

#line default
#line hidden
            EndContext();
            BeginContext(1974, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2014, 21, false);
#line 44 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.ville.ville_Name);

#line default
#line hidden
            EndContext();
            BeginContext(2035, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2075, 22, false);
#line 45 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.region.Region_Nom);

#line default
#line hidden
            EndContext();
            BeginContext(2097, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2137, 20, false);
#line 46 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.date_Publiciter);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2196, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83bbfc53c4de40ae8ef22f2fd7193d21", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2206, "~/Image_Ann/", 2206, 12, true);
#line 47 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
AddHtmlAttributeValue("", 2218, item.images, 2218, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2286, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2326, 23, false);
#line 48 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                           Write(item.categories.nom_Cat);

#line default
#line hidden
            EndContext();
            BeginContext(2349, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 50 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Annonce_Refuser.cshtml"
                    }

#line default
#line hidden
            BeginContext(2410, 86, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Annonce_Asp.netCore.Models.Annonces>> Html { get; private set; }
    }
}
#pragma warning restore 1591
