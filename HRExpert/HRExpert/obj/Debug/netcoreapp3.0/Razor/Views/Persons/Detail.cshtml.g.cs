#pragma checksum "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fc022790dbb561086a7e20e33aa8836fde831ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_Detail), @"mvc.1.0.view", @"/Views/Persons/Detail.cshtml")]
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
#line 1 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
using HRExpert.Models.Persoane;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc022790dbb561086a7e20e33aa8836fde831ef", @"/Views/Persons/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fef6343a8a472cef69eebc56078818cdd31eec", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRExpert.Models.Persoane.PersonDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"page-header clearfix detailHeading\">\r\n        \r\n    </div>\r\n</div>\r\n\r\n<div class=\"jumbotron\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <p id=\"Marca\"><b>Marca: </b> ");
#nullable restore
#line 13 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                    Write(Model.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p id=\"Nume\"><b>Nume: </b> ");
#nullable restore
#line 14 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                  Write(Model.Nume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p id=\"Prenume\"><b>Prenume: </b> ");
#nullable restore
#line 15 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                        Write(Model.Prenume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p id=\"DataNastere\"><b>Data nasterii: </b> ");
#nullable restore
#line 16 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                                  Write(Model.DataNastere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p id=\"Sex\"><b>Sex: </b> ");
#nullable restore
#line 17 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                Write(Model.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p id=\"Nationalitate\"><b>Nationalitate: </b> ");
#nullable restore
#line 18 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                                    Write(Model.Nationalitate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p id=\"Email\"><b>Email: </b> ");
#nullable restore
#line 19 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <h4>Identitatea persoanei <button class=""button"">+</button> </h4>
        <table class=""table table-bordered table-hover table-condensed"">
            <thead>
                <tr>
                    <th>CNP</th>
                    <th>Serie</th>
                    <th>Numar</th>
                    <th>Emitent</th>
                    <th>Data Emitere</th>
                    <th>Data Expirare</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                 foreach(var personIdentity in @Model.PersonIdentity)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                   Write(personIdentity.CNP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                   Write(personIdentity.Numar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                   Write(personIdentity.Serie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                   Write(personIdentity.Emitent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                   Write(personIdentity.DataEmitere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                   Write(personIdentity.DataExpirare);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <h4>Adresa persoanei <button class=""button"">+</button></h4>
        <table class=""table table-bordered table-hover table-condensed"">
            <thead>
                <tr>
                    <th>Strada</th>
                    <th>Numar</th>
                    <th>Bloc</th>
                    <th>Etaj</th>
                    <th>Apartament</th>
                    <th>Localitate</th>
                    <th>Judet</th>
                    <th>Data de inceput</th>
                    <th>Data de sfarsit</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 73 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                 foreach (var personAddress in @Model.PersonAddress)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Strada);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 80 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Numar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 83 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Bloc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Etaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Apartament);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Localitate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.Judet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 98 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.DataInceput);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 101 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
                       Write(personAddress.DataSfarsit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 104 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\Detail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRExpert.Models.Persoane.PersonDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
