#pragma checksum "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "118709ae76679b8747d18dfef198423bdfe0caf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserMatches_Index), @"mvc.1.0.view", @"/Views/UserMatches/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserMatches/Index.cshtml", typeof(AspNetCore.Views_UserMatches_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"118709ae76679b8747d18dfef198423bdfe0caf3", @"/Views/UserMatches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_UserMatches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspnetfirst.Models.UserMatch>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "272f30ac8bda4b36aacd4810cf644cb1", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 47, false);
#line 16 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserMatchId));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 60, false);
#line 19 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Match.Team_home.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(415, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(471, 61, false);
#line 22 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Match.Team_guest.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(532, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(588, 49, false);
#line 25 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Match.MatchId));

#line default
#line hidden
            EndContext();
            BeginContext(637, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(693, 40, false);
#line 28 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(733, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(851, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(900, 46, false);
#line 37 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserMatchId));

#line default
#line hidden
            EndContext();
            BeginContext(946, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1002, 59, false);
#line 40 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Match.Team_home.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1117, 60, false);
#line 43 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Match.Team_guest.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1233, 48, false);
#line 46 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Match.MatchId));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1337, 46, false);
#line 49 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1439, 82, false);
#line 52 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  user_id=item.UserId,match_id=item.MatchId}));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1542, 88, false);
#line 53 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { user_id=item.UserId,match_id=item.MatchId }));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1651, 87, false);
#line 54 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  user_id=item.UserId,match_id=item.MatchId }));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\UserMatches\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1777, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspnetfirst.Models.UserMatch>> Html { get; private set; }
    }
}
#pragma warning restore 1591