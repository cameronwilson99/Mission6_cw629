#pragma checksum "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1860c1329f812f25d042dba71c241b9c80da5cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#line 1 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\_ViewImports.cshtml"
using HiltonMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\_ViewImports.cshtml"
using HiltonMovies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1860c1329f812f25d042dba71c241b9c80da5cbf", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d575fcf6d20606995754ac5a578ebd46cbb0d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HiltonMovies.Models.MovieDatabase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml"
  
    ViewData["Title"] = "New Movie Added!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 10 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml"
     if (Model.Rating == "R")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>I think you should find other forms of entertainment</h1>\r\n        <p>What would your bishop say about ");
#nullable restore
#line 13 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</p>\r\n");
#nullable restore
#line 14 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>New Movie Successfully Added!</h1>\r\n        <p>Enjoy ");
#nullable restore
#line 18 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("! Should be a good one.</p>\r\n");
#nullable restore
#line 19 "C:\Users\camer\source\repos\HiltonMovies\HiltonMovies\Views\Home\Confirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HiltonMovies.Models.MovieDatabase> Html { get; private set; }
    }
}
#pragma warning restore 1591
