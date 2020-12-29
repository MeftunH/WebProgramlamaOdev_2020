#pragma checksum "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe2c70c18891a56beac575cd4eeb9c8e2f276dd3"
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
#line 1 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2c70c18891a56beac575cd4eeb9c8e2f276dd3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebProje.Models.Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\r\n\r\n<div class=\"pokemons-container row d-flex\">\r\n");
#nullable restore
#line 12 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
     foreach (var pokemon in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 col-sm-6\">\r\n            <div class=\"card pokemon-card\" data-pokemonid=\"");
#nullable restore
#line 15 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
                                                      Write(pokemon.POKEMON_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"width: 18rem;\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 535, "\"", 565, 1);
#nullable restore
#line 16 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
WriteAttributeValue("", 541, pokemon.POKEMON_IMG_URL, 541, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
                                      Write(pokemon.POKEMON_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
                                    Write(pokemon.POKEMON_PRICE);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script>
    $(document).ready(function () {

        goToPokemonPage();
    })
   
    function goToPokemonPage() {
        $('.pokemon-card').click(function () {
            let pokemonid = $(this).attr('data-pokemonid');

            window.location.href = '");
#nullable restore
#line 36 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Home\Index.cshtml"
                               Write(Url.Action("Index","Pokemon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?id=\' + pokemonid;\r\n\r\n\r\n        });\r\n    }\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebProje.Models.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
