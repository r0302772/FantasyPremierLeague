#pragma checksum "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Home\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4d0fdb3cdf1c628baa0ae2f3dd94eb0fdd256b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Help), @"mvc.1.0.view", @"/Views/Home/Help.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4d0fdb3cdf1c628baa0ae2f3dd94eb0fdd256b", @"/Views/Home/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d460344f521deeccf8a85fea5fa03ddc212fee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Help : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Home\Help.cshtml"
  
    ViewData["Title"] = "Help";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""display-5"">Bonus Point System</h1>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Action</th>
            <th scope=""col"">BPS</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Playing 1 to 60 minutes</td>
            <td>3</td>
        </tr>
        <tr>
            <td>Playing over 60 minutes</td>
            <td>6</td>
        </tr>
        <tr>
            <td>Goalkeepers and defenders scoring a goal</td>
            <td>12</td>
        </tr>
        <tr>
            <td>Midfielders scoring a goal</td>
            <td>18</td>
        </tr>
        <tr>
            <td>Forwards scoring a goal</td>
            <td>24</td>
        </tr>
        <tr>
            <td>Assists</td>
            <td>9</td>
        </tr>
        <tr>
            <td>Goalkeepers and defenders keeping a clean sheet</td>
            <td>12</td>
        </tr>
        <tr>
            <td>Saving a penalty</td>
            <td>");
            WriteLiteral(@"15</td>
        </tr>
        <tr>
            <td>Save</td>
            <td>2</td>
        </tr>
        <tr>
            <td>Successful open play cross</td>
            <td>1</td>
        </tr>
        <tr>
            <td>Creating a big chance (a chance where the receiving player should score)</td>
            <td>3</td>
        </tr>
        <tr>
            <td>For every 2 clearances, blocks and interceptions (total)</td>
            <td>1</td>
        </tr>
        <tr>
            <td>For every 3 recoveries</td>
            <td>1</td>
        </tr>
        <tr>
            <td>Key pass</td>
            <td>1</td>
        </tr>
        <tr>
            <td>Successful tackle (net*)</td>
            <td>2</td>
        </tr>
        <tr>
            <td>Successful dribble</td>
            <td>1</td>
        </tr>
        <tr>
            <td>Scoring the goal that wins a match</td>
            <td>3</td>
        </tr>
        <tr>
            <td>70 to 79% pass complet");
            WriteLiteral(@"ion (at least 30 passes attempted)</td>
            <td>2</td>
        </tr>
        <tr>
            <td>80 to 89% pass completion (at least 30 passes attempted)</td>
            <td>4</td>
        </tr>
        <tr>
            <td>90%+ pass completion (at least 30 passes attempted)</td>
            <td>6</td>
        </tr>
        <tr>
            <td>Conceding a penalty</td>
            <td>-3</td>
        </tr>
        <tr>
            <td>Missing a penalty</td>
            <td>-6</td>
        </tr>
        <tr>
            <td>Yellow card</td>
            <td>-3</td>
        </tr>
        <tr>
            <td>Red card</td>
            <td>-9</td>
        </tr>
        <tr>
            <td>Own goal</td>
            <td>-6</td>
        </tr>
        <tr>
            <td>Missing a big chance</td>
            <td>-3</td>
        </tr>
        <tr>
            <td>Making an error which leads to a goal</td>
            <td>-3</td>
        </tr>
        <tr>
            ");
            WriteLiteral(@"<td>Making an error which leads to an attempt at goal</td>
            <td>-1</td>
        </tr>
        <tr>
            <td>Being tackled</td>
            <td>-1</td>
        </tr>
        <tr>
            <td>Conceding a foul</td>
            <td>-1</td>
        </tr>
        <tr>
            <td>Being caught offside</td>
            <td>-1</td>
        </tr>
        <tr>
            <td>Shot off target</td>
            <td>-1</td>
        </tr>
    </tbody>
</table>
<p>*Net successful tackles is the total of all successful tackles minus any unsuccessful tackles. Players will not be awarded negative BPS points for this statistic.</p>
<p>Data is supplied by Opta and once it has been marked as final will not be changed. We will not enter into discussion around any of the statistics used to calculate this score for any individual match.</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591