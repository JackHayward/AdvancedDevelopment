#pragma checksum "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Views\Home\Maps\Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d5f4dc6e59659582cbca6f1689e75343b2d53a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Maps_Map), @"mvc.1.0.view", @"/Views/Home/Maps/Map.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Maps/Map.cshtml", typeof(AspNetCore.Views_Home_Maps_Map))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d5f4dc6e59659582cbca6f1689e75343b2d53a", @"/Views/Home/Maps/Map.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85e6ef12d0b1ea17423d96b179ea9109b79af88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Maps_Map : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(37, 534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d5f4dc6e59659582cbca6f1689e75343b2d53a3407", async() => {
                BeginContext(43, 521, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Google Maps example</title>

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAEISN1Z3Wx2bp-msI136KyVL9LlKx-hL0""></script>

    <style type=""text/css"">

        #map_canvas {
            height: 400px;
        }
    </style>
");
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
            BeginContext(571, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(575, 2158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d5f4dc6e59659582cbca6f1689e75343b2d53a5128", async() => {
                BeginContext(581, 2145, true);
                WriteLiteral(@"

    <div class=""col-md-12"">
        <div class=""jumbotron"">
            <h1 class=""display-4"">Basic Google Maps API Integration</h1>
            <p class=""lead"">The maps API has been integrated and several hotspots within Bournemouth University have been highlighted using Javascript.</p>
        </div>
        <input type=""button"" class=""btn btn-primary"" value=""Click to Display Map"" onclick=""DisplayGoogleMap()"" />
        <div id=""map"" style=""width: 100%; height: 400px; margin-top: 10px""></div>
    </div>
    
    <script type=""text/javascript"">
        function DisplayGoogleMap() {
            var map = new google.maps.Map(document.getElementById('map'),
                {
                    zoom: 18,
                    center: { lat: 50.742981, lng: -1.896105 },
                    mapTypeId: google.maps.MapTypeId.SATELLITE
                });

            setMarkers(map);
        }

        var hotspots = [
            ['Sir Michael Cobham Library', 50.742463, -1.895794, 4],
   ");
                WriteLiteral(@"         ['Dylans Bar', 50.742826, -1.896861, 5],
            ['SportBU Gym', 50.742746, -1.896555, 3],
            ['SUBU Building', 50.742680, -1.896285, 2],
            ['Santander', 50.743025, -1.896782, 1]
        ];

        function setMarkers(map) {
            var image = {
                url: 'https://i.imgur.com/zzTCQkL.png',
                size: new google.maps.Size(20, 21),
                origin: new google.maps.Point(0, 0),
                anchor: new google.maps.Point(0, 32)
            };
            var shape = {
                coords: [1, 1, 1, 20, 18, 20, 18, 1],
                type: 'poly'
            };
            for (var i = 0; i < hotspots.length; i++) {
                var hotspot = hotspots[i];
                var marker = new google.maps.Marker({
                    position: { lat: hotspot[1], lng: hotspot[2] },
                    map: map,
                    icon: image,
                    shape: shape,
                    title: hotspot[0],
     ");
                WriteLiteral("               zIndex: hotspot[3]\r\n                });\r\n            }\r\n        }\r\n    </script>\r\n");
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
            BeginContext(2733, 9, true);
            WriteLiteral("\r\n</html>");
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
