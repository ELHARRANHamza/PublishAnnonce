#pragma checksum "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d1dbd412640f9768ab558992ae53df205fe962e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialView), @"mvc.1.0.view", @"/Views/Shared/_PartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialView.cshtml", typeof(AspNetCore.Views_Shared__PartialView))]
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
#line 1 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1dbd412640f9768ab558992ae53df205fe962e", @"/Views/Shared/_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:35px;height:35px;border-radius:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(184, 383, true);
            WriteLiteral(@"
   
        <nav>
            <ul id=""navigation"">
                <li><a href=""/Home/index"">Home</a></li>
                <li><a href=""/Annoces/Index"">My Annonce</a></li>
                <li><a href=""about.html"">About</a></li>
                <li><a href=""/Affichage_Latests_News/Index"">Latest News</a></li>
                <li><a href=""/Account/Contact"">Contact</a></li>
");
            EndContext();
#line 14 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    var userId = @UserManager.GetUserId(User);
                    var getuser = UserManager.Users.SingleOrDefault(u => u.Id == userId);
                    

#line default
#line hidden
            BeginContext(815, 46, true);
            WriteLiteral("<li>\r\n\r\n                        <a href=\"#\">\r\n");
            EndContext();
#line 21 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                             if (getuser.image == null)
                            {

#line default
#line hidden
            BeginContext(949, 59, true);
            WriteLiteral("                                <i class=\"fa fa-user\"></i> ");
            EndContext();
            BeginContext(1009, 16, false);
#line 23 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                                                      Write(getuser.UserName);

#line default
#line hidden
            EndContext();
#line 23 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                                                                            

                            }

#line default
#line hidden
            BeginContext(1060, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 26 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                             if (getuser.image != null)
                            {

#line default
#line hidden
            BeginContext(1148, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1180, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a46db7d54ab4455ad23ab5dc7675198", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1262, "~/Image_User/", 1262, 13, true);
#line 28 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
AddHtmlAttributeValue("", 1275, getuser.image, 1275, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1293, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1295, 16, false);
#line 28 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                                                                                                                                             Write(getuser.UserName);

#line default
#line hidden
            EndContext();
#line 28 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                                                                                                                                                                   

                            }

#line default
#line hidden
            BeginContext(1346, 167, true);
            WriteLiteral("                        </a>\r\n                        <ul class=\"submenu\">\r\n                            <li><a href=\"/Change/changePassword\">Change Password</a></li>\r\n");
            EndContext();
#line 34 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                             if (getuser.image == null)
                            {

#line default
#line hidden
            BeginContext(1601, 87, true);
            WriteLiteral("                                <li><a href=\"/Change/change_Image\">Add Image</a></li>\r\n");
            EndContext();
#line 37 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                            }

#line default
#line hidden
#line 37 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                              if (getuser.image != null)
                            {

#line default
#line hidden
            BeginContext(1777, 90, true);
            WriteLiteral("                                <li><a href=\"/Change/change_Image\">Change Image</a></li>\r\n");
            EndContext();
#line 40 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                            }

#line default
#line hidden
            BeginContext(1898, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 41 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                             if (getuser.UserType == "Admin")
                            {

#line default
#line hidden
            BeginContext(1992, 83, true);
            WriteLiteral("                                <li><a href=\"/Categories/Index\">Dashbord</a></li>\r\n");
            EndContext();
#line 44 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                            }

#line default
#line hidden
            BeginContext(2106, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(2138, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d164899a9a840758f34a7ab72c8ab5a", async() => {
                BeginContext(2186, 6, true);
                WriteLiteral("logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2196, 65, true);
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </li>\r\n");
            EndContext();
#line 48 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"

                }

#line default
#line hidden
            BeginContext(2282, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 50 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                 if (!SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
            BeginContext(2356, 190, true);
            WriteLiteral("                    <li><a href=\"/Account/login\"><i class=\"fa fa-lock\"></i> login</a></li>\r\n                    <li><a href=\"/Account/Registre\"><i class=\"fa fa-user\"></i> Register</a></li>\r\n");
            EndContext();
#line 54 "D:\TPM9\Annonce_Asp.netCore\Annonce_Asp.netCore\Views\Shared\_PartialView.cshtml"
                }

#line default
#line hidden
            BeginContext(2565, 39, true);
            WriteLiteral("            </ul>\r\n        </nav>\r\n    ");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Annonce_Asp.netCore.Models.AppUsers> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Annonce_Asp.netCore.Models.AppUsers> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591