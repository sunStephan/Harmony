#pragma checksum "C:\Users\prietenC\Desktop\kata-uri\Harmony\Harmony\Views\Lessons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43c23f9754971e802b455e121497a7dbb7e650fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lessons_Index), @"mvc.1.0.view", @"/Views/Lessons/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\prietenC\Desktop\kata-uri\Harmony\Harmony\Views\_ViewImports.cshtml"
using Harmony;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prietenC\Desktop\kata-uri\Harmony\Harmony\Views\_ViewImports.cshtml"
using Harmony.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43c23f9754971e802b455e121497a7dbb7e650fe", @"/Views/Lessons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f468a1689c41370f5b1d4a9ec254c458c817fa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Lessons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/lesson_style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CircleOfFifths", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.3em; text-decoration: none; color: white; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ends", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\prietenC\Desktop\kata-uri\Harmony\Harmony\Views\Lessons\Index.cshtml"
  
    ViewBag.Title = "Lessons";
    Layout = "~/Views/Shared/_LessonLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"background\">\r\n    <img src=\"/Images/lessonBackground.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 160, "\"", 166, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43c23f9754971e802b455e121497a7dbb7e650fe5853", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43c23f9754971e802b455e121497a7dbb7e650fe6115", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral(@"


<div id=""grid-container"" style=""display: grid; column-gap:6.9em; grid-template-columns: auto auto; margin-left:-36px;"">

    <div class=""card-container"">
        <div class=""card u-clearfix"" style=""height:520px;"">
            <div class=""card-body"">
                <span class=""card-number card-circle subtle"">01</span>
                <h2 class=""card-title"">Your first steps... a history of sound!</h2>
                <span class=""card-description subtle"">Read this short introduction to learn about the nature of sound. Discover how physics, art and programming come together!</span>
                <div class=""card-read extra-button"" style="" font-size: 1.3em;"">Go to lesson</div>
            </div>
            <img src=""/Images/Lessons/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1021, "\"", 1027, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""card-media"" />
        </div>
        <div class=""card-shadow""></div>
    </div>

    <div class=""card-container"">
        <div class=""card u-clearfix"" style=""height:520px;"">
            <div class=""card-body"">
                <span class=""card-number card-circle subtle"">02</span>
                <h2 class=""card-title"">Meet the notes. Find which scale they visit.</h2>
                <span class=""card-description subtle"">This will be your introduction to scales and notes. You will soon discover their characteristics and how to put them together. Remember: intervals.</span>
                <div class=""card-read extra-button"" style="" font-size: 1.3em;"">Go to lesson</div>
            </div>
            <img src=""/Images/Lessons/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1790, "\"", 1796, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""card-media"" />
        </div>
        <div class=""card-shadow""></div>
    </div>

    <div class=""card-container"">
        <div class=""card u-clearfix"" style=""height:520px;"">
            <div class=""card-body"">
                <span class=""card-number card-circle subtle"">03</span>
                <h2 class=""card-title"">Chords,and how they like to play together.</h2>
                <span class=""card-description subtle"">Chords don't all like each other. Some chords like each other more than others. Notes make chords and guess what? They like intervals.  </span>
                <div class=""card-read extra-button"" style="" font-size: 1.3em;"">Go to lesson</div>
            </div>
            <img src=""/Images/Lessons/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2546, "\"", 2552, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""card-media"" />
        </div>
        <div class=""card-shadow""></div>
    </div>

    <div class=""card-container"">
        <div class=""card u-clearfix"" style=""height:520px;"">
            <div class=""card-body"">
                <span class=""card-number card-circle subtle"">04</span>
                <h2 class=""card-title"">The Circle of Fifths</h2>
                <span class=""card-description subtle"">Put your chords knowledge to good use and reach ""Harmony"". Pun intended. The Circle of Fifths will teach you how to put together harmonies and build the foundations of music making.</span>
                <div class=""card-read extra-button"" >");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43c23f9754971e802b455e121497a7dbb7e650fe11443", async() => {
                WriteLiteral("Go to lesson");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            </div>\r\n            <img src=\"/Images/Lessons/4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3421, "\"", 3427, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-media\" />\r\n        </div>\r\n        <div class=\"card-shadow\"></div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43c23f9754971e802b455e121497a7dbb7e650fe13229", async() => {
                WriteLiteral("<img src=\"/Images/logoutButton.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3612, "\"", 3618, 0);
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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