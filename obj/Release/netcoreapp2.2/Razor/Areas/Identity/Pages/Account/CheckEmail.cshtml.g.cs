#pragma checksum "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\Account\CheckEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af7c404a994973aa43134ebada7ba8577aaa9ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdvancedDevelopment.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_CheckEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/CheckEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/CheckEmail.cshtml", typeof(AdvancedDevelopment.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_CheckEmail), null)]
namespace AdvancedDevelopment.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\_ViewImports.cshtml"
using AdvancedDevelopment.Areas.Identity;

#line default
#line hidden
#line 3 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\_ViewImports.cshtml"
using AdvancedDevelopment.Areas.Identity.Data;

#line default
#line hidden
#line 1 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using AdvancedDevelopment.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af7c404a994973aa43134ebada7ba8577aaa9ac", @"/Areas/Identity/Pages/Account/CheckEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b77ed89e159e5af5f7c4b84d5abf3bf97122fa5", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d36efdc66cec69009a104bd5f09141c8d0be1c", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_CheckEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\Account\CheckEmail.cshtml"
  
    ViewData["Title"] = "Check Email";

#line default
#line hidden
            BeginContext(78, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(85, 17, false);
#line 7 "D:\dev\University\AdvancedDevelopment\AdvancedDevelopment\Areas\Identity\Pages\Account\CheckEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 285, true);
            WriteLiteral(@"</h1>
<hr />
<div class=""row"">
    <div class=""col-12"">
        <p>
            Please check your inbox to confirm your account. It should arrive within a couple of minutes. If not, try
            syncing your email or checking the junk folder.
        </p>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckEmailModel>)PageContext?.ViewData;
        public CheckEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591