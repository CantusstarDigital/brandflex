#pragma checksum "/Users/wernergriesel/Projects/brandflex/Views/Shared/Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929c65efc9b0456b9302a274f7a92ea11fec3c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Navigation), @"mvc.1.0.view", @"/Views/Shared/Navigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Navigation.cshtml", typeof(AspNetCore.Views_Shared_Navigation))]
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
#line 1 "/Users/wernergriesel/Projects/brandflex/Views/_ViewImports.cshtml"
using brandflex;

#line default
#line hidden
#line 2 "/Users/wernergriesel/Projects/brandflex/Views/_ViewImports.cshtml"
using brandflex.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929c65efc9b0456b9302a274f7a92ea11fec3c7b", @"/Views/Shared/Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abeea347608f8ad7369b90809659786603c9a850", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 482, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark fixed-top"">
	<div class=""container-fluid"">
		<a class=""navbar-brand"" href=""/"">Brandflex</a>
		<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
			<span class=""navbar-toggler-icon""></span>
		</button>
	
		<div class=""collapse navbar-collapse"" id=""navbarNav"">
			<ul class=""navbar-nav navbar-nav-hover ml-auto"">
");
            EndContext();
            BeginContext(1026, 164, true);
            WriteLiteral("\t\t\t\t<li class=\"nav-item\"><a class=\"nav-link contact\" href=\"#contact\"><i class=\"fas fa-comment-smile mr-2\"></i>Get in touch</a></li>\n\t\t\t</ul>\n\t\t</div>\n\t</div>\n</nav>");
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