#pragma checksum "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b97366cd75e4635c2ccdc8a764ad0c53a0dd7a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Authorize), @"mvc.1.0.view", @"/Views/Shared/Authorize.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Authorize.cshtml", typeof(AspNetCore.Views_Shared_Authorize))]
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
#line 1 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
using AspNet.Security.OpenIdConnect.Primitives;

#line default
#line hidden
#line 2 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
using Kramerica.BankID.OIDCServer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b97366cd75e4635c2ccdc8a764ad0c53a0dd7a8", @"/Views/Shared/Authorize.cshtml")]
    public class Views_Shared_Authorize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<OpenIdConnectRequest, Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(134, 115, true);
            WriteLiteral("\n<div class=\"jumbotron\">\n    <!-- <h1>Authorization</h1>\n\n    <p class=\"lead text-left\">Do you wanna grant <strong>");
            EndContext();
            BeginContext(250, 23, false);
#line 9 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
                                                    Write(Model.Item2.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(273, 58, true);
            WriteLiteral("</strong> an access to your resources? (scopes requested: ");
            EndContext();
            BeginContext(332, 17, false);
#line 9 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
                                                                                                                                      Write(Model.Item1.Scope);

#line default
#line hidden
            EndContext();
            BeginContext(349, 103, true);
            WriteLiteral(")</p> -->\n\n    <form id=\"authorize\" enctype=\"application/x-www-form-urlencoded\" method=\"post\">\n        ");
            EndContext();
            BeginContext(453, 23, false);
#line 12 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(476, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 14 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
         foreach (var parameter in Model.Item1.GetParameters()) {

#line default
#line hidden
            BeginContext(544, 32, true);
            WriteLiteral("            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 576, "\"", 597, 1);
#line 15 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
WriteAttributeValue("", 583, parameter.Key, 583, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 598, "\"", 622, 1);
#line 15 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
WriteAttributeValue("", 606, parameter.Value, 606, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(623, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 16 "C:\source\Kramerica.BankID\Kramerica.BankID.OIDCServer\Views\Shared\Authorize.cshtml"
        }

#line default
#line hidden
            BeginContext(637, 207, true);
            WriteLiteral("\n        <input class=\"btn btn-lg btn-success\" name=\"submit.Accept\" type=\"submit\" value=\"Yes\" />\n        <input class=\"btn btn-lg btn-danger\" name=\"submit.Deny\" type=\"submit\" value=\"No\" />\n    </form>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<OpenIdConnectRequest, Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
