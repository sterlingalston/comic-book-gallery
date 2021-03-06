#pragma checksum "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894ba0c055adb6ad686e14c39f5c3f5e014dc228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComicBooks_Detail), @"mvc.1.0.view", @"/Views/ComicBooks/Detail.cshtml")]
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
#line 1 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\_ViewImports.cshtml"
using ComicBookGallery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\_ViewImports.cshtml"
using ComicBookGallery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894ba0c055adb6ad686e14c39f5c3f5e014dc228", @"/Views/ComicBooks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5ba06cef919a5c080e998e4bde2babcc31fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_ComicBooks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicBookGallery.Models.ComicBook>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
  
   // Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = Model.DisplayText;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 11 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
Write(Model.DisplayText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"well\">\r\n            <h5><label>Series Title: </label>");
#nullable restore
#line 16 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                                        Write(Model.SeriesTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5><label>Issue #:</label> ");
#nullable restore
#line 17 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                                   Write(Model.IssueNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5><label>Favorite:</label> ");
#nullable restore
#line 18 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                                     Write(Model.Favorite ? "Yes" : "No" );

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 19 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
             if (Model.Artists.Length > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>Artists:</h5>\r\n                <div>\r\n                    <ul>\r\n");
#nullable restore
#line 24 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                         foreach (var artist in Model.Artists)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 26 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                           Write(artist.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 26 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                                         Write(artist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 27 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <h5>Description</h5>\r\n       <div>");
#nullable restore
#line 33 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
       Write(Html.Raw(Model.DescriptionHtml));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1130, "\"", 1169, 2);
            WriteAttributeValue("", 1136, "/Images/", 1136, 8, true);
#nullable restore
#line 36 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
WriteAttributeValue("", 1144, Model.CoverImageFileName, 1144, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n             alt=\"", 1170, "\"", 1208, 1);
#nullable restore
#line 37 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
WriteAttributeValue("", 1190, Model.DisplayText, 1190, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComicBookGallery.Models.ComicBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
