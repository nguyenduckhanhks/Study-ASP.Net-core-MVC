#pragma checksum "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeeb07f09a87c87f6cc0c839cd0912e34837f369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListReponses), @"mvc.1.0.view", @"/Views/Home/ListReponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListReponses.cshtml", typeof(AspNetCore.Views_Home_ListReponses))]
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
#line 1 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeeb07f09a87c87f6cc0c839cd0912e34837f369", @"/Views/Home/ListReponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListReponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.GuestReponse>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(84, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(111, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeeb07f09a87c87f6cc0c839cd0912e34837f3693625", async() => {
                BeginContext(117, 94, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ListReponses</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(218, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(220, 451, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeeb07f09a87c87f6cc0c839cd0912e34837f3694907", async() => {
                BeginContext(226, 218, true);
                WriteLiteral("\r\n    <p>This is List:</p>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <td>Name</td>\r\n                <td>Email</td>\r\n                <td>Phone</td>\r\n            </tr>\r\n        </thead>\r\n        \r\n");
                EndContext();
#line 23 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml"
         foreach(GuestReponse r in Model)
        {

#line default
#line hidden
                BeginContext(498, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(537, 6, false);
#line 26 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml"
               Write(r.Name);

#line default
#line hidden
                EndContext();
                BeginContext(543, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(571, 7, false);
#line 27 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml"
               Write(r.Email);

#line default
#line hidden
                EndContext();
                BeginContext(578, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(606, 7, false);
#line 28 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml"
               Write(r.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(613, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 30 "C:\Users\NGUYEN DUC KHANH\Desktop\ASP.NetMVC\WebApplication2\Views\Home\ListReponses.cshtml"
        }

#line default
#line hidden
                BeginContext(650, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(671, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.GuestReponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591