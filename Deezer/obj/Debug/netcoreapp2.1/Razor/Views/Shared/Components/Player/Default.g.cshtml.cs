#pragma checksum "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\Components\Player\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ff28ecf44001752237c3c4c433499efa480f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Player_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Player/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Player/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Player_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ff28ecf44001752237c3c4c433499efa480f97", @"/Views/Shared/Components/Player/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c56256d5f71a7cbb20fc814938a663145a2b203", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Player_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 49, true);
            WriteLiteral("\r\n\r\n\r\n<audio id=\"cs_audio\" controls>\r\n    <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 148, "\"", 170, 1);
#line 5 "C:\Users\user.itstep\Source\Repos\FreeDoomMuzz\Deezer\Views\Shared\Components\Player\Default.cshtml"
WriteAttributeValue("", 154, Model.File.Path, 154, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(171, 1281, true);
            WriteLiteral(@" type=""audio/mpeg"" />
</audio>
<div style=""text-align: center;"">

    <div id=""cs_audioplayer"">

        <span style=""position: relative;left: 0;float: left;font-size: 0.87em;""><span id=""cs_audio_current_time"">0:0</span></span>

        <span id=""cs_play_pause_btn"" style=""position: relative;"">
            <i class=""far fa-play-circle"" id=""cs_audio_play""></i>
            <i class=""far fa-pause-circle"" id=""cs_audio_pause""></i>
        </span>

        <span id=""cs_audio_sound"" style=""position: relative;right: 5px;float: right;margin-left: 15px;top: -2px;"">
            <i style=""vertical-align: middle;font-size: 1.14em;"" class=""fas fa-volume-down""></i>
            <div class=""cs_volBar"" style=""height: 6px; width: 65px;background-color: #ccc;display: inline-block;cursor: pointer;"">
                <div class=""cs_volume"" style=""height: 6px;width: 28px;background-color: #3b58ff;position: absolute;""></div>
            </div>

        </span>
        <span id=""cs_audio_duration"" style=""position: r");
            WriteLiteral(@"elative;right: 0;float: right;padding-left: 10px;font-size: 0.87em;""></span>

        <div class=""cs_audio_bar"">
            <div class=""cs_audio_bar_now""></div>
            <div class=""cs_audio_bar_loaded""></div>
        </div>

    </div>
</div>
");
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
