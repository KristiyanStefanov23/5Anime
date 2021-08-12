#pragma checksum "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd63ecdb52b3ccb63429278fbeaaf422e26a08ff"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd63ecdb52b3ccb63429278fbeaaf422e26a08ff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1643c3f9af4fa1b76bf57341b6b46813495985c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeyValuePair<List<Anime>, List<Episode>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-white-50\">Recently Added:</h2>\r\n<div class=\"card-holder mb-4\">\r\n    <div class=\"row card-holder-category\">\r\n");
#nullable restore
#line 10 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
         foreach (var episode in Model.Value)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 324, "\"", 340, 1);
#nullable restore
#line 12 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 329, episode.Id, 329, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 341, "\"", 443, 7);
            WriteAttributeValue("", 351, "location.href=\'", 351, 15, true);
#nullable restore
#line 12 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 366, Url.Action("Watch", "Anime"), 366, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 395, "?episodeId=", 395, 11, true);
#nullable restore
#line 12 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 406, episode.Id, 406, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 417, "&animeId=", 417, 9, true);
#nullable restore
#line 12 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 426, episode.AnimeId, 426, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 442, "\'", 442, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white-50 col-2 text-center\">\r\n                <img style=\"width: 100%\"");
            BeginWriteAttribute("src", " src=\"", 527, "\"", 610, 1);
#nullable restore
#line 13 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 533, Model.Key.Where(x => x.Id == episode.AnimeId).FirstOrDefault().CoverImageUrl, 533, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"text-break cut-text\">");
#nullable restore
#line 14 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                            Write(Model.Key.Where(x => x.Id == episode.AnimeId).FirstOrDefault().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>\r\n                    Episode\r\n");
#nullable restore
#line 17 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                     if (episode.EpisodeNumber <= 9)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>0</span>");
#nullable restore
#line 18 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 18 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                     Write(episode.EpisodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<h2 class=\"text-white-50\">Popular:</h2>\r\n<div class=\"card-holder\">\r\n    <div class=\"row card-holder-category\">\r\n");
#nullable restore
#line 28 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
         foreach (var anime in Model.Key)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1180, "\"", 1194, 1);
#nullable restore
#line 30 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1185, anime.Id, 1185, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1195, "\"", 1263, 5);
            WriteAttributeValue("", 1205, "location.href=\'", 1205, 15, true);
#nullable restore
#line 30 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1220, Url.Action("Anime", "Anime"), 1220, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1249, "?id=", 1249, 4, true);
#nullable restore
#line 30 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1253, anime.Id, 1253, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1262, "\'", 1262, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white-50 col-2 text-center\">\r\n                <img style=\"width: 100%\"");
            BeginWriteAttribute("src", " src=\"", 1347, "\"", 1373, 1);
#nullable restore
#line 31 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
WriteAttributeValue("", 1353, anime.CoverImageUrl, 1353, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"text-break cut-text\">");
#nullable restore
#line 32 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                                            Write(anime.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 33 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
                Write(anime.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 35 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
