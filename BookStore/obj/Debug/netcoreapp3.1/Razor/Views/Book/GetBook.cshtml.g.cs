#pragma checksum "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03d3066da252ffabf38082e73b78d91fa98f528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e03d3066da252ffabf38082e73b78d91fa98f528", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc145331279199c6eb8696ac121602f8357ea34", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private global::AspNetCore.Views_Book_GetBook.__Generated__SimilarBooksViewComponentTagHelper __SimilarBooksViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Firstly.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("SimilarBooks"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Secondly.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Thirdly.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
  
    ViewData["Title"] = "Book detail" + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"

<div class=""container"">
    <h3 class=""display-4""> Book detail</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">

");
#nullable restore
#line 17 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 19 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 540, "\"", 572, 2);
#nullable restore
#line 19 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 548, i==0 ? "active" : "", 548, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 571, "", 572, 1, true);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 20 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 23 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 794, "\"", 853, 2);
#nullable restore
#line 25 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 802, i==0 ? "carousel-item active" : "carousel-item", 802, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 852, "", 853, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"Image\"");
            BeginWriteAttribute("src", " src=\"", 903, "\"", 930, 1);
#nullable restore
#line 26 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 909, Model.Gallery[i].URL, 909, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 931, "\"", 959, 1);
#nullable restore
#line 26 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 937, Model.Gallery[i].Name, 937, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 28 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>

    </div>
    <div class=""col-md-6"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h1>");
#nullable restore
#line 46 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"form-label label-primary\">By: </span>\r\n                    <span class=\"monospace\">");
#nullable restore
#line 52 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                                       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"=col-md-12\">\r\n                    <p class=\"description\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-4"">
                    <a class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                        Read Now
                    </a>
                </div>
            </div>
            <hr />
            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category-</span>");
#nullable restore
#line 73 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                                                                                      Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages-</span>");
#nullable restore
#line 74 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                                                                                         Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language-</span>");
#nullable restore
#line 75 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
                                                                                      Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>

    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <embed");
            BeginWriteAttribute("src", " src=\"", 3669, "\"", 3692, 1);
#nullable restore
#line 89 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 3675, Model.BookPdfUrl, 3675, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>

</div>
<hr />

<div class=""py-5 bg-light"">
    <div class=""container"">
        <h3 class=""h3"">Similar books</h3>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:similar-books", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e03d3066da252ffabf38082e73b78d91fa98f52813214", async() => {
            }
            );
            __SimilarBooksViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Book_GetBook.__Generated__SimilarBooksViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SimilarBooksViewComponentTagHelper);
#nullable restore
#line 104 "C:\Users\USER\Desktop\Project\BookStore\BookStore\Views\Book\GetBook.cshtml"
__SimilarBooksViewComponentTagHelper.count = 9;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("count", __SimilarBooksViewComponentTagHelper.count, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<hr/>\r\n\r\n\r\n<div class=\"py-5 bg-light\" id=\"Similar Books\">\r\n    <h3 class=\"h3\">Books by Amazing Authors</h3>\r\n    <div class=\"row\">\r\n");
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card mb-4 shadow-sm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e03d3066da252ffabf38082e73b78d91fa98f52814864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""card-body"">
                    <h3 class=""card-title"">book.Title</h3>
                    <p class=""card-text"">book.Description</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                        </div>
                        <small class=""text-muted"">Olaide</small>
                    </div>
                </div>
            </div>
        </div>

");
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card mb-4 shadow-sm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e03d3066da252ffabf38082e73b78d91fa98f52816712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""card-body"">
                    <h3 class=""card-title"">book.Title</h3>
                    <p class=""card-text"">book.Description</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                        </div>
                        <small class=""text-muted"">Nene</small>
                    </div>
                </div>
            </div>
        </div>

");
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card mb-4 shadow-sm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e03d3066da252ffabf38082e73b78d91fa98f52818558", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""card-body"">
                    <h3 class=""card-title"">book.Title</h3>
                    <p class=""card-text"">book.Description</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                        </div>
                        <small class=""text-muted"">Olaide</small>
                    </div>
                </div>
            </div>
        </div>


    </div>
</div>

<hr />

");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:similar-books")]
        public class __Generated__SimilarBooksViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__SimilarBooksViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 count { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("SimilarBooks", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("count"))
                {
                    args[nameof(count)] = count;
                }
                return args;
            }
        }
    }
}
#pragma warning restore 1591
