#pragma checksum "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\NewWeakness\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "668618fe8cc8fabe997a6f58017ad4f326a3d7e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewWeakness_Index), @"mvc.1.0.view", @"/Views/NewWeakness/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668618fe8cc8fabe997a6f58017ad4f326a3d7e5", @"/Views/NewWeakness/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_NewWeakness_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\NewWeakness\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yeni Pokemon Zayıflığı</h1>
<div class=""form-group"">
    <input id=""pokemon-weakness-name-input"" class=""form-control"" type=""text"" required placeholder=""Pokemon Zayıflığı İsmini Giriniz"" />
    <button id=""pokemon-weakness-submit"" class=""form-control btn btn-lg btn-primary my-3"">Oluştur</button>
</div>


<script>
    $(document).ready(function () {
        newWeakness();
    });

    function newWeakness() {
        $('#pokemon-weakness-submit').on('click', function () {
            let weakness = {};
            weakness.WEAKNESS_NAME = $('#pokemon-weakness-name-input').val();

            $.ajax({
            url: '");
#nullable restore
#line 25 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\NewWeakness\Index.cshtml"
             Write(Url.Action("NewWeakness","NewWeakness"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""POST"",
            data: { weakness: weakness},
            success: function (data) {
                if (data == ""başarılı"") {
                    swal({
                        title: ""Başarılı !"",
                        text: ""Pokemon Zayıflığı Başarıyla Oluşturuldu!"",
                        icon: ""success"",
                        button: ""Tamam"",
                    }).then(function () {
                        window.location.href = '");
#nullable restore
#line 36 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\NewWeakness\Index.cshtml"
                                           Write(Url.Action("Index","NewWeakness"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n                    });\r\n                }\r\n                else\r\n                    alert(\"Onaylama Başarısız!\");\r\n            }\r\n            });\r\n\r\n        })\r\n\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
