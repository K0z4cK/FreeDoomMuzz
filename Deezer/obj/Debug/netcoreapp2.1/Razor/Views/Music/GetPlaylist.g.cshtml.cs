#pragma checksum "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Music\GetPlaylist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43e8b8d421a3bf109c00b839c5df468a296633b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_GetPlaylist), @"mvc.1.0.view", @"/Views/Music/GetPlaylist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Music/GetPlaylist.cshtml", typeof(AspNetCore.Views_Music_GetPlaylist))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43e8b8d421a3bf109c00b839c5df468a296633b", @"/Views/Music/GetPlaylist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c56256d5f71a7cbb20fc814938a663145a2b203", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_GetPlaylist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Music\GetPlaylist.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(59, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5150ac460d294c88aedde5321360089f", async() => {
                BeginContext(65, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>GetPlaylist</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(167, 578, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9108d25b1f234b69ae72b83410d76eb2", async() => {
                BeginContext(173, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(184, 13, false);
#line 12 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Music\GetPlaylist.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(197, 311, true);
                WriteLiteral(@"</h1>
    <table class=""table table-hover"">
        <tr>
            <th>
                №
            </th>
            <th>
                Name
            </th>
            <th>
                Artist
            </th>
            <th>
                Album
            </th>
        </tr>
");
                EndContext();
#line 28 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Music\GetPlaylist.cshtml"
          
            int i = 1;
            foreach (Treck item in Model.GetPlaylist)
            {

                

#line default
#line hidden
                BeginContext(633, 41, false);
#line 33 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Music\GetPlaylist.cshtml"
           Write(await Html.PartialAsync("AllTreks", item));

#line default
#line hidden
                EndContext();
#line 33 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Music\GetPlaylist.cshtml"
                                                          
                ++i;
            }
        

#line default
#line hidden
                BeginContext(724, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(745, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
