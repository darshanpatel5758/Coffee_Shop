#pragma checksum "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f54ec44245c6b64b8e16f5ebc02dd1a5c15990b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_FormResult), @"mvc.1.0.view", @"/Views/Registration/FormResult.cshtml")]
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
#line 1 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\_ViewImports.cshtml"
using Coffee_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\_ViewImports.cshtml"
using Coffee_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f54ec44245c6b64b8e16f5ebc02dd1a5c15990b", @"/Views/Registration/FormResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb473e7b031f6336ea044efdcd6df3251d9be0ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_FormResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coffee_Shop.Models.Registration.FormResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <ul>\r\n        <li class=\"list-group-item\">\r\n            <center> <h1><p>Welcome ");
#nullable restore
#line 8 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                               Write(Model.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                                            Write(Model.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></h1>\r\n            <br />\r\n            <br />\r\n            <p>First Name: ");
#nullable restore
#line 11 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                      Write(Model.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Last Name: ");
#nullable restore
#line 12 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                     Write(Model.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Email : ");
#nullable restore
#line 13 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Address : ");
#nullable restore
#line 14 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                    Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                                   Write(Model.Address2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>City : ");
#nullable restore
#line 15 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                 Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>ZipCode : ");
#nullable restore
#line 16 "D:\Grand Circus\Coffee_Shop\Coffee_Shop\Views\Registration\FormResult.cshtml"
                    Write(Model.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></center>\r\n\r\n        </li>\r\n    </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coffee_Shop.Models.Registration.FormResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
