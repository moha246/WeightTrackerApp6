#pragma checksum "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "164af527070e7ff01f62ab68b3ee9e854bb50c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 3 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
using WeightTrackerApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164af527070e7ff01f62ab68b3ee9e854bb50c37", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f39acafe3a8059ce6bf45eb2178e6514fb1dad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/img-1-1000x600.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
   Layout = "_LayoutProfile";
    ViewData["Title"] = "Details";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-xl-12 order-xl-1\">\n        <div class=\"card card-profile\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "164af527070e7ff01f62ab68b3ee9e854bb50c375489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div class=\"row justify-content-center\">\n                <div class=\"col-lg-3 order-lg-2\">\n                    <div class=\"card-profile-image\">\n                        <a href=\"#\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "164af527070e7ff01f62ab68b3ee9e854bb50c376917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </a>
                    </div>
                </div>
            </div>
            <div class=""card-header text-center border-0 pt-8 pt-md-4 pb-0 pb-md-4"">
                
                <div class=""d-flex justify-content-between"">
                    <a href=""#"" class=""btn btn-sm btn-info mr-4"">Edit Profile</a>
                    <a href=""/Users/Profile"" class=""btn btn-sm btn-default float-right"">Add profile</a>
");
            WriteLiteral("                </div>\n            </div>\n            <div class=\"card-body pt-0 justify-content-center\">\n");
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label class=""form-control-label"" for=""First_Name"">First name</label>
                            <input type=""text"" id=""i"" name=""First_Name"" class=""form-control"" placeholder=""First name""");
            BeginWriteAttribute("value", " value=\"", 1837, "\"", 1862, 1);
#nullable restore
#line 40 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 1845, Model.First_Name, 1845, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label class=""form-control-label"" for=""Last_Name"">Last name</label>
                            <input type=""text"" id=""i"" name=""Last_Name"" class=""form-control"" placeholder=""Last name""");
            BeginWriteAttribute("value", " value=\"", 2226, "\"", 2250, 1);
#nullable restore
#line 46 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 2234, Model.Last_Name, 2234, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label class=""form-control-label"" for=""Age"">Age</label>
                            <input type=""text"" id=""Age"" name=""Age"" class=""form-control"" placeholder=""Age""");
            BeginWriteAttribute("value", " value=\"", 2650, "\"", 2668, 1);
#nullable restore
#line 55 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 2658, Model.Age, 2658, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label class=""form-control-label"" for=""Gender"">Gender</label>
                            <input type=""text"" id=""Gender"" name=""Gender"" class=""form-control"" placeholder=""Gender""");
            BeginWriteAttribute("value", " value=\"", 3025, "\"", 3046, 1);
#nullable restore
#line 61 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 3033, Model.Gender, 3033, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <div class=""form-group"">
                            <label class=""form-control-label"" for=""Email"">Email Address</label>
                            <input type=""email"" id=""Email"" name=""Email"" class=""form-control"" placeholder=""Email Address""");
            BeginWriteAttribute("value", " value=\"", 3472, "\"", 3492, 1);
#nullable restore
#line 69 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 3480, Model.Email, 3480, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        </div>\n                    </div>\n");
            WriteLiteral(@"                </div>


                <hr class=""my-4"" />
                <!-- Address -->
                <h6 class=""heading-small text-muted mb-4"">Contact information</h6>
                <div class=""pl-lg-4"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label class=""form-control-label"" for=""Address"">Address</label>
                                <input id=""Address"" name=""Address"" class=""form-control"" placeholder=""Home Address"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 4529, "\"", 4551, 1);
#nullable restore
#line 89 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 4537, Model.Address, 4537, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label class=""form-control-label"" for=""City"">City</label>
                                <input type=""text"" id=""City"" name=""City"" class=""form-control"" placeholder=""City""");
            BeginWriteAttribute("value", " value=\"", 4987, "\"", 5006, 1);
#nullable restore
#line 97 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 4995, Model.City, 4995, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label class=""form-control-label"" for=""Country"">Country</label>
                                <input type=""text"" id=""Country"" name=""Country"" class=""form-control"" placeholder=""Country""");
            BeginWriteAttribute("value", " value=\"", 5392, "\"", 5414, 1);
#nullable restore
#line 103 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 5400, Model.Country, 5400, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label class=""form-control-label"" for=""Postal_code"">Postal code</label>
                                <input type=""number"" id=""Postal_code"" name=""Postal_code"" class=""form-control"" placeholder=""Postal code""");
            BeginWriteAttribute("value", " value=\"", 5822, "\"", 5848, 1);
#nullable restore
#line 109 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 5830, Model.Postal_code, 5830, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
                <hr class=""my-4"" />
                <!-- Description -->
                <h6 class=""heading-small text-muted mb-4"">About me</h6>
                <div class=""pl-lg-4"">
                    <div class=""form-group"">
                        <label class=""form-control-label"">About Me</label>
                        <textarea rows=""4"" class=""form-control"" name=""About_me"" placeholder=""A few words about you ...""");
            BeginWriteAttribute("value", " value=\"", 6389, "\"", 6412, 1);
#nullable restore
#line 120 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\Details.cshtml"
WriteAttributeValue("", 6397, Model.About_me, 6397, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">A beautiful Dashboard for Bootstrap 4. It is Free and Open Source.</textarea>
                    </div>
                </div>
            </div>
                    
                </div>

                <div class=""text-center"">
                    <h5 class=""h3"">
");
            WriteLiteral(@"<span class=""font-weight-light"">, 27</span>
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
            </div>
        </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Users> Html { get; private set; }
    }
}
#pragma warning restore 1591