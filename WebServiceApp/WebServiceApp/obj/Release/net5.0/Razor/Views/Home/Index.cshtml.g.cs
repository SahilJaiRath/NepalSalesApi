#pragma checksum "C:\Users\LENOVO\source\repos\WebServiceApp\WebServiceApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af5c74f8a75d662417f78f17df9dcf616b827ac3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\WebServiceApp\WebServiceApp\Views\_ViewImports.cshtml"
using WebServiceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\WebServiceApp\WebServiceApp\Views\_ViewImports.cshtml"
using WebServiceApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5c74f8a75d662417f78f17df9dcf616b827ac3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2eeb2703c558d1f2855fc21c357664c380597b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\WebServiceApp\WebServiceApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] ="GenEinvoice";
  //  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"" style=""font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; font-size:20px"">
        <u> API to post  bill to CBMS <br /></u>
    </h1>
   
    <h1 style=""font-size:15px"">
        <br />
        ");
#nullable restore
#line 13 "C:\Users\LENOVO\source\repos\WebServiceApp\WebServiceApp\Views\Home\Index.cshtml"
   Write(ViewBag.Processed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
