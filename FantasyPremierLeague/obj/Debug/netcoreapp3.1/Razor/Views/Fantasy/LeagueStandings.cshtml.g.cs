#pragma checksum "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "577094ec010feaa9c8602f235d59cbc24a0b2bf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fantasy_LeagueStandings), @"mvc.1.0.view", @"/Views/Fantasy/LeagueStandings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"577094ec010feaa9c8602f235d59cbc24a0b2bf4", @"/Views/Fantasy/LeagueStandings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d460344f521deeccf8a85fea5fa03ddc212fee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Fantasy_LeagueStandings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FantasyPremierLeague.ViewModels.LeagueDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
  
    ViewData["Title"] = $"{Model.league.name}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
Write(Model.league.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<table class=""table table-hover table-striped-columns"">
    <thead>
        <tr>
            <th data-bs-trigger=""hover focus""
                data-bs-toggle=""popover""
                data-bs-placement=""top""
                data-bs-content=""");
#nullable restore
#line 15 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].entry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                ID\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
           Write(Html.DisplayNameFor(model => model.results_standings_list[0].entry_name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &\r\n                ");
#nullable restore
#line 21 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
           Write(Html.DisplayNameFor(model => model.results_standings_list[0].player_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 26 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].event_total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                GW\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 33 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                Pts.\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 40 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].point_difference_first_place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                PDFP\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 47 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].point_difference_last_place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                PDLP\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 54 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].point_difference_place_up));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                PDPU\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 61 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                            Write(Html.DisplayNameFor(model => model.results_standings_list[0].point_difference_place_down));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                PDPD\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 68 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
         foreach (var x in Model.results_standings_list)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
#nullable restore
#line 71 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.entry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 72 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
               Write(x.entry_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> (");
#nullable restore
#line 72 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                     Write(x.player_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 73 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.event_total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 74 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 75 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.point_difference_first_place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 76 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.point_difference_last_place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 77 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.point_difference_place_up);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 78 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
                                   Write(x.point_difference_place_down);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fantasy\LeagueStandings.cshtml"
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FantasyPremierLeague.ViewModels.LeagueDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
