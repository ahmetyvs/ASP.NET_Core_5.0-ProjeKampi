#pragma checksum "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "825157f229b92eb402989bd00f560fa846bad7c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"825157f229b92eb402989bd00f560fa846bad7c2", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "825157f229b92eb402989bd00f560fa846bad7c23409", async() => {
                WriteLiteral(@"

    <!--//banner-->
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
");
#nullable restore
#line 15 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""blog-grid-top"">
                            <div class=""b-grid-top"">
                                <div class=""blog_info_left_grid"">
                                    <a href=""single.html"">
                                        <img src=""/CoreBlogTema/images/b1.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 814, "\"", 820, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-info-middle"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 28 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                                                Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </a>
                                        </li>
                                        <li class=""mx-2"">
                                            <a href=""#"">
                                                <i class=""far fa-thumbs-up""></i> 201 Beğeni
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-comment""></i> 0 Yorum
                                            </a>
                                        </li>

                                    </ul>
                                </div>
                            </div>

                            <h3>
                                <a href=""single.html"">");
#nullable restore
#line 47 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n                            </h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 50 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                           Write(item.BlogContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                            <a href=\"/Blog/Index\" class=\"btn btn-primary read-m\">Blog Listesi</a>\r\n                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
#nullable restore
#line 55 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlog", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 57 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>

                <!--//left-->
                <!--right-->
                <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                    <div class=""right-blog-info text-left"">
                        
                        <h4>Mail Bültenine Abone Olun</h4>
                        ");
#nullable restore
#line 67 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 69 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 71 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                        <div class=""single-gd my-5 tech-btm"">
                            <h4>Our Progress</h4>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div");
                WriteLiteral(@">
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                        </div>
                        <div class=""single-gd tech-btm"">
                            <h4>Son Eklenen Post</h4>
                            <div class=""blog-grids"">
                                <div class=""blog-grid-left"">
                                    <a href=""single.html"">
                         ");
                WriteLiteral("               <img src=\"images/b1.jpg\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 5340, "\"", 5346, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-grid-right"">

                                    <h5>
                                        <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                    </h5>
                                </div>
                                <div class=""clearfix""> </div>
                            </div>
                        </div>
                    </div>

                </aside>
                <!--//right-->
            </div>
        </div>
    </section>




");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
