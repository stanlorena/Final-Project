#pragma checksum "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cacec223818fbfffac8e2e245d5292d899e1236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_Index), @"mvc.1.0.view", @"/Views/Persons/Index.cshtml")]
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
#line 1 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\_ViewImports.cshtml"
using HRExpert;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\_ViewImports.cshtml"
using HRExpert.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
using HRExpert.Models.Persoane;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cacec223818fbfffac8e2e245d5292d899e1236", @"/Views/Persons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fef6343a8a472cef69eebc56078818cdd31eec", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRExpert.Models.Persoane.PersonIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Persons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportToExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("marca"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div id=\"persons\">\r\n    <h3>Persoane ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cacec223818fbfffac8e2e245d5292d899e12365609", async() => {
                WriteLiteral("+");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cacec223818fbfffac8e2e245d5292d899e12367128", async() => {
                WriteLiteral("<i class=\"fa fa-arrow-circle-down\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h3>
    <div id=""personsTable"">
        <table class=""table table-condensed"" id=""personIndexTable"">
            <thead>
                <tr>
                    <th>Marca</th>
                    <th>Nume</th>
                    <th>Prenume</th>
                    <th>Data nasterii</th>
                    <th>Sex</th>
                    <th>Nationalitate</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                 foreach(var person in @Model.Persons)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"personRow\">\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 955, "\"", 963, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cacec223818fbfffac8e2e245d5292d899e12369683", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                       Write(person.Marca);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                                                                                       WriteLiteral(person.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1203, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                            Write(person.Nume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1255, "\"", 1263, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                            Write(person.Prenume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1310, "\"", 1318, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                            Write(person.DataNastere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1369, "\"", 1377, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                            Write(person.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1420, "\"", 1428, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                            Write(person.Nationalitate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1481, "\"", 1489, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                            Write(person.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRExpert.Models.Persoane.PersonIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
