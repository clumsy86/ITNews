#pragma checksum "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceca1c8177fbf901c9088b112c4f92d276536e18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Index.cshtml", typeof(AspNetCore.Views_Main_Index))]
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
#line 1 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\_ViewImports.cshtml"
using ITNews.Web1;

#line default
#line hidden
#line 2 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\_ViewImports.cshtml"
using ITNews.Web1.Models;

#line default
#line hidden
#line 4 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceca1c8177fbf901c9088b112c4f92d276536e18", @"/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d90833e3ee30de260cede0618b765f0fc8158c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITNews.Web1.Models.MainPostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 153, true);
            WriteLiteral("\r\n<br/>\r\n<br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 col-md-offset-9\">\r\n            <div class=\"search-posts\">\r\n");
            EndContext();
#line 13 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                 using (Html.BeginForm("Search", "Main", FormMethod.Post))
                {
                    

#line default
#line hidden
            BeginContext(370, 61, false);
#line 15 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
               Write(Html.TextBox("search", "", new { placeholder = "Search..." }));

#line default
#line hidden
            EndContext();
#line 15 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                                                                  
                }

#line default
#line hidden
            BeginContext(452, 322, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <div class=""row align-items-center"">
                <div class=""col-12 col-md-3"">
                    <h2>Tags</h2>
                    <br />
                    <div class=""tags"">
                        ");
            EndContext();
            BeginContext(775, 35, false);
#line 27 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                   Write(await Component.InvokeAsync("Tags"));

#line default
#line hidden
            EndContext();
            BeginContext(810, 212, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-12 col-md-6\">\r\n                    <h2>New posts</h2>\r\n                    <br />\r\n                    <!-- Blog Content -->\r\n");
            EndContext();
#line 34 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1095, 169, true);
            WriteLiteral("                        <div class=\"single-blog-content\">\r\n                            <div class=\"post-title align-self-center\">\r\n                                <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1264, "\"", 1293, 2);
            WriteAttributeValue("", 1271, "/Main/Details/", 1271, 14, true);
#line 38 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
WriteAttributeValue("", 1285, item.Id, 1285, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 23, true);
            WriteLiteral(" class=\"post-headline\">");
            EndContext();
            BeginContext(1318, 10, false);
#line 38 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                                                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 78, true);
            WriteLiteral("</a></h3>\r\n                            </div>\r\n                            <p>");
            EndContext();
            BeginContext(1407, 21, false);
#line 40 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                          Write(item.ShortDiscription);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 59, true);
            WriteLiteral("</p>\r\n                            <div class=\"post-meta\">\r\n");
            EndContext();
#line 42 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                 if (string.IsNullOrEmpty(item.FullName.LastName) || string.IsNullOrEmpty(item.FullName.FirstName))

                                {

#line default
#line hidden
            BeginContext(1657, 48, true);
            WriteLiteral("                                    <p>By <span>");
            EndContext();
            BeginContext(1706, 18, false);
#line 45 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                           Write(item.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1724, 14, true);
            WriteLiteral("</span> </p>\r\n");
            EndContext();
#line 46 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1846, 48, true);
            WriteLiteral("                                    <p>By <span>");
            EndContext();
            BeginContext(1895, 23, false);
#line 49 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                           Write(item.FullName.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1920, 22, false);
#line 49 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                                                    Write(item.FullName.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1942, 14, true);
            WriteLiteral("</span> </p>\r\n");
            EndContext();
#line 50 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1991, 89, true);
            WriteLiteral("\r\n                                <span class=\"post-category\"><strong>Category:</strong> ");
            EndContext();
            BeginContext(2081, 18, false);
#line 52 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                                                                  Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2099, 129, true);
            WriteLiteral("</span>\r\n                                <div class=\"post-date\">\r\n                                    <strong>Created:</strong>  ");
            EndContext();
            BeginContext(2229, 32, false);
#line 54 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                                          Write(item.Created.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2261, 168, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"post-rating\">\r\n                                    <span><strong>Rating:</strong> ");
            EndContext();
            BeginContext(2430, 11, false);
#line 57 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                                                              Write(item.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(2441, 84, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
            EndContext();
            BeginContext(2526, 18, false);
#line 59 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                              Write(item.CommentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(2544, 81, true);
            WriteLiteral(" comments</p>\r\n                            </div>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2625, "\"", 2654, 2);
            WriteAttributeValue("", 2632, "/Main/Details/", 2632, 14, true);
#line 61 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
WriteAttributeValue("", 2646, item.Id, 2646, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2655, 120, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm active\" role=\"button\" aria-pressed=\"true\">Read more</a>\r\n                        </div>\r\n");
            EndContext();
#line 63 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2798, 213, true);
            WriteLiteral("                </div>\r\n                \r\n                <h2>5 The most popular posts</h2>\r\n                <div class=\"col-12 col-md-3\">\r\n                    <div class=\"popular-posts\">\r\n                        ");
            EndContext();
            BeginContext(3012, 43, false);
#line 69 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Index.cshtml"
                   Write(await Component.InvokeAsync("PopularPosts"));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 122, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ITNews.Web1.Models.MainPostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591