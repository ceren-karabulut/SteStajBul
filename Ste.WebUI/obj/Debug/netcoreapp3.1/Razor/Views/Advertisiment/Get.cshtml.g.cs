#pragma checksum "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8363f9535bc76028bb64e2829c958dd6f5223ad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisiment_Get), @"mvc.1.0.view", @"/Views/Advertisiment/Get.cshtml")]
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
#line 1 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\_ViewImports.cshtml"
using Ste.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\_ViewImports.cshtml"
using Ste.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8363f9535bc76028bb64e2829c958dd6f5223ad7", @"/Views/Advertisiment/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe955b918c82e6d3f6d2a65077b9b2307022b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisiment_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvertisimentListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
  
    ViewData["Title"] = "Get";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>İlan Detayı</h1>\r\n<br />\r\n\r\n\r\n<div class=\"container\" style=\"font-size:large\">\r\n    <div >\r\n        ");
#nullable restore
#line 12 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.LabelFor(x => x.CompanyName, "Firma Adı:", new { @class = "col-md-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.DisplayFor(x => x.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div >\r\n            ");
#nullable restore
#line 17 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
       Write(Html.LabelFor(x => x.Email, "Email", new { @class = "col-md-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
       Write(Html.DisplayFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    <div >\r\n        ");
#nullable restore
#line 22 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.LabelFor(x => x.JobTitle, "Pozizyon:", new { @class = "col-md-3 col-form-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.DisplayFor(x => x.JobTitle ,new {@class="text-black-50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div >\r\n        ");
#nullable restore
#line 27 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.LabelFor(x => x.JobDesc, "İş Tanımı:", new { @class = "col-md-3 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.DisplayFor(x => x.JobDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div >\r\n        ");
#nullable restore
#line 32 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.LabelFor(x => x.NumberOfStudents, "Alınacak Öğrenci Sayısı:", new { @class = "col-md-3  col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.DisplayFor(x => x.NumberOfStudents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 38 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.LabelFor(x => x.City, "Şehir:", new { @class = "col-md-3 col-form-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.DisplayFor(x => x.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div >\r\n        ");
#nullable restore
#line 43 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.LabelFor(x => x.Adress, "Adress:", new { @class = "col-md-3 col-form-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
   Write(Html.DisplayFor(x => x.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div  class=\"row\">\r\n        <a style=\"margin-left:290px;\" , class=\"btn btn-success btn-lg \"");
            BeginWriteAttribute("href", " href=\"", 1491, "\"", 1538, 2);
            WriteAttributeValue("", 1498, "/Student/Apply?id=", 1498, 18, true);
#nullable restore
#line 48 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Get.cshtml"
WriteAttributeValue("", 1516, Model.AdvertisimentId, 1516, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Başvur</a>\r\n    </div>\r\n        \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvertisimentListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
