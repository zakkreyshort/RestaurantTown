#pragma checksum "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f86a4aa668458aa91d02a08ed4b50e5873882ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Create), @"mvc.1.0.view", @"/Views/Restaurants/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Create.cshtml", typeof(AspNetCore.Views_Restaurants_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86a4aa668458aa91d02a08ed4b50e5873882ad3", @"/Views/Restaurants/Create.cshtml")]
    public class Views_Restaurants_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantTown.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 32, true);
            WriteLiteral("\n<h4>Add a new restaurant</h4>\n\n");
            EndContext();
#line 9 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(133, 34, false);
#line 11 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(173, 36, false);
#line 12 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(216, 37, false);
#line 14 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(259, 30, false);
#line 15 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
            EndContext();
            BeginContext(291, 76, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new restaurant\" class=\"btn btn-dark\" />\n");
            EndContext();
#line 18 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
}

#line default
#line hidden
            BeginContext(369, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(373, 48, false);
#line 19 "/Users/zakkreyshort/Desktop/RestaurantTown.Solution/Views/Restaurants/Create.cshtml"
Write(Html.ActionLink("Show all restaurants", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(421, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantTown.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
