#pragma checksum "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "316f4e36617b14cb103d89fd10179c7659c35fbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Search), @"mvc.1.0.view", @"/Views/Anime/Search.cshtml")]
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
#line 1 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
using FiveAnime.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316f4e36617b14cb103d89fd10179c7659c35fbc", @"/Views/Anime/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1643c3f9af4fa1b76bf57341b6b46813495985c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeyValuePair<string, List<Anime>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>Search > ");
#nullable restore
#line 5 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
       Write(Model.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"mt-5\">\r\n");
#nullable restore
#line 8 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
     foreach (var anime in Model.Value)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"display: flex; align-items: center\">\r\n            <img style=\"width: 5%\"");
            BeginWriteAttribute("src", " src=\"", 266, "\"", 292, 1);
#nullable restore
#line 11 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
WriteAttributeValue("", 272, anime.CoverImageUrl, 272, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"ml-3\">\r\n                <h5>");
#nullable restore
#line 13 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
               Write(anime.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>\r\n                    ");
#nullable restore
#line 15 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
               Write(anime.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 15 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
                             Write(anime.Season);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /\r\n");
#nullable restore
#line 16 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
                     if (anime.IsCompleted){

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Completed</span>");
#nullable restore
#line 16 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
                                                                  }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Airing</span>");
#nullable restore
#line 16 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
                                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "D:\Programming\Softuni\C#-Web\FiveAnime\Views\Anime\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeyValuePair<string, List<Anime>>> Html { get; private set; }
    }
}
#pragma warning restore 1591