#pragma checksum "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\Home\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4eee830b69dbf8c6aa1764d3f9d93a880905853"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Project), @"mvc.1.0.view", @"/Views/Home/Project.cshtml")]
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
#line 1 "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\_ViewImports.cshtml"
using MainShowCase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\_ViewImports.cshtml"
using MainShowCase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4eee830b69dbf8c6aa1764d3f9d93a880905853", @"/Views/Home/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb34fecdeb077dfea4a28ef86e75354a2cf4ceb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\Home\Project.cshtml"
  
    ViewData["Title"] = "Mina projekt";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=header>
	<h2> Vällkomen till mina projekt! </h2>
	<p> Här kan du kolla igenom alla mina små till stora projekt. Det kan vara allt ifrån en miniräknare till animation</p>
	<p> Tips på vilka program du kan använda för att köra mina projekt finns här: Tips!</p>
</section>

<div id=""container"">
	<div id=""row"">

");
#nullable restore
#line 13 "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\Home\Project.cshtml"
         foreach (var project in ViewBag.project)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"slot\">\r\n\t\t\t\t<p>");
#nullable restore
#line 16 "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\Home\Project.cshtml"
              Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 18 "C:\Users\kevin\Documents\repos\Main-showcase\.Net\MainShowCase\MainShowCase\Views\Home\Project.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t</div>\r\n</div>\r\n\r\n");
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
