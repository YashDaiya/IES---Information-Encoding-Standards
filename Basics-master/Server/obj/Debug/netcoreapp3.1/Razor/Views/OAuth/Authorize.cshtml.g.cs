#pragma checksum "C:\Users\DELL\source\repos\Basics-master\Server\Views\OAuth\Authorize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd6dfd01d153ef36dafbce24bd67d0cbe384eb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OAuth_Authorize), @"mvc.1.0.view", @"/Views/OAuth/Authorize.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd6dfd01d153ef36dafbce24bd67d0cbe384eb2", @"/Views/OAuth/Authorize.cshtml")]
    public class Views_OAuth_Authorize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\DELL\source\repos\Basics-master\Server\Views\OAuth\Authorize.cshtml"
  
    var url = $"/OAuth/Authorize{Model}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "C:\Users\DELL\source\repos\Basics-master\Server\Views\OAuth\Authorize.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<form");
            BeginWriteAttribute("action", " action=\"", 77, "\"", 90, 1);
#nullable restore
#line 10 "C:\Users\DELL\source\repos\Basics-master\Server\Views\OAuth\Authorize.cshtml"
WriteAttributeValue("", 86, url, 86, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\n    <input type=\"text\" name=\"username\"");
            BeginWriteAttribute("value", " value=\"", 145, "\"", 153, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"submit\" value=\"Submit\" />\n</form>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
