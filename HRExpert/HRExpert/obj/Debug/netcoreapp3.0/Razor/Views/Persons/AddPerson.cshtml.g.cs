#pragma checksum "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b16d047fcca94434ecce6a13c93d4ebe7fac88e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_AddPerson), @"mvc.1.0.view", @"/Views/Persons/AddPerson.cshtml")]
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
#line 1 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
using HRExpert.Models.Persoane;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b16d047fcca94434ecce6a13c93d4ebe7fac88e", @"/Views/Persons/AddPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fef6343a8a472cef69eebc56078818cdd31eec", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_AddPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRExpert.Models.Persoane.AddPersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"header clearfix detailHeading\">\r\n        <h2 class=\"text-muted text-center\">Adaugare persoana</h2>\r\n    </div>\r\n    <div class=\"jumbotron\">\r\n        <div class=\"col-md-9\">\r\n");
#nullable restore
#line 16 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
             using (Html.BeginForm("AddPersonAction", "Persons", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    Marca\r\n                    ");
#nullable restore
#line 20 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
               Write(Html.TextBoxFor(a => a.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    Nume\r\n                    ");
#nullable restore
#line 24 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
               Write(Html.TextBoxFor(a => a.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    Prenume\r\n                    ");
#nullable restore
#line 28 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
               Write(Html.TextBoxFor(a => a.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    Data nastere\r\n                    ");
#nullable restore
#line 32 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
               Write(Html.TextBoxFor(a => a.DataNastere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    Sex\r\n                    <div>\r\n                        ");
#nullable restore
#line 37 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
                   Write(Html.DropDownListFor(a => a.Sex, new SelectList(new List<Object>{
                           new { value = "F" , text = "F"  },
                           new { value = "M" , text = "M" }},
                           "value",
                           "text",
                           Model.Sex
                        )));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    Nationalitate\r\n                    <div>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
                   Write(Html.DropDownListFor(a => a.Nationalitate, new SelectList(new List<Object>{
                           new { value = "RO" , text = "RO"  } },
                           "value",
                           "text",
                           Model.Nationalitate
                        )));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    Email\r\n                    ");
#nullable restore
#line 59 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
               Write(Html.TextBoxFor(a => a.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <p></p>\r\n                    <button type=\"submit\">Adauga</button>\r\n                </div>\r\n");
#nullable restore
#line 65 "C:\Users\Lore\Desktop\Aplicatie licenta\HRExpert\HRExpert\Views\Persons\AddPerson.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRExpert.Models.Persoane.AddPersonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591