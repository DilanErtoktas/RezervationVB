#pragma checksum "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b6a69a7383855399bb70e9a0e56b85d4afa50e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rezerve_RezerveGetir), @"mvc.1.0.view", @"/Views/Rezerve/RezerveGetir.cshtml")]
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
#line 1 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\_ViewImports.cshtml"
using RezervationVB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\_ViewImports.cshtml"
using RezervationVB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b6a69a7383855399bb70e9a0e56b85d4afa50e", @"/Views/Rezerve/RezerveGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140b2ad924c9b3d5d5c75d99a07ebb951fd65acc", @"/Views/_ViewImports.cshtml")]
    public class Views_Rezerve_RezerveGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RezervationVB.Models.rezerve>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
  
    ViewData["Title"] = "RezerveGetir";
    Layout = "~/Views/Shared/_LayoutTümlesik.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h3 class=\"card-header\">Rezervasyon Güncelle</h3>\r\n\r\n<div class=\"container row shadow\">\r\n    <div class=\"col-md-12 mt-5 mb-5\">\r\n\r\n");
#nullable restore
#line 12 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
         using (Html.BeginForm("RezerveGuncelle", "Rezerve", FormMethod.Post))
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-top:15px\">\r\n                <label class=\"font-weight-bold\">Rezerve ID</label>\r\n\r\n                ");
#nullable restore
#line 19 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
           Write(Html.TextBoxFor(x => x.rezerveid, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div style=\"margin-top:15px\">\r\n                <label class=\"font-weight-bold\">Sicil No</label>\r\n                ");
#nullable restore
#line 25 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
           Write(Html.TextBoxFor(x => x.sicilno, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div style=\"margin-top:15px\">\r\n                <label class=\"font-weight-bold\">Personel Adı</label>\r\n                ");
#nullable restore
#line 31 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
           Write(Html.TextBoxFor(x => x.kullaniciadi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div style=\"margin-top:15px\">\r\n                <label class=\"font-weight-bold\">Rezerve Başlangıç Tarihi   ");
#nullable restore
#line 36 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
                                                                      Write(Html.TextBoxFor(x => x.rezervebaslangic, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div style=\"margin-top:15px\">\r\n                <label class=\"font-weight-bold\">Rezerve Bitiş Tarihi ");
#nullable restore
#line 42 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
                                                                Write(Html.TextBoxFor(x => x.rezervebitis, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n\r\n            </div>\r\n            <div style=\"margin-top:15px\">\r\n                <label class=\"font-weight-bold\">Masa Etiketi</label>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 49 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"
           Write(Html.DropDownListFor(x => x.masaid, (List<SelectListItem>)ViewBag.dgr1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
            WriteLiteral("                    <div style=\"margin-top:15px\">\r\n                        <a href=\"/Rezerve/Index/\" class=\"btn btn-primary\">Vazgeç&nbsp;</a>\r\n                        <button class=\"btn btn-success\">Güncelle</button>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 60 "D:\Users\VB36608\source\repos\RezervationVB\RezervationVB\Views\Rezerve\RezerveGetir.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezervationVB.Models.rezerve> Html { get; private set; }
    }
}
#pragma warning restore 1591
