#pragma checksum "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9870e228af7c47db7c258b7c485c9dd16d51f60d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9870e228af7c47db7c258b7c485c9dd16d51f60d", @"/Views/ComicBooks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5ba06cef919a5c080e998e4bde2babcc31fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_ComicBooks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
  
    Layout = null;
    var seriesTitle = "The Amazing Spider-Man";
    var issueNumber = 700;
    var description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
    var artists = new string[]
    {
        "Script: Dan Slott",
        "Pencils: Humberto Ramos",
        "Inks: Victor Olazaba",
        "Colors: Edgar Delgado",
        "Letters: Chris Eliopoulos"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9870e228af7c47db7c258b7c485c9dd16d51f60d4098", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9870e228af7c47db7c258b7c485c9dd16d51f60d5152", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>");
#nullable restore
#line 28 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
       Write(seriesTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <h2>Issue #");
#nullable restore
#line 29 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
              Write(issueNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n        <h5>Description:</h5>\r\n        <div>");
#nullable restore
#line 32 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
        Write(Html.Raw(description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 33 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
         if(artists.Length > 0)
        { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h5>Artists:</h5>\r\n            <div>\r\n                <ul>\r\n");
#nullable restore
#line 38 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                     foreach (var artist in artists)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>");
#nullable restore
#line 40 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                       Write(artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\Users\sterl\source\repos\comic-book-gallery\src\ComicBookGallery\ComicBookGallery\Views\ComicBooks\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
