#pragma checksum "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d92f17f3c0cf87f31349587e2c8c8da94d4de86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FilmInf_Index), @"mvc.1.0.view", @"/Views/FilmInf/Index.cshtml")]
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
#line 1 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\_ViewImports.cshtml"
using Movie.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\_ViewImports.cshtml"
using Movie.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d92f17f3c0cf87f31349587e2c8c8da94d4de86", @"/Views/FilmInf/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a294e30bf6dc3dc65d903779c0647f03d842b6c", @"/Views/_ViewImports.cshtml")]
    public class Views_FilmInf_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie.Domain.Models.MovieA>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("random-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMovieFromApi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 style=\"height:50px\"></h1>\r\n\r\n\r\n\r\n\r\n<div class=\"wrapper\">\r\n    <div class=\"main_card\">\r\n        <div class=\"card_left\">\r\n            <div class=\"card_datails\">\r\n                <h1>");
#nullable restore
#line 12 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
               Write(Html.DisplayFor(item => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"card_cat\">\r\n                    <p class=\"PG\">");
#nullable restore
#line 14 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                             Write(Html.DisplayFor(item => item.Rated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"year\">");
#nullable restore
#line 15 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                               Write(Html.DisplayFor(item => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"genre\">");
#nullable restore
#line 16 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                                Write(Html.DisplayFor(item => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <p class=\"disc\">");
#nullable restore
#line 18 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                           Write(Html.DisplayFor(item => item.Plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 651, "\"", 658, 0);
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" data-toggle=""modal"" data-target=""#readmore"">Read More</a>
                <div class=""social-btn"">
                    <!-- WATCH TRAILER-->
                    <button class=""random-button"" data-toggle=""modal"" data-target=""#awards"">
                        <i class=""fas fa-play""></i> AWARDS
                    </button>
                    <!-- GET-->
                    <button class=""random-button"" data-toggle=""modal"" data-target=""#imdb"">
                        <i class=""fas fa-download""></i> IMDB RATINGS
                    </button>
                    <!--USERS RATINGS-->
                    <button class=""random-button"" data-toggle=""modal"" data-target=""#actors"">

                        <i class=""fas fa-thumbs-up""></i> ACTORS
                    </button>
                </div>
            </div>
        </div>
        <div class=""card_right"">
            <div class=""img_container"">
                <img");
            BeginWriteAttribute("src", " src=\"", 1620, "\"", 1663, 1);
#nullable restore
#line 39 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
WriteAttributeValue("", 1626, Html.DisplayFor(item => item.Poster), 1626, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1664, "\"", 1670, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"d-flex justify-content-center\">\r\n    <div class=\"w-50 p-1\">\r\n");
#nullable restore
#line 46 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
         if (Model.Added == false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d92f17f3c0cf87f31349587e2c8c8da94d4de867928", async() => {
                WriteLiteral("Add this movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                   WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                         WriteLiteral(Model.Plot);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["description"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-description", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["description"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                   WriteLiteral(Model.Genre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-genre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                   WriteLiteral(Model.Poster);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["image"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-image", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["image"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""awards"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Awards</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>");
#nullable restore
#line 67 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
               Write(Html.DisplayFor(item => item.Awards));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""imdb"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Imdb Ratings</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>Imdb rating: ");
#nullable restore
#line 86 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                            Write(Html.DisplayFor(item => item.imdbRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("/10</h5>\r\n                <h5>Total Votes: ");
#nullable restore
#line 87 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                            Write(Html.DisplayFor(item => item.imdbVotes));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""readmore"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Read more</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>Runtime: ");
#nullable restore
#line 106 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                        Write(Html.DisplayFor(item => item.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>Country: ");
#nullable restore
#line 107 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                        Write(Html.DisplayFor(item => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>Released: ");
#nullable restore
#line 108 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                         Write(Html.DisplayFor(item => item.Released));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>Director: ");
#nullable restore
#line 109 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                         Write(Html.DisplayFor(item => item.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>Writer: ");
#nullable restore
#line 110 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                       Write(Html.DisplayFor(item => item.Writer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>Language: ");
#nullable restore
#line 111 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                         Write(Html.DisplayFor(item => item.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""actors"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Read more</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>Actors: ");
#nullable restore
#line 130 "C:\Users\petko\Desktop\finki\IntegiraniSistemi\Movie.Web\Views\FilmInf\Index.cshtml"
                       Write(Html.DisplayFor(item => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie.Domain.Models.MovieA> Html { get; private set; }
    }
}
#pragma warning restore 1591
