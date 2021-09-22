#pragma checksum "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\BMI\BMI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde9030885cf6abdccdf28f9d2cb10f60b025551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMI_BMI), @"mvc.1.0.view", @"/Views/BMI/BMI.cshtml")]
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
#line 3 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\BMI\BMI.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\BMI\BMI.cshtml"
using WeightTrackerApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde9030885cf6abdccdf28f9d2cb10f60b025551", @"/Views/BMI/BMI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f39acafe3a8059ce6bf45eb2178e6514fb1dad1", @"/Views/_ViewImports.cshtml")]
    public class Views_BMI_BMI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<BMI>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("techBMI"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\BMI\BMI.cshtml"
   Layout = "_LayoutProfile";
    ViewData["Title"] = "BMIInput"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<div class=\"card-body pt-0 justify-content-center\">\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde9030885cf6abdccdf28f9d2cb10f60b0255514431", async() => {
                WriteLiteral(@"
        <h3>BMI Calculator</h3>
        <br />
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label class=""form-control-label"">Enter Weight (Kg)</label>
                    <input type=""text"" name=""weight"" class=""form-control"" placeholder=""Enter Weight (kg)"" s>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label class=""form-control-label"">Enter Height (Meters)</label>
                    <input type=""text"" name=""height"" class=""form-control"" placeholder=""Enter Height (Meters)"">
                </div>
            </div>
        </div>

        <div class=""card-footer"">
            <div class=""row align-items-center"">
                <div class=""col-12 text-center"">
                    <input type=""button"" value=""Calculate"" onclick=""calculateBmi()"" class=""btn btn-md btn-primary"">
                </div>
            </div>
        </div>

        ");
                WriteLiteral(@"<hr class=""my-4"" />

        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""form-group"">
                    <label class=""form-control-label"" for=""BMICount"">BMI</label>
                    <input type=""text"" id=""BMICount"" name=""BMICount"" class=""form-control"" placeholder=""YOUR BMI WILL BE HERE"">

");
                WriteLiteral(@"                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""form-group"">
                    <label class=""form-control-label""></label>
                    <input type=""text"" name=""meaning"" class=""form-control"">
                </div>
            </div>
        </div>

        <div class=""card-footer"">
            <div class=""row align-items-center"">
                <div class=""col-12 text-center"">
                    <input type=""reset"" value=""Reset"" onclick=""calculateBmi()"" class=""btn btn-md btn-primary"" />
                </div>
            </div>
        </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\BMI\BMI.cshtml"
AddHtmlAttributeValue("", 1091, Url.Action("BMI", "BMI"), 1091, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<script>
    function calculateBmi() {
        var weight = document.techBMI.weight.value
        var height = document.techBMI.height.value
        if (weight > 0 && height > 0) {
            var finalBmi = weight / (height * height)
            document.techBMI.BMICount.value = finalBmi.toFixed(3);
            if (finalBmi < 18.5) {
                document.techBMI.meaning.value = ""You are unhealthy, too thin.""
            }
            if (finalBmi > 18.5 && finalBmi < 25) {
                document.techBMI.meaning.value = ""You are healthy enough.""
            }
            if (finalBmi > 25 && finalBmi < 30) {
                document.techBMI.meaning.value = ""You have overweight.""
            }
            if (finalBmi > 30) {
                document.techBMI.meaning.value = ""Your condition is serious.""
            }
        }
        else {
            alert(""Data you've entered might be incorrect. Please check and try again."")
        }

    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<BMI>> Html { get; private set; }
    }
}
#pragma warning restore 1591
