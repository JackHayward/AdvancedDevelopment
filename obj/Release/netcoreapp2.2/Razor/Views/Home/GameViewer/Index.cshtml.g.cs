#pragma checksum "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a0e37d0f5f605b13c7af3c18291c02ebc9a96b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GameViewer_Index), @"mvc.1.0.view", @"/Views/Home/GameViewer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GameViewer/Index.cshtml", typeof(AspNetCore.Views_Home_GameViewer_Index))]
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
#line 1 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\_ViewImports.cshtml"
using AdvancedDevelopment;

#line default
#line hidden
#line 2 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\_ViewImports.cshtml"
using AdvancedDevelopment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a0e37d0f5f605b13c7af3c18291c02ebc9a96b", @"/Views/Home/GameViewer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85e6ef12d0b1ea17423d96b179ea9109b79af88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GameViewer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdvancedDevelopment.Models.GameViewer.Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
  
    ViewData["Title"] = "Video Game List";

#line default
#line hidden
            BeginContext(117, 84, true);
            WriteLiteral("\r\n<h1>Video Game List</h1>\r\n\r\n<p>\r\n    <button type=\"submit\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 201, "\"", 258, 5);
            WriteAttributeValue("", 211, "location.href", 211, 13, true);
            WriteAttributeValue(" ", 224, "=", 225, 2, true);
            WriteAttributeValue(" ", 226, "\'", 227, 2, true);
#line 10 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
WriteAttributeValue("", 228, Url.Action("Create", "Game"), 228, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 257, "\'", 257, 1, true);
            EndWriteAttribute();
            BeginContext(259, 100, true);
            WriteLiteral(">Add a Game</button>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(360, 44, false);
#line 16 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(404, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(448, 40, false);
#line 19 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(488, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(532, 44, false);
#line 22 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.GameType));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(620, 43, false);
#line 25 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.GameUrl));

#line default
#line hidden
            EndContext();
            BeginContext(663, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(778, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 35 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
                 if (item.ImageUrl != null)
                {

#line default
#line hidden
            BeginContext(874, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 898, "\"", 931, 1);
#line 37 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
WriteAttributeValue("", 904, Url.Content(item.ImageUrl), 904, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(932, 42, true);
            WriteLiteral(" alt=\"Image\" style=\"max-width: 300px\" />\r\n");
            EndContext();
#line 38 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(993, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1047, 39, false);
#line 41 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1142, 43, false);
#line 44 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GameType));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1242, "", 1261, 1);
#line 47 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
WriteAttributeValue("", 1248, item.GameUrl, 1248, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1261, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1279, 9, false);
#line 47 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 59, true);
            WriteLiteral("</a>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1347, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7a0e37d0f5f605b13c7af3c18291c02ebc9a96b10247", async() => {
                BeginContext(1392, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1400, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1420, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7a0e37d0f5f605b13c7af3c18291c02ebc9a96b12606", async() => {
                BeginContext(1468, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1479, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1499, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7a0e37d0f5f605b13c7af3c18291c02ebc9a96b14971", async() => {
                BeginContext(1546, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1556, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\GameViewer\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1599, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdvancedDevelopment.Models.GameViewer.Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
