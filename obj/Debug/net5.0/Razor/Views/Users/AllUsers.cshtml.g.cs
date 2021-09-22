#pragma checksum "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd00f1d9e5b1b9aa702d55c41d53e46bbf89fa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AllUsers), @"mvc.1.0.view", @"/Views/Users/AllUsers.cshtml")]
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
#line 2 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
using WeightTrackerApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd00f1d9e5b1b9aa702d55c41d53e46bbf89fa4", @"/Views/Users/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f39acafe3a8059ce6bf45eb2178e6514fb1dad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Breadcrumbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
  
    ViewData["Title"] = "User Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>UserDashboard</h1>


<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""card bg-default"">
            <!-- Card header -->
            <div class=""card-header border-0"">
                <h3 class=""mb-0"">Light table</h3>
            </div>
            <!-- Light table -->
            <div class=""table-responsive"">
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">First Name</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Last Name</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Age</th>
                            <th scope=""col"">Gender</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody class=""list"">

");
#nullable restore
#line 34 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
                         if (Model.Any())
                        {
                            foreach (var user in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1309, "\"", 1357, 1);
#nullable restore
#line 39 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
WriteAttributeValue("", 1316, Url.Action("Users",new { id = user.Id }), 1316, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
                                                                           Write(user.First_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
                       Write(user.Last_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
                       Write(user.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
                       Write(user.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>");
#nullable restore
#line 43 "C:\Users\Savannah-104\Desktop\WeightTrackerApp6\Views\Users\AllUsers.cshtml"
                         }
                                }


                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <!-- Card footer -->
            <div class=""card-footer py-4"">
                <nav aria-label=""..."">
                    <ul class=""pagination justify-content-end mb-0"">
                        <li class=""page-item disabled"">
                            <a class=""page-link"" href=""#"" tabindex=""-1"">
                                <i class=""fas fa-angle-left""></i>
                                <span class=""sr-only"">Previous</span>
                            </a>
                        </li>
                        <li class=""page-item active"">
                            <a class=""page-link"" href=""#"">1</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                        </li>
                                </a>
                        </li>
                    </u");
            WriteLiteral(@"l>
                </nav>
            </div>
        </div>
    </div>
</div>

<div class=""card-header bg-transparent"">
    <div class=""row align-items-center"">
        <div class=""col"">
            <h6 class=""text-light text-uppercase ls-1 mb-1"">Overview</h6>
            <h5 class=""h3 text-white mb-0"">Graphical Chart</h5>
        </div>
        <div class=""col"">
            <ul class=""nav nav-pills justify-content-end"">
                <li class=""nav-item mr-2 mr-md-0"" data-toggle=""chart"" data-target=""#chart-sales-dark"" data-update='{""data"":{""datasets"":[{""data"":[0, 20, 40, 50, 60, 80, 100, 120, 140]}]}}' data-prefix="""" data-suffix=""kg"">
                    <a href=""#"" class=""nav-link py-2 px-3 active"" data-toggle=""tab"">
                        <span class=""d-none d-md-block"">Month</span>
                        <span class=""d-md-none"">M</span>
                    </a>
                </li>
                <li class=""nav-item"" data-toggle=""chart"" data-target=""#chart-sales-dark"" data-updat");
            WriteLiteral(@"e='{""data"":{""datasets"":[{""data"":[0, 20, 40, 50, 60, 80, 100, 120, 140]}]}}' data-prefix="""" data-suffix=""kg"">
                    <a href=""#"" class=""nav-link py-2 px-3"" data-toggle=""tab"">
                        <span class=""d-none d-md-block"">Week</span>
                        <span class=""d-md-none"">W</span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>
<div class=""card-body"">
    <!-- Chart -->
    <div class=""chart"">
        <!-- Chart wrapper -->
        <canvas id=""chart-sales-dark"" class=""chart-canvas""></canvas>
    </div>
</div>
      
<div class=""col-xl-4"">
    <div class=""card"">
        <div class=""card-header bg-transparent"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h6 class=""text-uppercase text-muted ls-1 mb-1"">Over ALL Performance</h6>
                    <h5 class=""h3 mb-0""></h5>
                </div>
            </div>
        </div>
        <div class=");
            WriteLiteral("\"card-body\">\r\n            <!-- Chart -->\r\n            <div class=\"chart\">\r\n                <canvas id=\"chart-bars\" class=\"chart-canvas\"></canvas>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("DashboardCards", async() => {
                WriteLiteral(@"
    <!-- 2nd Row: Card stats (only for dashboard) -->
    <div class=""row"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Weight</h5>
                            <span class=""h2 font-weight-bold mb-0"">70kg</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-red text-white rounded-circle shadow"">
                                <i class=""ni ni-user-run""></i>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3 mb-0 text-sm"">
                        <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                        <s");
                WriteLiteral(@"pan class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">BMI Calculator</h5>
                            <span class=""h2 font-weight-bold mb-0"">2,356</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-orange text-white rounded-circle shadow"">
                                <i class=""ni ni-chart-pie-35""></i>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3 mb-0 text-sm"">
                        <span class=""text-success mr-2"">");
                WriteLiteral(@"<i class=""fa fa-arrow-up""></i> 3.48%</span>
                        <span class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Calories Counter</h5>
                            <span class=""h2 font-weight-bold mb-0"">924</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                                <i class=""ni ni-money-coins""></i>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3 mb-");
                WriteLiteral(@"0 text-sm"">
                        <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                        <span class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Food Tips</h5>
                            <span class=""h2 font-weight-bold mb-0""></span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-info text-white rounded-circle shadow"">
                                <i class=""ni ni-chart-bar-32""></i>
                            </div>
                        </div>
       ");
                WriteLiteral(@"             </div>
                    <p class=""mt-3 mb-0 text-sm"">
                        <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i></span>
                        <span class=""text-nowrap""></span>
                    </p>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Breadcrumbs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bd00f1d9e5b1b9aa702d55c41d53e46bbf89fa415360", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
