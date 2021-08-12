#pragma checksum "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52b148b354a000f1c56fbe0fb941be0742431a1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Anime), @"mvc.1.0.view", @"/Views/Anime/Anime.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\_ViewImports.cshtml"
using FiveAnime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\_ViewImports.cshtml"
using FiveAnime.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
using FiveAnime.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b148b354a000f1c56fbe0fb941be0742431a1e", @"/Views/Anime/Anime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1643c3f9af4fa1b76bf57341b6b46813495985c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Anime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeyValuePair<Anime, List<Episode>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
  
    ViewData["Title"] = Model.Key.Title;
    int i = 1;
    var filterList = ViewBag.Filters;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    ul {
        list-style-type: none;
        padding: 0;
    }

    .text-light {
        color: rgba(255, 255, 255, 0.8) !important;
    }

    .episode-btn:hover {
        background: #2b2e30;
        cursor: pointer;
    }

    .episode-btn {
        width: 5%;
        padding: 7px;
        background: #221f1f;
        color: #747474;
    }

    .filters-row a {
        margin: 0 3%;
        color: #fff;
        font-weight: 600;
        font-size: 1.1rem;
    }

    .filters-row {
        width: 100%;
    }
</style>

<div class=""anime-showcase-page-wrapper row"">
    <div class=""col-3"">
        <img class=""w-100""");
            BeginWriteAttribute("src", " src=\"", 873, "\"", 903, 1);
#nullable restore
#line 48 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
WriteAttributeValue("", 879, Model.Key.CoverImageUrl, 879, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <ul>\r\n            <li class=\"text-white-50\">Type</li>\r\n            <li class=\"text-light\">");
#nullable restore
#line 51 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                              Write(Model.Key.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"text-white-50\">Studio</li>\r\n            <li class=\"text-light\">");
#nullable restore
#line 53 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                              Write(Model.Key.Studio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"text-white-50\">Release Date (JP)</li>\r\n            <li class=\"text-light\">");
#nullable restore
#line 55 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                              Write(Model.Key.Season);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 55 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                                                 Write(Model.Key.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"text-white-50\">Status</li>\r\n");
#nullable restore
#line 57 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
             if (Model.Key.IsCompleted)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"text-light\">Completed</li>\r\n");
#nullable restore
#line 60 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"text-light\">Currently Airing</li>\r\n");
#nullable restore
#line 64 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"text-white-50\">Language</li>\r\n");
#nullable restore
#line 66 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
             if (Model.Key.IsDubbed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"text-light\">Dubbed</li>\r\n");
#nullable restore
#line 69 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"text-light\">Subbed</li>\r\n");
#nullable restore
#line 73 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col\">\r\n        <h1 class=\"m-5\">");
#nullable restore
#line 77 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                   Write(Model.Key.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"filters-row\">\r\n");
#nullable restore
#line 79 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
             foreach (var filter in filterList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 2051, "\"", 2076, 2);
            WriteAttributeValue("", 2058, "Search/", 2058, 7, true);
#nullable restore
#line 81 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
WriteAttributeValue("", 2065, filter.Key, 2065, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                                        Write(filter.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 82 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <hr class=\"bg-white\" />\r\n        <p class=\"text-white-50\">");
#nullable restore
#line 85 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                            Write(Model.Key.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div>\r\n");
#nullable restore
#line 87 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
             if (!Model.Value.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 class=\"ml-4 text-white-50\">No episodes uploaded yet...</h5>\r\n");
#nullable restore
#line 90 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
            }
            else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                 foreach (var episode in Model.Value)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2502, "\"", 2601, 7);
            WriteAttributeValue("", 2512, "location.href=\'", 2512, 15, true);
#nullable restore
#line 94 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
WriteAttributeValue("", 2527, Url.Action("Watch", "Anime"), 2527, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2556, "?episodeId=", 2556, 11, true);
#nullable restore
#line 94 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
WriteAttributeValue("", 2567, episode.Id, 2567, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2578, "&animeId=", 2578, 9, true);
#nullable restore
#line 94 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
WriteAttributeValue("", 2587, Model.Key.Id, 2587, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2600, "\'", 2600, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"episode-btn badge badge-secondary\">\r\n");
#nullable restore
#line 95 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                         if (i <= 9)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>0</span><span>");
#nullable restore
#line 97 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 98 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 101 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 102 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 104 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Anime.cshtml"
                    i++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeyValuePair<Anime, List<Episode>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
