#pragma checksum "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8302875d689291a79f230259da1b0393f87a8b2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8302875d689291a79f230259da1b0393f87a8b2a", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 5 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 251, "\"", 288, 2);
            WriteAttributeValue("", 258, "/Blog/BlogReadAll/", 258, 18, true);
#nullable restore
#line 9 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 276, item.BlogID, 276, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 316, "\"", 337, 1);
#nullable restore
#line 10 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 322, item.BlogImage, 322, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 369, "\"", 375, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 556, 2);
            WriteAttributeValue("", 526, "/Blog/BlogReadAll/", 526, 18, true);
#nullable restore
#line 16 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 544, item.BlogID, 544, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 17 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                         if (item.BlogContent != null && item.BlogContent.Length > 50)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                       Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                                                                              
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                       Write(item.BlogContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ...\r\n                                    </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 30 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591