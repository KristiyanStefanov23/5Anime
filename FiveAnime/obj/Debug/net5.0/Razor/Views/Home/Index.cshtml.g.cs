#pragma checksum "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b86b6bec398c8f284ae4c8f517ae7a9ad250ea7"
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
#line 1 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
using FiveAnime.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b86b6bec398c8f284ae4c8f517ae7a9ad250ea7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1643c3f9af4fa1b76bf57341b6b46813495985c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeyValuePair<List<Anime>, List<Episode>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    html {
        scroll-behavior: smooth;
    }

    .explore-page-wrapper {
        display: flex;
    }

    .anime-explore-page {
        flex-wrap: nowrap;
        overflow: hidden;
        overflow-x: scroll;
        width: 80%
    }

    .card-holder {
        display: flex;
    }

    .anime-explore-page::-webkit-scrollbar {
        display: none;
    }

    .explore-page-wrapper > button[type=""button""] {
        background: none;
        outline: none;
        border: none;
        color: #fff;
        font-weight: bold;
        font-size: 2rem;
    }

    .anime {
        cursor: pointer;
    }
</style>

<h2 class=""text-white-50 mb-4"">Recently Added:</h2>
<div class=""explore-page-wrapper"">
    <button id=""slideLeft1"" type=""button""><i class=""fa fa-chevron-left""></i></button>
    <div id=""explore-1"" class=""row card-holder-category anime-explore-page ml-2 mr-2""s>
");
#nullable restore
#line 50 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
         foreach (var episode in Model.Value.Take(5))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1144, "\"", 1160, 1);
#nullable restore
#line 52 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1149, episode.Id, 1149, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white-50 col-2 text-center\">\r\n                <img class=\"anime\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1238, "\"", 1340, 7);
            WriteAttributeValue("", 1248, "location.href=\'", 1248, 15, true);
#nullable restore
#line 53 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1263, Url.Action("Watch", "Anime"), 1263, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1292, "?episodeId=", 1292, 11, true);
#nullable restore
#line 53 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1303, episode.Id, 1303, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1314, "&animeId=", 1314, 9, true);
#nullable restore
#line 53 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1323, episode.AnimeId, 1323, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1339, "\'", 1339, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%\"");
            BeginWriteAttribute("src", " src=\"", 1361, "\"", 1444, 1);
#nullable restore
#line 53 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1367, Model.Key.Where(x => x.Id == episode.AnimeId).FirstOrDefault().CoverImageUrl, 1367, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"text-break cut-text\">");
#nullable restore
#line 54 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                            Write(Model.Key.Where(x => x.Id == episode.AnimeId).FirstOrDefault().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>\r\n                    Episode\r\n");
#nullable restore
#line 57 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                     if (episode.EpisodeNumber <= 9)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>0</span>");
#nullable restore
#line 58 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 58 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                     Write(episode.EpisodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 61 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <button id=""slideRight1"" type=""button""><i class=""fa fa-chevron-right""></i></button>
</div>

<h2 class=""text-white-50 mb-4"">Explore:</h2>
<div class=""explore-page-wrapper"">
    <button id=""slideLeft"" type=""button""><i class=""fa fa-chevron-left""></i></button>
    <div id=""explore-2"" class=""row card-holder-category anime-explore-page ml-2 mr-2"">
");
#nullable restore
#line 70 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
         foreach (var anime in Model.Key)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 2247, "\"", 2261, 1);
#nullable restore
#line 72 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 2252, anime.Id, 2252, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white-50 col-2 text-center anime\">\r\n                <img class=\"anime\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2345, "\"", 2413, 5);
            WriteAttributeValue("", 2355, "location.href=\'", 2355, 15, true);
#nullable restore
#line 73 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 2370, Url.Action("Anime", "Anime"), 2370, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2399, "?id=", 2399, 4, true);
#nullable restore
#line 73 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 2403, anime.Id, 2403, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2412, "\'", 2412, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%\"");
            BeginWriteAttribute("src", " src=\"", 2434, "\"", 2460, 1);
#nullable restore
#line 73 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 2440, anime.CoverImageUrl, 2440, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"text-break cut-text\">");
#nullable restore
#line 74 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                            Write(anime.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 75 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                Write(anime.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 77 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <button id=""slideRight"" type=""button""><i class=""fa fa-chevron-right""></i></button>
</div>

<script>
    'use strict'
    const buttonRight1 = document.getElementById('slideRight1');
    const buttonLeft1 = document.getElementById('slideLeft1');

    buttonRight1.onclick = function () {
        document.getElementById('explore-1').scrollLeft += 900;
    };
    buttonLeft1.onclick = function () {
        document.getElementById('explore-1').scrollLeft -= 900;
    };

    const buttonRight = document.getElementById('slideRight');
    const buttonLeft = document.getElementById('slideLeft');

    buttonLeft.onclick = function () {
        document.getElementById('explore-2').scrollLeft -= 900;
    };
    buttonRight.onclick = function () {
        document.getElementById('explore-2').scrollLeft += 900;
    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeyValuePair<List<Anime>, List<Episode>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
