#pragma checksum "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b75f666bedbef05ab9f799622466a1223d53e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/_ViewImports.cshtml"
using Zodiac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/_ViewImports.cshtml"
using Zodiac.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b75f666bedbef05ab9f799622466a1223d53e1", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d75a12b1ba3eb421ce12a87bb0da9c039dbe5798", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zodiac.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"result\">\r\n        <h1>Your data:</h1>\r\n        <div>Name: ");
#nullable restore
#line 11 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Surname: ");
#nullable restore
#line 12 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
                 Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Email: ");
#nullable restore
#line 13 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Birthday: ");
#nullable restore
#line 14 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
                  Write(Model.Birthday.Birthday.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Adult: ");
#nullable restore
#line 15 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
               Write(Model.IsAdult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Zodiac: ");
#nullable restore
#line 16 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
                Write(Model.SunSign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Chinese Zodiac: ");
#nullable restore
#line 17 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
                        Write(Model.ChineseSign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Celebrate: ");
#nullable restore
#line 18 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
                   Write(Model.IsBirthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <h1>");
#nullable restore
#line 19 "/Users/denys/KMA/C#_2020/Tests/Zodiac_CS-master 3/Zodiac/Views/Home/Result.cshtml"
       Write(ViewBag.Whishes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zodiac.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
