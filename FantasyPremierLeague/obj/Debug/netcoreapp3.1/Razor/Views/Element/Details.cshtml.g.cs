#pragma checksum "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded4ceb6f3b62c09fff27f71a568fc423b136dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Element_Details), @"mvc.1.0.view", @"/Views/Element/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded4ceb6f3b62c09fff27f71a568fc423b136dc7", @"/Views/Element/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d460344f521deeccf8a85fea5fa03ddc212fee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Element_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FantasyPremierLeague.ViewModels.ElementDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
  
    ViewData["Title"] = $"Details {Model.element.web_name}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details ");
#nullable restore
#line 7 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
       Write(Model.element.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                                 Write(Model.element.web_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 8 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
Write(Model.element_type.singular_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded4ceb6f3b62c09fff27f71a568fc423b136dc75072", async() => {
#nullable restore
#line 9 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                                                                                Write(Model.element.team);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                                                    WriteLiteral(Model.element.team);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n\r\n<table class=\"table table-hover table-striped-columns\">\r\n    <thead>\r\n        <tr>\r\n            <th>GW</th>\r\n            <th>Opponent</th>\r\n            <th>Cost (");
#nullable restore
#line 16 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                 Write(Model.CostDifference);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</th>\r\n            <th>Minutes Played (");
#nullable restore
#line 17 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                           Write(Model.element.minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</th>\r\n            <th>Pts (");
#nullable restore
#line 18 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                Write(Model.element.total_points);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
         foreach (var x in Model.history)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
               Write(x.round);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded4ceb6f3b62c09fff27f71a568fc423b136dc79595", async() => {
#nullable restore
#line 49 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                                                                                             Write(x.opponent_team);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
                                                                    WriteLiteral(x.opponent_team);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
               Write(x.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
               Write(x.minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
               Write(x.total_points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Element\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FantasyPremierLeague.ViewModels.ElementDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591