#pragma checksum "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\Topnav\_CurrentUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91beecbcac9d647ef5f3890a6a854e075a375ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Topnav__CurrentUser), @"mvc.1.0.view", @"/Views/Shared/Topnav/_CurrentUser.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\Topnav\_CurrentUser.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91beecbcac9d647ef5f3890a6a854e075a375ca", @"/Views/Shared/Topnav/_CurrentUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f39acafe3a8059ce6bf45eb2178e6514fb1dad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Topnav__CurrentUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Topnav/_Dropdown", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Current user (right part of the website) -->
<ul class=""navbar-nav align-items-center  ml-auto ml-md-0 "">
    <li class=""nav-item dropdown"">
        <a class=""nav-link pr-0"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <div class=""media align-items-center"">
                <span class=""avatar avatar-sm rounded-circle"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c91beecbcac9d647ef5f3890a6a854e075a375ca6395", async() => {
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
            WriteLiteral("\n                </span>\n                <div class=\"media-body  ml-2  d-none d-lg-block\">\n                    <span class=\"mb-0 text-sm  font-weight-bold\">\n");
#nullable restore
#line 13 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\Topnav\_CurrentUser.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c91beecbcac9d647ef5f3890a6a854e075a375ca7982", async() => {
                WriteLiteral("Hello ");
#nullable restore
#line 15 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\Topnav\_CurrentUser.cshtml"
                                                                                                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n");
#nullable restore
#line 16 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\Topnav\_CurrentUser.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Anonymous User</span>");
#nullable restore
#line 19 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Shared\Topnav\_CurrentUser.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\n                </div>\n            </div>\n        </a>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c91beecbcac9d647ef5f3890a6a854e075a375ca10477", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </li>
</ul>

<!--<!-- Current user (right part of the website) -->
<!--<ul class=""navbar-nav align-items-center  ml-auto ml-md-0 "">
    <li class=""nav-item dropdown"">
        <a class=""nav-link pr-0"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <div class=""media align-items-center"">
                <span class=""avatar avatar-sm rounded-circle"">
                    <img alt=""Image placeholder"" src=""~/img/theme/team-4.jpg"">
                </span>
                <div class=""media-body  ml-2  d-none d-lg-block"">-->
-->
<!--");
            WriteLiteral(@"-->
<!--</div>
            </div>
        </a>
        <partial name=""Topnav/_Dropdown""/>
    </li>
</ul>-->
<!--<div class=""container-fluid"">
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">

        <div>

            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link text-light"" asp-area=""Identity"" asp-page=""/Account/Manage/Index"" title=""Manage""></a>
                </li>
                <li class=""nav-item"">
                    <form class=""form-inline"" action=""/Identity/Account/Logout?returnUrl=%2F"" method=""post"">

                        <input name=""__RequestVerificationToken"" type=""hidden"" value=""CfDJ8Eou11LXqBxLn4DjJYr8W1kQb_3eKwE-0PhCGC9VKcq7fsPhCRfrP-AVs2d3r7c2lA9nl5XnspaViw7_SKQHu29RE1SOsqAITiu378SV2CjSgS2E1vehRCSp5-mGupFHT0OOfd8EMp2pv0jbfoF93Hvvfrlwga3eDJQmEB39tv1yecPKHu7DDFcZKGSsiXPn6A"">
                    </form>
                </li>
            </ul>

        </div>-->
<!-- Navbar links -->
<!--<ul class=""navbar-nav alig");
            WriteLiteral(@"n-items-center ml-md-auto"">
    <li class=""nav-item d-xl-none"">-->
<!-- Sidenav toggler -->
<!--<div class=""pr-3 sidenav-toggler sidenav-toggler-dark active"" data-action=""sidenav-pin"" data-target=""#sidenav-main"">
        <div class=""sidenav-toggler-inner"">
            <i class=""sidenav-toggler-line""></i>
            <i class=""sidenav-toggler-line""></i>
            <i class=""sidenav-toggler-line""></i>
        </div>
    </div>
</li>
<li class=""nav-item d-sm-none"">
    <a class=""nav-link"" href=""#"" data-action=""search-show"" data-target=""#navbar-search-main"">
        <i class=""ni ni-zoom-split-in""></i>
    </a>
</li>
<li class=""nav-item dropdown"">
    <a class=""nav-link"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        <i class=""ni ni-bell-55""></i>
    </a>
    <div class=""dropdown-menu dropdown-menu-xl  dropdown-menu-right  py-0 overflow-hidden"">-->
<!-- Dropdown header -->
<!--<div class=""px-3 py-3"">
    <h6 class=""text-sm text-muted m-0"">You have <strong class=""");
            WriteLiteral(@"text-primary"">1</strong> notifications.</h6>
</div>-->
<!-- List group -->
<!--<div class=""list-group list-group-flush"">
    <a href=""#!"" class=""list-group-item list-group-item-action"">
        <div class=""row align-items-center"">
            <div class=""col-auto"">-->
<!-- Avatar -->
<!--<img alt=""Image placeholder"" src=""/img/theme/team-5.jpg"" class=""avatar rounded-circle"">
            </div>
            <div class=""col ml--2"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div>
                        <h4 class=""mb-0 text-sm"">John Snow</h4>
                    </div>
                    <div class=""text-right text-muted"">
                        <small>3 hrs ago</small>
                    </div>
                </div>
                <p class=""text-sm mb-0"">A new issue has been reported for Argon.</p>
            </div>
        </div>
    </a>
</div>-->
<!-- View all -->
<!--<a href=""#!"" class=""dropdown-item text-center text-primary font-weight-bold py-3");
            WriteLiteral(@""">View all</a>
        </div>
    </li>
    <li class=""nav-item dropdown"">
        <a class=""nav-link"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <i class=""ni ni-ungroup""></i>
        </a>
        <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-dark bg-default dropdown-menu-right"">
            <div class=""row shortcuts px-4"">
                <a href=""#!"" class=""col-4 shortcut-item"">
                    <span class=""shortcut-media avatar rounded-circle bg-gradient-red"">
                        <i class=""ni ni-calendar-grid-58""></i>
                    </span>
                    <small>Calendar</small>
                </a>
                <a href=""#!"" class=""col-4 shortcut-item"">
                    <span class=""shortcut-media avatar rounded-circle bg-gradient-orange"">
                        <i class=""ni ni-email-83""></i>
                    </span>
                    <small>Email</small>
                </a>
                <a href=""#!"" cla");
            WriteLiteral(@"ss=""col-4 shortcut-item"">
                    <span class=""shortcut-media avatar rounded-circle bg-gradient-info"">
                        <i class=""ni ni-credit-card""></i>
                    </span>
                    <small>Payments</small>
                </a>
                <a href=""#!"" class=""col-4 shortcut-item"">
                    <span class=""shortcut-media avatar rounded-circle bg-gradient-green"">
                        <i class=""ni ni-books""></i>
                    </span>
                    <small>Reports</small>
                </a>
                <a href=""#!"" class=""col-4 shortcut-item"">
                    <span class=""shortcut-media avatar rounded-circle bg-gradient-purple"">
                        <i class=""ni ni-pin-3""></i>
                    </span>
                    <small>Maps</small>
                </a>
                <a href=""#!"" class=""col-4 shortcut-item"">
                    <span class=""shortcut-media avatar rounded-circle bg-gradient-yellow"">
                        <i ");
            WriteLiteral(@"class=""ni ni-basket""></i>
                    </span>
                    <small>Shop</small>
                </a>
            </div>
        </div>
    </li>
</ul>-->
<!-- Current user (right part of the website) -->
<!--<ul class=""navbar-nav align-items-center  ml-auto ml-md-0 "">
        <li class=""nav-item dropdown"">
            <a class=""nav-link pr-0"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <div class=""media align-items-center"">
                    <span class=""avatar avatar-sm rounded-circle"">
                        <img alt=""Image placeholder"" src=""/img/theme/team-4.jpg"">
                    </span>
                    <div class=""media-body  ml-2  d-none d-lg-block"">
                    </div>
                </div>
            </a>

            <div class=""dropdown-menu dropdown-menu-right"">
                <div class=""dropdown-header noti-title"">
                    <h6 class=""text-overflow m-0"">Welcome!</h6>
                </div>
 ");
            WriteLiteral(@"               <a href=""/Details"" class=""dropdown-item"">
                    <i class=""ni ni-single-02""></i>
                    <span>My Details</span>
                </a>
                <a href=""/Home/Profile"" class=""dropdown-item"">
                    <i class=""ni ni-settings-gear-65""></i>
                    <span>Settings</span>
                </a>
                <a href=""/Home/Profile"" class=""dropdown-item"">
                    <i class=""ni ni-calendar-grid-58""></i>
                    <span>Activity</span>
                </a>
                <a href=""/Home/Profile"" class=""dropdown-item"">
                    <i class=""ni ni-support-16""></i>
                    <span>Support</span>
                </a>
                <div class=""dropdown-divider""></div>
                <form class=""form-inline"" action=""/Identity/Account/Logout?returnUrl=%2F"" method=""post"">
                    <button type=""submit"" class=""dropdown-item logout"">
                        <i class=""ni ni-user-run""></i>
                 ");
            WriteLiteral(@"       <span class=""logout"">Logout</span>
                    </button>
                    <input name=""__RequestVerificationToken"" type=""hidden"" value=""CfDJ8Eou11LXqBxLn4DjJYr8W1kbTPsVqRR4PJ0b29lyi3-swRTbKVnntCmujkRHz4Xx2Uzy86anPTQiywz4ikQQvp7RtgkvaQy_PPS_AOAyMZ9ZsFhyFjj0c4felwqxAi9EnbmWACygCpGIlt4QZ_MvqimFNO--rBdDeIA-zYx2t1TsPSBmC9A4wUxgGhjfEKuLaA"">
                </form>
            </div>
        </li>
    </ul>

</div>-->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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