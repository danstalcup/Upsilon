#pragma checksum "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6882f667eed6de82e6f35b230a893ad702c911e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Test.cshtml", typeof(AspNetCore.Views_Home_Test))]
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
#line 1 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\_ViewImports.cshtml"
using Upsilon;

#line default
#line hidden
#line 2 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\_ViewImports.cshtml"
using Upsilon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6882f667eed6de82e6f35b230a893ad702c911e8", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafcc812dc2842c1c75c192fbb9f66b0e1ddcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upsilon.Models.ProfessionsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "View Test Data";

#line default
#line hidden
            BeginContext(96, 74, true);
            WriteLiteral("\r\n<h1>View Test Data</h1>\r\n\r\n<div>\r\n    <h2>Professions</h2>\r\n    <hr />\r\n");
            EndContext();
#line 12 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
     foreach (var profession in Model.Professions)
    {                    

#line default
#line hidden
            BeginContext(249, 12, true);
            WriteLiteral("        <h3>");
            EndContext();
            BeginContext(262, 15, false);
#line 14 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
       Write(profession.Name);

#line default
#line hidden
            EndContext();
            BeginContext(277, 180, true);
            WriteLiteral("</h3>                \r\n        <table class=\"table\">                        \r\n                <tr>\r\n                    <th>Prerequisites</th>\r\n                    <td colspan=\"4\">");
            EndContext();
#line 18 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                                     foreach (var requirement in profession.Requirements)
                                    {

#line default
#line hidden
            BeginContext(551, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(598, 29, false);
#line 20 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                                         Write(requirement.ProfessionLevelId);

#line default
#line hidden
            EndContext();
            BeginContext(627, 10, true);
            WriteLiteral(" </span>\r\n");
            EndContext();
#line 21 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                                    }

#line default
#line hidden
            BeginContext(676, 141, true);
            WriteLiteral("                    </td>                                                        \r\n                </tr>                                   \r\n");
            EndContext();
#line 24 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
             foreach (var level in profession.Levels)
            {

#line default
#line hidden
            BeginContext(887, 52, true);
            WriteLiteral("                <tr>\r\n                    <th>Level ");
            EndContext();
            BeginContext(940, 17, false);
#line 27 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                         Write(level.LevelNumber);

#line default
#line hidden
            EndContext();
            BeginContext(957, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(989, 10, false);
#line 28 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                   Write(level.Name);

#line default
#line hidden
            EndContext();
            BeginContext(999, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1031, 17, false);
#line 29 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                   Write(level.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1080, 13, false);
#line 30 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                   Write(level.Ability);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 79, true);
            WriteLiteral("</td>                                                \r\n                    <td>");
            EndContext();
            BeginContext(1173, 24, false);
#line 31 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
                   Write(level.ExperienceRequired);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 58, true);
            WriteLiteral(" EXP</td>                        \r\n                </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
            }

#line default
#line hidden
            BeginContext(1270, 26, true);
            WriteLiteral("        </table>        \r\n");
            EndContext();
#line 35 "C:\Users\Dan\Source\Repos\Upsilon\Upsilon\Views\Home\Test.cshtml"
    }  

#line default
#line hidden
            BeginContext(1305, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Upsilon.Models.ProfessionsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591