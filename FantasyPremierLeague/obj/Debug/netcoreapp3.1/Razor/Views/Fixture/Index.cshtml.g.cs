#pragma checksum "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fixture_Index), @"mvc.1.0.view", @"/Views/Fixture/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52ef92d5844bac0f8583e6328e0b4aaaf67d76f", @"/Views/Fixture/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d460344f521deeccf8a85fea5fa03ddc212fee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Fixture_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FantasyPremierLeague.ViewModels.FixtureListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("team"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("() => submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("phase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fixture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
  
    ViewData["Title"] = "Fixtures";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-5\">Fixtures</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f7407", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-3\">\r\n            <label for=\"team\" class=\"col-form-label\">Team</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f7815", async() => {
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f8099", async() => {
                        WriteLiteral("All");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.team_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.teams_selectlist;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <label for=\"event\" class=\"col-form-label\">Gameweek</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f11537", async() => {
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f11822", async() => {
                        WriteLiteral("All");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 21 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.event_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.events_selectlist;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <label for=\"phase\" class=\"col-form-label\">Phase</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f15260", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 27 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.phase_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.phases_selectlist;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n");
                WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-auto\">\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div>\r\n    <span>Winner prediction true = ");
#nullable restore
#line 40 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                              Write(Model.prediction_true_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 40 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                             Write(Model.fixtures_list.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </span>\r\n    <span>Hometeam won = ");
#nullable restore
#line 41 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                    Write(Model.team_h_win_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                              Write(Model.fixtures_list.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </span>\r\n    <span>Draw prediction = ");
#nullable restore
#line 42 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                       Write(Model.draw_predicted_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 42 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                     Write(Model.fixtures_list.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </span>\r\n    <span>Draws = ");
#nullable restore
#line 43 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
             Write(Model.draw_count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 43 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                 Write(Model.fixtures_list.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </span>\r\n</div>\r\n\r\n<table class=\"table table-hover table-striped-columns\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 53 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                            Write(Html.DisplayNameFor(model => model.fixtures_list[0].Event));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                GW\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fixtures_list[0].team_h));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                (");
#nullable restore
#line 59 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.fixtures_list[0].team_a_difficulty));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </th>\r\n            <th>");
#nullable restore
#line 61 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fixtures_list[0].team_h_score));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fixtures_list[0].team_a));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                (");
#nullable restore
#line 64 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.fixtures_list[0].team_a_difficulty));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </th>\r\n            <th>");
#nullable restore
#line 66 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fixtures_list[0].kickoff_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 70 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                            Write(Html.DisplayNameFor(model => model.fixtures_list[0].predicted_winner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                PW\r\n            </th>\r\n            <th data-bs-trigger=\"hover focus\"\r\n                data-bs-toggle=\"popover\"\r\n                data-bs-placement=\"top\"\r\n                data-bs-content=\"");
#nullable restore
#line 77 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                            Write(Html.DisplayNameFor(model => model.fixtures_list[0].actual_winner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                class=\"text-center\">\r\n                AW\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 85 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
         foreach (var item in Model.fixtures_list)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 89 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
               Write(item.Event);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f26640", async() => {
#nullable restore
#line 90 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                                         Write(item.team_h_name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                    WriteLiteral(item.team_h);

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
            WriteLiteral(" (");
#nullable restore
#line 90 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                                                                Write(item.team_h_difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                <td>");
#nullable restore
#line 91 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
               Write(item.team_h_score);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 91 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                    Write(item.team_a_score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f30354", async() => {
#nullable restore
#line 92 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                                         Write(item.team_a_name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                    WriteLiteral(item.team_a);

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
            WriteLiteral(" (");
#nullable restore
#line 92 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                                                                Write(item.team_a_difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
               Write(item.kickoff_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 94 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                   Write(item.predicted_winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 95 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                   Write(item.actual_winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52ef92d5844bac0f8583e6328e0b4aaaf67d76f34466", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
                                                                       WriteLiteral(item.id);

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
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 120 "C:\Users\Dennis Nijs\Desktop\Probeersels\FPL WebApp\FantasyPremierLeague\FantasyPremierLeague\Views\Fixture\Index.cshtml"
              
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FantasyPremierLeague.ViewModels.FixtureListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
