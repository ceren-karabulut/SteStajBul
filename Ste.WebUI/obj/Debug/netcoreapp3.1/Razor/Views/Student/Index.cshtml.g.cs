#pragma checksum "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e267e9d86b014ca2f44026d9575ae15c2aded3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 2 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
using Ste.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e267e9d86b014ca2f44026d9575ae15c2aded3", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe955b918c82e6d3f6d2a65077b9b2307022b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvertisimentListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<style>
    .card {
        float: left;
        margin-left: 25px;
        margin-top: 25px;
        width: 13rem;
    }

    .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
    }
</style>

<h1>STE İlanları</h1>


");
#nullable restore
#line 32 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 35 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
   Write(Html.TextBox("key", null, new { @class = "col-md-8", @placeholder = "Şehir veya bölüm " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-success btn-sm  col-md-1\" style=\"margin-bottom:1rem; margin-top:0.6rem\">Ara</button>\r\n    </p>\r\n");
#nullable restore
#line 38 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 42 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card"">
        <svg class=""bd-placeholder-img card-img-top"" width=""100"" height=""100"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">");
#nullable restore
#line 46 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                             Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text></svg>\r\n        <div class=\"card-body  \">\r\n            <h5 class=\"card-title\"> ");
#nullable restore
#line 48 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 49 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
                            Write(item.JobDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Firma: ");
#nullable restore
#line 50 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
                                   Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1653, "\"", 1704, 3);
            WriteAttributeValue("", 1660, "/Advertisiment/Get?id=", 1660, 22, true);
#nullable restore
#line 51 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"
WriteAttributeValue("", 1682, item.AdvertisimentId, 1682, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1703, "", 1704, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Detay</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\hotta\source\repos\SteStaj\Ste.WebUI\Views\Student\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvertisimentListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591