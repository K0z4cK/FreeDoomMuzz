#pragma checksum "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\AllPlaylists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09497b6f481263507e00cb3c3a3041a85d757b3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllPlaylists), @"mvc.1.0.view", @"/Views/Shared/AllPlaylists.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllPlaylists.cshtml", typeof(AspNetCore.Views_Shared_AllPlaylists))]
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
#line 1 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\_ViewImports.cshtml"
using Deezer;

#line default
#line hidden
#line 2 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\_ViewImports.cshtml"
using Deezer.Models;

#line default
#line hidden
#line 3 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\_ViewImports.cshtml"
using Deezer.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09497b6f481263507e00cb3c3a3041a85d757b3e", @"/Views/Shared/AllPlaylists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c56256d5f71a7cbb20fc814938a663145a2b203", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllPlaylists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card__link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 28, true);
            WriteLiteral("<article class=\"card\">\r\n    ");
            EndContext();
            BeginContext(28, 608, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38a0b4d5cbc144d8b4e20e4e7eade699", async() => {
                BeginContext(120, 14, true);
                WriteLiteral("\r\n        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 134, "\"", 152, 1);
#line 3 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\AllPlaylists.cshtml"
WriteAttributeValue("", 140, Model.Image, 140, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(153, 104, true);
                WriteLiteral(" class=\"table_image\" />\r\n        <div class=\"card__header\">\r\n            <h3 class=\"card__header-title\">");
                EndContext();
                BeginContext(258, 10, false);
#line 5 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\AllPlaylists.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(268, 56, true);
                WriteLiteral("</h3>\r\n            <p class=\"card__header-meta\">Tracks: ");
                EndContext();
                BeginContext(325, 19, false);
#line 6 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\AllPlaylists.cshtml"
                                            Write(Model.countOfTrecks);

#line default
#line hidden
                EndContext();
                BeginContext(344, 288, true);
                WriteLiteral(@"</p>
            <div class=""card__header-icon"">
                <svg viewbox=""0 0 28 25"">
                    <path fill=""#fff"" d=""M13.145 2.13l1.94-1.867 12.178 12-12.178 12-1.94-1.867 8.931-8.8H.737V10.93h21.339z"" />
                </svg>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            WriteLiteral("GetPlaylist/");
#line 2 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\AllPlaylists.cshtml"
                                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(636, 18, true);
            WriteLiteral("\r\n</article>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
