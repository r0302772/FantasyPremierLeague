#pragma checksum "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f44d6d1b98105cd013cc5e099da46256627f44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dreamteam_Details), @"mvc.1.0.view", @"/Views/Dreamteam/Details.cshtml")]
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
#line 1 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\_ViewImports.cshtml"
using FantasyPremierLeague;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\_ViewImports.cshtml"
using FantasyPremierLeague.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f44d6d1b98105cd013cc5e099da46256627f44", @"/Views/Dreamteam/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d460344f521deeccf8a85fea5fa03ddc212fee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Dreamteam_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FantasyPremierLeague.ViewModels.DreamteamDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml"
  
    ViewData["Title"] = "Details Dreamteam";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details Dreamteam</h2>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Position</th>\r\n            <th>Name</th>\r\n            <th>Points</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml"
         foreach (var item in Model.team)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml"
               Write(item.position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml"
               Write(Model.element_first_and_web_names[Model.team.IndexOf(item)]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 24 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml"
               Write(item.points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Dreamteam\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<h2>Prediction Dreamteam</h2>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Average BPS</th>
            <th>Average ICT</th>
        </tr>
    </thead>
    <tbody>
");
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FantasyPremierLeague.ViewModels.DreamteamDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
