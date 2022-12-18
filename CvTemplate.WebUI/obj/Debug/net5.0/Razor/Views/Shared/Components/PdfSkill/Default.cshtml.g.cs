#pragma checksum "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f467aeb0e65594dde197135f5473f7ed9387620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PdfSkill_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PdfSkill/Default.cshtml")]
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
#line 1 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Cv.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Cv.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f467aeb0e65594dde197135f5473f7ed9387620", @"/Views/Shared/Components/PdfSkill/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8822b4fee41249296ce611d78dddeb1f1f6af3dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PdfSkill_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResumeSkill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
     if (item.View == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""
              display: table-cell;
              vertical-align: top;
              padding-right: 10px;
            "">
            <span style=""
                font-size: 13px;
                font-weight: bold;
                display: inline-block;
                width: 130px;
              "">");
#nullable restore
#line 18 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
           Write(item.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
        <div style=""margin-bottom: 20px"">
            <div style=""
                box-shadow: none;
                border-radius: 0px;
                margin-bottom: 30px;
                position: relative;
                border: none;
                margin-top: 0px;
              "">
                <div style=""margin-right: -15px; margin-left: -15px"">
                    <div style=""width: 33.33333333%; float: left"">");
#nullable restore
#line 30 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div style=\"width: 66.66666667%; float: left; font-style:italic\">\r\n                        ");
#nullable restore
#line 32 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
                   Write(item.Description.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
    }
    else if (item.View != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"ethical\">\r\n            <h6>");
#nullable restore
#line 41 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
           Write(item.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <a href=\"#.\">");
#nullable restore
#line 42 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n");
#nullable restore
#line 44 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Shared\Components\PdfSkill\Default.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResumeSkill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
