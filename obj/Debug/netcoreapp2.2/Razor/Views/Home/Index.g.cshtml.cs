#pragma checksum "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9eff317ce8bfceb5a114dfa9666f4533be20f4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9eff317ce8bfceb5a114dfa9666f4533be20f4", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Home/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 225, true);
            WriteLiteral("\n<div class=\"jumbotron jumbotron-fluid\">\n  <div class=\"container\">\n    <h1 class=\"display-4\">Goin down, to Restaurant Town!</h1>\n    <p class=\"lead\">This be the place where we put the subtext YARRRRRRRRRR</p>\n  </div>\n</div>\n");
            EndContext();
            BeginContext(253, 111, false);
#line 11 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all restaurants", "Index", "Restaurants", null, new { @class = "btn btn-dark btn-large" }));

#line default
#line hidden
            EndContext();
            BeginContext(364, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(410, 105, false);
#line 13 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all cuisines", "Index", "Cuisines", null, new { @class = "btn btn-dark btn-large" }));

#line default
#line hidden
            EndContext();
            BeginContext(515, 4, true);
            WriteLiteral("<br>");
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
