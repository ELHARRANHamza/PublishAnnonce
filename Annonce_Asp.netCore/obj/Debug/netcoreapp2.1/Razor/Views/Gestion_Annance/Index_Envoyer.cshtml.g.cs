#pragma checksum "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b95f48360af90106ee1cf4cd2730fa5de5968eb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestion_Annance_Index_Envoyer), @"mvc.1.0.view", @"/Views/Gestion_Annance/Index_Envoyer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestion_Annance/Index_Envoyer.cshtml", typeof(AspNetCore.Views_Gestion_Annance_Index_Envoyer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95f48360af90106ee1cf4cd2730fa5de5968eb6", @"/Views/Gestion_Annance/Index_Envoyer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestion_Annance_Index_Envoyer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Annonce_Asp.netCore.Models.Annonces>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:90px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 471, true);
            WriteLiteral(@"    <h1 class=""h3 mb-2 text-gray-800"">Liste Des Annonces Envoyées</h1>
<p class=""mb-4"">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the <a target=""_blank"" href=""https://datatables.net"">official DataTables documentation</a>.</p>

<!-- DataTales Example -->
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">");
            EndContext();
            BeginContext(522, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "904581bfd16d440ea35de97c1045c878", async() => {
                BeginContext(569, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(583, 1078, true);
            WriteLiteral(@"</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Description</th>
                       
                        <th>Ville</th>
                        <th>Region</th>
                        <th>Date Publicité</th>
                        <th>Images</th>
                        <th>Catégories</th>
                        <th>Validation</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Description</th>
                      
                        <th>Ville</th>
                        <th>Region</th>
                        <th>Date Publicité</th>
                        <th>Images</th>
                        <th>Catégories</th>
                        <th>Validation</th>
                    </tr");
            WriteLiteral(">\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 38 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1734, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1789, 31, false);
#line 41 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                       Write(item.Ann_Texte.Substring(0, 50));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 65, true);
            WriteLiteral("......</td>\r\n                      \r\n                        <td>");
            EndContext();
            BeginContext(1886, 21, false);
#line 43 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                       Write(item.ville.ville_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1907, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1943, 22, false);
#line 44 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                       Write(item.region.Region_Nom);

#line default
#line hidden
            EndContext();
            BeginContext(1965, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2001, 20, false);
#line 45 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                       Write(item.date_Publiciter);

#line default
#line hidden
            EndContext();
            BeginContext(2021, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2056, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a93a67600e043f982053c6e1e1775c9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2066, "~/Image_Ann/", 2066, 12, true);
#line 46 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
AddHtmlAttributeValue("", 2078, item.images, 2078, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2146, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2182, 23, false);
#line 47 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                       Write(item.categories.nom_Cat);

#line default
#line hidden
            EndContext();
            BeginContext(2205, 99, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-outline-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2304, "\"", 2348, 2);
            WriteAttributeValue("", 2311, "/Gestion_Annance/Valider_Ann/", 2311, 29, true);
#line 49 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
WriteAttributeValue("", 2340, item.id, 2340, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2349, 95, true);
            WriteLiteral("><i class=\"fa fa-check\"></i></a>\r\n                            <a class=\"btn btn-outline-danger\"");
            EndContext();
            BeginWriteAttribute("href", "  href=\"", 2444, "\"", 2489, 2);
            WriteAttributeValue("", 2452, "/Gestion_Annance/Refuser_Ann/", 2452, 29, true);
#line 50 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
WriteAttributeValue("", 2481, item.id, 2481, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2490, 92, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 53 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Gestion_Annance\Index_Envoyer.cshtml"
                    }

#line default
#line hidden
            BeginContext(2605, 86, true);
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
