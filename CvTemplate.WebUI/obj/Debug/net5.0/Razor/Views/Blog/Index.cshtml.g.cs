#pragma checksum "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3a0bf6e646736affe613b65cc9597c03175c76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3a0bf6e646736affe613b65cc9597c03175c76", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8822b4fee41249296ce611d78dddeb1f1f6af3dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<BlogPost>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PostsBody", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- BLOG -->
<div style=""opacity:1; display:block;"" role=""tabpanel"" class=""tab-pane fade"" id=""blog"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">BLOG</h5>

        <!-- Blog -->
        <section class=""blog blog-page padding-20 padding-top-50 padding-bottom-50 "">

            <div id=""dynamic-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d3a0bf6e646736affe613b65cc9597c03175c764743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        function goPage (pageIndex, pageSize){\r\n\r\n            $.ajax({\r\n                url: `");
#nullable restore
#line 28 "D:\Coding\ASP-NetCore\Web-CV\CvTemplate.WebUI\Views\Blog\Index.cshtml"
                 Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?pageIndex=${pageIndex}&pageSize=${pageSize}`,
                method:'GET',
                success:function(response){
                    $('#dynamic-content').html(response);
                    location.hash = '#dynamic-content';
                     location.hash = '';
                },
                error: function (response) {
                    console.log(response)
                }
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<BlogPost>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
