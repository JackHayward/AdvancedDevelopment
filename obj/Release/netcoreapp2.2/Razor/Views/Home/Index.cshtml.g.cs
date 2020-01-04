#pragma checksum "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f39c8f2aad146c67bb9139a8f518843a62d35eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f39c8f2aad146c67bb9139a8f518843a62d35eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85e6ef12d0b1ea17423d96b179ea9109b79af88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(531, 1088, true);
            WriteLiteral(@"
<!-- Jumbotron -->
<div class=""jumbotron text-center mx-2 mb-5"">
    <h2 class=""card-title h2"">Cloud Technology Showcase</h2>
    <p class=""my-4 h6"">Wessex Applications Ltd</p>
    <div class=""row d-flex justify-content-center"">
        <div class=""col-xl-7 pb-2"">
            <p class=""card-text"">This application aims to demonstrate my cloud-centric development skills, each section of the website either builds on a previous cloud skill or introduces a new technique or technology. All website data is stored within Google Cloud Platform (NoSQL), either in Cloud Datastore or a PostgreSQL instance hosted within the Google Cloud Platform.</p>
        </div>
    </div>
</div>
<!-- Jumbotron -->

<div class=""row"">
    <div class=""col-lg-4"">
        <h2>Game Viewer Application (CRUD)</h2>
        <img src=""https://image.flaticon.com/icons/svg/1670/1670670.svg"" alt=""Image"" style=""max-width: 100px"" />
        <p>Data is stored within the Google Cloud Datastore (NoSQL) and has create, read, update and ");
            WriteLiteral("delete functionality.</p>\r\n        <p><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1619, "\"", 1654, 1);
#line 27 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Index.cshtml"
WriteAttributeValue("", 1626, Url.Action("Index", "Game"), 1626, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1655, 412, true);
            WriteLiteral(@" role=""button"">View details &raquo;</a></p>
    </div>
    <div class=""col-lg-4"">
        <h2>Basic Google Maps Integration</h2>
        <img src=""https://image.flaticon.com/icons/svg/1034/1034129.svg"" alt=""Image"" style=""max-width: 100px"" />

        <p>Simple Google Maps API integration with a few custom calls from a javascript file to highlight map waypoints.</p>
        <p><a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2067, "\"", 2102, 1);
#line 34 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Index.cshtml"
WriteAttributeValue("", 2074, Url.Action("Index", "Maps"), 2074, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2103, 429, true);
            WriteLiteral(@" role=""button"">View details &raquo;</a></p>
    </div>
    <div class=""col-lg-4"">
        <h2>Live Chatroom Integration</h2>
        <img src=""https://image.flaticon.com/icons/svg/134/134808.svg"" alt=""Image"" style=""max-width: 100px"" />
        <p>Requires two user accounts in the chat room. This feature is built using a .NET library that focuses on real time data called SignalR.</p>
        <p><a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2532, "\"", 2570, 1);
#line 40 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Index.cshtml"
WriteAttributeValue("", 2539, Url.Action("ChatRoom", "Home"), 2539, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2571, 539, true);
            WriteLiteral(@" role=""button"">View details &raquo;</a></p>
    </div>
</div>
<hr style=""opacity: 0"" />
<hr style=""opacity: 0"" />
<hr style=""opacity: 0"" />
<div class=""row"">
    <div class=""col-lg-4"">
        <h2>Trello Api Integration</h2>
        <img src=""https://image.flaticon.com/icons/svg/2405/2405401.svg"" alt=""Image"" style=""max-width: 100px"" />
        <p>Demonstrates integration with the Trello API which allows for the creation and viewing of Trello cards within a predefined example board.</p>
        <p><a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3110, "\"", 3147, 1);
#line 51 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Index.cshtml"
WriteAttributeValue("", 3117, Url.Action("Index", "Trello"), 3117, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3148, 63, true);
            WriteLiteral(" role=\"button\">View details &raquo;</a></p>\r\n    </div>\r\n</div>");
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
