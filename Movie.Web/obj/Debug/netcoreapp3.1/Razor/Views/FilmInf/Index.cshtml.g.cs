#pragma checksum "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f10cbf282985eab45cd4fb46fc742b3d052ba56a"
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
#line 1 "D:\IS PROEKT\Movie.Web\Views\_ViewImports.cshtml"
using Movie.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IS PROEKT\Movie.Web\Views\_ViewImports.cshtml"
using Movie.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10cbf282985eab45cd4fb46fc742b3d052ba56a", @"/Views/FilmInf/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a294e30bf6dc3dc65d903779c0647f03d842b6c", @"/Views/_ViewImports.cshtml")]
    public class Views_FilmInf_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie.Domain.Models.MovieA>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 style=""height:50px""></h1>

    <div>
        <div class=""card"" style=""background-color: ghostwhite"">
            <h2 style=""text-align: center"">
            </h2>
            <div class=""row"">
                <div class=""col-md-4"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 305, "\"", 348, 1);
#nullable restore
#line 11 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
WriteAttributeValue("", 311, Html.DisplayFor(item => item.Poster), 311, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div>\r\n                        <h1>");
#nullable restore
#line 15 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                       Write(Html.DisplayFor(item => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h5>Runtime:");
#nullable restore
#line 16 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                               Write(Html.DisplayFor(item => item.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Country: ");
#nullable restore
#line 17 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                                Write(Html.DisplayFor(item => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Released: ");
#nullable restore
#line 18 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                                 Write(Html.DisplayFor(item => item.Released));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Rated: ");
#nullable restore
#line 19 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                              Write(Html.DisplayFor(item => item.Rated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Genre: ");
#nullable restore
#line 20 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                              Write(Html.DisplayFor(item => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Director: ");
#nullable restore
#line 21 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                                 Write(Html.DisplayFor(item => item.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5> \r\n                        <h5>Writer: ");
#nullable restore
#line 22 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                               Write(Html.DisplayFor(item => item.Writer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Actors: ");
#nullable restore
#line 23 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                               Write(Html.DisplayFor(item => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Language: ");
#nullable restore
#line 24 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                                 Write(Html.DisplayFor(item => item.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>");
#nullable restore
#line 25 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                       Write(Html.DisplayFor(item => item.Awards));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>Plot: ");
#nullable restore
#line 26 "D:\IS PROEKT\Movie.Web\Views\FilmInf\Index.cshtml"
                            Write(Html.DisplayFor(item => item.Plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
