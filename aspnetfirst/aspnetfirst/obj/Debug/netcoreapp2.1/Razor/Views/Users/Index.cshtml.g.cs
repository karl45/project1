#pragma checksum "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da5b107ebcf08fbf260371eb6e003e8ff0b2af93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da5b107ebcf08fbf260371eb6e003e8ff0b2af93", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspnetfirst.Models.Match>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 254, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n<h3>Matches</h3>\r\n<table>\r\n    <thead>\r\n \r\n\r\n        <tr>\r\n            <th>Name_of_person</th>\r\n            <th>TeamHomeName</th>\r\n            <th>TeamGuestName</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
             foreach (var Item in Model)
            {
                
                

#line default
#line hidden
#line 26 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                 foreach (var user in Item.UserMatches)
                {

#line default
#line hidden
            BeginContext(494, 50, true);
            WriteLiteral("                    <tr>\r\n                    <td>");
            EndContext();
            BeginContext(545, 44, false);
#line 29 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(model => user.User.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(589, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(621, 49, false);
#line 30 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(model => Item.Team_home.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(670, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(702, 50, false);
#line 31 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(model => Item.Team_guest.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(752, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                 }

#line default
#line hidden
#line 33 "C:\Users\stazher05\Desktop\ses\project1\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                  

            }

#line default
#line hidden
            BeginContext(823, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspnetfirst.Models.Match>> Html { get; private set; }
    }
}
#pragma warning restore 1591
