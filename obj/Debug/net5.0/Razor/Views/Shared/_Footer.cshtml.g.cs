#pragma checksum "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a5ea217c4674cf9ad597a1b6d7256d5b719f723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\_ViewImports.cshtml"
using WeightTrackerApp6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\_ViewImports.cshtml"
using WeightTrackerApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5ea217c4674cf9ad597a1b6d7256d5b719f723", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f39acafe3a8059ce6bf45eb2178e6514fb1dad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<input type=\"hidden\" id=\"RequestVerificationToken\"\n       name=\"RequestVerificationToken\"");
            BeginWriteAttribute("value", " value=\"", 280, "\"", 314, 1);
#nullable restore
#line 10 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 288, GetAntiXsrfRequestToken(), 288, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

<footer class=""footer"">
    <div class=""row align-items-center justify-content-xl-between"">
        <div class=""col-xl-6"">
            <div class=""copyright text-center text-xl-left text-muted"">
                &copy; 2021
                <a href=""https://www.creative-tim.com"" class=""font-weight-bold ml-1"" target=""_blank"">CLinify</a>
                
                <a href=""https://udevoffice.com/"" class=""font-weight-bold ml-1"" target=""_blank""></a>
            </div>
        </div>
        <div class=""col-xl-6"">
            <ul class=""nav nav-footer justify-content-center justify-content-xl-end"">
                <li class=""nav-item"">
                    <a href=""https://www.creative-tim.com"" class=""nav-link"" target=""_blank"">Clinify</a>
                </li>
                <li class=""nav-item"">
                    <a href=""https://udevoffice.com/"" class=""nav-link"" target=""_blank""></a>
                </li>
                <li class=""nav-item"">
                    <a href=""https://www.creative-tim.com/pres");
            WriteLiteral(@"entation"" class=""nav-link"" target=""_blank"">About Us</a>
                </li>
                <li class=""nav-item"">
                    <a href=""http://blog.creative-tim.com"" class=""nav-link"" target=""_blank""></a>
                </li>
                <li class=""nav-item"">
                    <a href=""https://github.com/creativetimofficial/argon-dashboard/blob/master/LICENSE.md"" class=""nav-link"" target=""_blank""></a>
                </li>
            </ul>
        </div>
    </div>
</footer>
");
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\_Footer.cshtml"
           
    public string GetAntiXsrfRequestToken()
    {
        return Xsrf.GetAndStoreTokens(Context).RequestToken;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; }
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
