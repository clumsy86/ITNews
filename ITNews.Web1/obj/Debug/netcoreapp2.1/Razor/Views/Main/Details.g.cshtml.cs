#pragma checksum "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d051351de78a80d93f45bd38ba089d2bc59e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Details), @"mvc.1.0.view", @"/Views/Main/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Details.cshtml", typeof(AspNetCore.Views_Main_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20d051351de78a80d93f45bd38ba089d2bc59e02", @"/Views/Main/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d90833e3ee30de260cede0618b765f0fc8158c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITNews.Web1.Models.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/star-rating.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/star-rating.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/test.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(93, 37, false);
#line 7 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(130, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(137, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a20048eb16644918ef0be3b6cf3c242", async() => {
                BeginContext(143, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(149, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f97471766e540cdbe0b6b5864762458", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(217, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(228, 115, true);
            WriteLiteral("\r\n<div>\r\n\r\n    <hr />\r\n\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            <input type=\"hidden\" id=\"postId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 343, "\"", 360, 1);
#line 18 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
WriteAttributeValue("", 351, Model.Id, 351, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(361, 49, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"userId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 410, "\"", 433, 1);
#line 19 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
WriteAttributeValue("", 418, ViewBag.UserId, 418, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 48, true);
            WriteLiteral(" />\r\n        </dt>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(483, 44, false);
#line 23 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(527, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(571, 45, false);
#line 26 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(616, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(662, 23, false);
#line 30 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
       Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(685, 136, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div class=\"row\">\r\n        <div class=\" col-md-2\">\r\n\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n\r\n");
            EndContext();
#line 39 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
             if (Model.FullName.LastName == null || Model.FullName.FirstName == null)

            {

#line default
#line hidden
            BeginContext(925, 46, true);
            WriteLiteral("                <p><span><strong>Post created ");
            EndContext();
            BeginContext(972, 33, false);
#line 42 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                         Write(Model.Created.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1005, 44, true);
            WriteLiteral("</strong></span> </p> <p><span> <strong> By ");
            EndContext();
            BeginContext(1050, 19, false);
#line 42 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                                                                                       Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 23, true);
            WriteLiteral("</strong></span> </p>\r\n");
            EndContext();
#line 43 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1140, 46, true);
            WriteLiteral("                <p><span><strong>Post created ");
            EndContext();
            BeginContext(1187, 33, false);
#line 46 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                         Write(Model.Created.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1220, 44, true);
            WriteLiteral("</strong></span> </p> <p><span> <strong> By ");
            EndContext();
            BeginContext(1265, 24, false);
#line 46 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                                                                                       Write(Model.FullName.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1289, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1291, 23, false);
#line 46 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                                                                                                                 Write(Model.FullName.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 23, true);
            WriteLiteral(" </strong></span></p>\r\n");
            EndContext();
#line 47 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1352, 49, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1401, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce904f96a1b493e87ecbf9b1ac9c224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1444, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1450, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ee820f63246469ca16f4bc44e100aa1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1504, 225, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<br />\r\n<div>\r\n    <div class=\"container\">\r\n        <div class=\"raw\">\r\n            <div class=\"col-md-2\">\r\n                <div class=\"AmountRating\">\r\n                    <span id=\"ratingAmount\"> Amount rating: ");
            EndContext();
            BeginContext(1730, 12, false);
#line 64 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                       Write(Model.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 767, true);
            WriteLiteral(@"</span>
                </div>
            </div>
            <div class=""col-md-5"">
                <div class=""ratings"">
                    <input type=""radio"" name=""star"" class=""rating"" value=""1"" />
                    <input type=""radio"" name=""star"" class=""rating"" value=""2"" />
                    <input type=""radio"" name=""star"" class=""rating"" value=""3"" />
                    <input type=""radio"" name=""star"" class=""rating"" value=""4"" />
                    <input type=""radio"" name=""star"" class=""rating"" value=""5"" />
                </div>
            </div>

        </div>
    </div>
</div>
<script>
    $('.ratings').rating(function (vote, event) {
        $.ajax({
            url: '/main/rating',
            data: { vote: vote, postId:");
            EndContext();
            BeginContext(2510, 8, false);
#line 84 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                  Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2518, 138, true);
            WriteLiteral(" },\r\n            success: function () {\r\n                document.getElementById(\"ratingAmount\").innerHTML = \"Amount rating:\" + (parseInt(");
            EndContext();
            BeginContext(2657, 12, false);
#line 86 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                                                            Write(Model.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(2669, 741, true);
            WriteLiteral(@")+parseInt(vote)).toString();
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                if (XMLHttpRequest.status == 403) {
                    alert(""You voted yet"");
                    $('.ratings').hide();
                }
                if (XMLHttpRequest.status == 401) {
                    alert(""You shoud be auth"");
                    $('.ratings').hide();
                }

            }
        })
    })

</script>


<div class=""container"">
    <div class=""row"">
        <h3>Comments</h3>
        <div class=""col-md-2"" style=""padding-left:unset""><h5>Add your comment</h5></div>
        <div class=""col-md-6"">
            <input type=""hidden"" id=""userName""");
            EndContext();
            BeginWriteAttribute("value", " value=", 3410, "", 3434, 1);
#line 110 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
WriteAttributeValue("", 3417, ViewBag.Username, 3417, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3434, 773, true);
            WriteLiteral(@" />
            <textarea rows=""4"" cols=""50"" id=""messageInput""></textarea>
            <div>
                <input type=""button"" id=""sendButton"" value=""Add"" />
            </div>
        </div>
    </div>
    <br />
    <script>
        const like = (commentId, e) => {
            $.ajax({
                url: '/main/like?commentId=' + commentId,
                success: (data) => {
                    var likeButton = data.isLiked ? ""info"" : ""default"";
                    $(e.target.closest('.btn-sm')).attr('class', 'btn btn-' + likeButton + ' btn-sm');
                    $(e.target.closest('.btn-sm').querySelector('span')).text(data.likeAmount)
                }
            });

        }
    </script>
    <div class=""comments"">
        ");
            EndContext();
            BeginContext(4208, 87, false);
#line 132 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
   Write(await Component.InvokeAsync("Comments", new { id = Model.Id, userId = ViewBag.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(4295, 613, true);
            WriteLiteral(@"
    </div>

    <div id=""target""></div>

    <script id=""hidden-template"" type=""text/x-custom-template"">
        <div class=""container"">
            <div class=""col-md-8"">
                <div class=""panel panel-default"">
                    <div class=""panel-body"">
                        <section class=""post-heading"">
                            <div class=""row"">
                                <div class=""col-md-9"">
                                    <div class=""media"">
                                        <div class=""media-body"">
                                            <a href=""");
            EndContext();
            BeginContext(4909, 76, false);
#line 147 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                Write(Url.Action("ReadProfile", "Profile", new {profileId = Model.User.ProfileId}));

#line default
#line hidden
            EndContext();
            BeginContext(4985, 52, true);
            WriteLiteral("\" class=\"anchor-username\"><h6 class=\"media-heading\">");
            EndContext();
            BeginContext(5038, 19, false);
#line 147 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                                                                                                                                                                 Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5057, 62, true);
            WriteLiteral(" </h6></a>\r\n                                            <span>");
            EndContext();
            BeginContext(5120, 32, false);
#line 148 "D:\Наташин хлам\ASP.NET\ITNews\ITNews.Web1\Views\Main\Details.cshtml"
                                             Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5152, 1185, true);
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <section class=""post-body""><br /> <p id=""content"">comment</p></section>
                        <input type=""hidden"" id=""commentId"" value=""1"" />
                        <section class=""post-footer"" style=""margin:unset"">
                            <div class=""post-footer-option container"">
                                <ul class=""list-unstyled"">
                                    <li>
                                        <button type=""button"" id=""buttonId"" class=""btn btn-default btn-sm"">
                                            <span class=""glyphicon glyphicon-thumbs-up"" id=""count"">0</span>
                                        </button>
                                    </li>
                                </ul>
                            </div>
   ");
            WriteLiteral("                     </section>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </script>\r\n</div>\r\n\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6337, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31efdffa571c42c8a1ee6e61dd941d28", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6373, 29, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6402, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01961f5be11f410083e9adca7655f3cf", async() => {
                BeginContext(6424, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6440, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITNews.Web1.Models.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
