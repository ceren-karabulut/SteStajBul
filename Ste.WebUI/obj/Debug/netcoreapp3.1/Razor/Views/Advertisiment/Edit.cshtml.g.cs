#pragma checksum "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486f65501a0454f15c7520677fd3576587bb7563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisiment_Edit), @"mvc.1.0.view", @"/Views/Advertisiment/Edit.cshtml")]
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
#line 2 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
using Ste.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486f65501a0454f15c7520677fd3576587bb7563", @"/Views/Advertisiment/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe955b918c82e6d3f6d2a65077b9b2307022b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisiment_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvertisimentUpdateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
 if (SignInManager.IsSignedIn(User))
{

    var user = await UserManager.GetUserAsync(User);


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>İlan Düzenle</h1>\r\n");
#nullable restore
#line 16 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
 if (ViewBag.AffectedRowCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <p>İlanınız düzenlendi.</p>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 26 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.LabelFor(x => x.CompanyName, "Firma Adı", new { @class = "col-md-4 col-form-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p>");
#nullable restore
#line 27 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
          Write(user.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 31 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.LabelFor(x => x.JobTitle, "Pozizyon", new { @class = "col-md-4 col-form-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.JobTitle, "Web Geliştirici", new { @class = "col-md-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.ValidationMessageFor(x => x.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 37 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.LabelFor(x => x.City, "Şehir", new { @class = "col-md-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.City, null, new { @class = "col-md-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.ValidationMessageFor(x => x.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 43 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.LabelFor(x => x.JobDesc, "İş Tanımı", new { @class = "col-md-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.TextAreaFor(x => x.JobDesc, new { @class = "col-md-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 45 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.ValidationMessageFor(x => x.JobDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 49 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.LabelFor(x => x.NumberOfStudents, "Alınacak Öğrenci Sayısı", new { @class = "col-md-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 50 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.NumberOfStudents, null, new {@type="number", @class = "col-md-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.ValidationMessageFor(x => x.NumberOfStudents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group row\">\r\n            ");
#nullable restore
#line 55 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
       Write(Html.LabelFor(x => x.Adress, "Adress", new { @class = "col-md-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p>");
#nullable restore
#line 56 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
          Write(user.AdressDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button class=\"btn btn-success\" type=\"submit\">Kaydet</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Advertisiment\Edit.cshtml"
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CompanyUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CompanyUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvertisimentUpdateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591