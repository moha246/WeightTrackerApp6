#pragma checksum "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\WeightDetails\WeightDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0faa4ba0a8c932f93999b7d2558d47b8e1d8c95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WeightDetails_WeightDetails), @"mvc.1.0.view", @"/Views/WeightDetails/WeightDetails.cshtml")]
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
#line 2 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\WeightDetails\WeightDetails.cshtml"
using WeightTrackerApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0faa4ba0a8c932f93999b7d2558d47b8e1d8c95", @"/Views/WeightDetails/WeightDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f39acafe3a8059ce6bf45eb2178e6514fb1dad1", @"/Views/_ViewImports.cshtml")]
    public class Views_WeightDetails_WeightDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<WeightDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/img-1-1000x600.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\WeightDetails\WeightDetails.cshtml"
   Layout = "_LayoutProfile";
    ViewData["Title"] = "WeightDetails"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-xl-12 order-xl-1\">\n        <div class=\"card card-profile\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0faa4ba0a8c932f93999b7d2558d47b8e1d8c955623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div class=\"row justify-content-center\">\n                <div class=\"col-lg-3 order-lg-2\">\n                    <div class=\"card-profile-image\">\n");
            WriteLiteral("                    </div>\n                </div>\n            </div>\n\n            <div class=\"card-header text-center border-0 pt-8 pt-md-4 pb-0 pb-md-4\">\n\n                <div class=\"d-flex justify-content-between\">\n");
            WriteLiteral("                    <a href=\"/WeightDetails/WeightDetails\" class=\"btn btn-sm btn-default float-right\">Add Weight Details</a>\n");
            WriteLiteral("                </div>\n            </div>\n            <!--<div class=\"col-xl-4 order-xl-2\">\n    <!--<div class=\"card card-profile\">\n        <img src=\"~/img/theme/img-1-1000x600.jpg\" alt=\"Image placeholder\" class=\"card-img-top\">-->\n            <!--");
            WriteLiteral("\n");
            WriteLiteral(@"-->
            <!--<!--<!--<div class=""card-body pt-0"">
    <div class=""row"">
        <div class=""col"">
            <div class=""card-profile-stats d-flex justify-content-center"">
                <div>
                    <span class=""heading"">22</span>
                    <span class=""description"">Friends</span>
                </div>
                <div>
                    <span class=""heading"">10</span>
                    <span class=""description"">Photos</span>
                </div>
                <div>
                    <span class=""heading"">89</span>
                    <span class=""description"">Comments</span>
                </div>
            </div>
        </div>
    </div>
    <div class=""text-center"">
        <h5 class=""h3"">-->
            <!---->");
            WriteLiteral(@"
            <!--<span class=""font-weight-light"">, 27</span>
            </h5>
            <div class=""h5 font-weight-300"">
                <i class=""ni location_pin mr-2""></i>
                Bucharest, Romania
            </div>
            <div class=""h5 mt-4"">
                <i class=""ni business_briefcase-24 mr-2""></i>
                Solution Manager - Creative Tim Officer
            </div>
            <div>
                <i class=""ni education_hat mr-2""></i>University of Computer Science
            </div>
        </div>
    </div>-->
            <!--</div>-->
            <!--</div>-->

            <div class=""pt-0 justify-content-center"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0faa4ba0a8c932f93999b7d2558d47b8e1d8c959364", async() => {
                WriteLiteral(@"
                    <div class=""card-header"">
                        <div class=""row align-items-center"">
                            <div class=""col-12"">
                                <h3 class=""mb-0"">Add Weight Detials </h3>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
");
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""Weights"">Weight</label>
                                    <input type=""text"" id=""Weights"" name=""Weights"" class=""form-control"" placeholder=""Weight"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""Chest_size"">Chest Size</label>
                                    <input type=""text"" id=""Chest_size"" name=""Chest_size"" class=""form-control"" placeholder=""Chest Size"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6"">
                           ");
                WriteLiteral(@"     <div class=""form-group"">
                                    <label class=""form-control-label"" for=""Height"">Height</label>
                                    <input type=""text"" id=""Height"" name=""Height"" class=""form-control"" placeholder=""Height"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"" for=""Waist_size"">Waist Size</label>
                                    <input type=""text"" id=""Waist_size"" name=""Waist_size"" class=""form-control"" placeholder=""Waist_size"">
                                </div>
                            </div>
                        </div>
");
                WriteLiteral(@"                    </div>

                    <div class=""card-footer"">
                        <div class=""row align-items-center"">
                            <div class=""col-12 text-center"">
                                <button type=""submit"" class=""btn btn-md btn-primary"">
                                    Save
                                </button>
                            </div>
                        </div>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 91 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\WeightDetails\WeightDetails.cshtml"
AddHtmlAttributeValue("", 3653, Url.Action("WeightDetails", "WeightDetails"), 3653, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<WeightDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
