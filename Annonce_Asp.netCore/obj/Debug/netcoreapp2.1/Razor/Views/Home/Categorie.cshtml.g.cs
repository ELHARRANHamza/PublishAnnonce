#pragma checksum "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Home\Categorie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6574eb1b5063c1504d3e56d18817a4dbb6e7e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categorie), @"mvc.1.0.view", @"/Views/Home/Categorie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Categorie.cshtml", typeof(AspNetCore.Views_Home_Categorie))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6574eb1b5063c1504d3e56d18817a4dbb6e7e1c", @"/Views/Home/Categorie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categorie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Annonce_Asp.netCore.Models.Categories>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:360px;height:350px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/news/icon-fb.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/news/icon-tw.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/news/icon-ins.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/news/icon-yo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/news/news_card.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 948, true);
            WriteLiteral(@"
<section class=""whats-news-area pt-50 pb-20"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""row d-flex justify-content-between"">
                    <div class=""col-lg-3 col-md-3"">
                        <div class=""section-tittle mb-30"">
                            <h3>All Catégories</h3>
                        </div>
                    </div>
                   
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <!-- Nav Card -->
                        <div class=""tab-content"" id=""nav-tabContent"">
                          
                            <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                                <div class=""whats-news-caption"">
                                    <div class=""row"">
");
            EndContext();
#line 23 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Home\Categorie.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(1120, 296, true);
            WriteLiteral(@"                                            <div class=""col-lg-6 col-md-6"">
                                                <div class=""single-what-news mb-100"">
                                                    <div class=""what-img"">
                                                        ");
            EndContext();
            BeginContext(1416, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbfebee55d22473087c74f747602dc00", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1426, "~/Image_Cat/", 1426, 12, true);
#line 28 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Home\Categorie.cshtml"
AddHtmlAttributeValue("", 1438, item.Image, 1438, 11, false);

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
            BeginContext(1491, 297, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""what-cap"">
                                                        <span class=""color1"">Night party</span>
                                                        <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1788, "\"", 1821, 2);
            WriteAttributeValue("", 1795, "/Home/Details_Cat/", 1795, 18, true);
#line 32 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Home\Categorie.cshtml"
WriteAttributeValue("", 1813, item.id, 1813, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1822, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1824, 12, false);
#line 32 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Home\Categorie.cshtml"
                                                                                            Write(item.nom_Cat);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 179, true);
            WriteLiteral("</a></h4>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 36 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Home\Categorie.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2058, 786, true);
            WriteLiteral(@"                                        </div>
                                </div>
                            </div>
                          
                        </div>
                        
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <!-- Section Tittle -->
                <div class=""section-tittle mb-40"">
                    <h3>Follow Us</h3>
                </div>
                <!-- Flow Socail -->
                <div class=""single-follow mb-45"">
                    <div class=""single-box"">
                        <div class=""follow-us d-flex align-items-center"">
                            <div class=""follow-social"">
                                <a href=""#"">");
            EndContext();
            BeginContext(2844, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54c3e83cc89b4d408c87fea594c2b6bb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2892, 439, true);
            WriteLiteral(@"</a>
                            </div>
                            <div class=""follow-count"">
                                <span>8,045</span>
                                <p>Fans</p>
                            </div>
                        </div>
                        <div class=""follow-us d-flex align-items-center"">
                            <div class=""follow-social"">
                                <a href=""#"">");
            EndContext();
            BeginContext(3331, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "957a6dd6ad164fc082e73ab2ea14da31", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3379, 439, true);
            WriteLiteral(@"</a>
                            </div>
                            <div class=""follow-count"">
                                <span>8,045</span>
                                <p>Fans</p>
                            </div>
                        </div>
                        <div class=""follow-us d-flex align-items-center"">
                            <div class=""follow-social"">
                                <a href=""#"">");
            EndContext();
            BeginContext(3818, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbcd495828d3444988bbeda74c0a8a4c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3867, 439, true);
            WriteLiteral(@"</a>
                            </div>
                            <div class=""follow-count"">
                                <span>8,045</span>
                                <p>Fans</p>
                            </div>
                        </div>
                        <div class=""follow-us d-flex align-items-center"">
                            <div class=""follow-social"">
                                <a href=""#"">");
            EndContext();
            BeginContext(4306, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5ceb0a8f1db4eb594986361ebc7c607", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4354, 433, true);
            WriteLiteral(@"</a>
                            </div>
                            <div class=""follow-count"">
                                <span>8,045</span>
                                <p>Fans</p>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- New Poster -->
                <div class=""news-poster d-none d-lg-block"">
                    ");
            EndContext();
            BeginContext(4787, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b3bbf7f30f945f19015dd33c73e2bf8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4837, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("principal", async() => {
                BeginContext(4942, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Annonce_Asp.netCore.Models.Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
