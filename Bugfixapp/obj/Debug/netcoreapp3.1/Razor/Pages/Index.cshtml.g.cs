#pragma checksum "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78d0f5eaa2182ecf6cc474e353809f148c4f9b95fddeddbe77de97b403dbd97c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bugfixapp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Bugfixapp.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/_ViewImports.cshtml"
using Bugfixapp

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"78d0f5eaa2182ecf6cc474e353809f148c4f9b95fddeddbe77de97b403dbd97c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"66ddafc33b5f2a1796a2a2b2085fa1dbead367447504f4f9d52c077198b8154f", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
  
	ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""text-center"">
	<h1 class=""display-4"">Welcome</h1>
	<p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<table class=""table"">
	<thead>
		<tr>
			<th>User</th>
			<th>Values</th>
			<th>Edit</th>
		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 21 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
   foreach (var user in Model.Users)
		{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t<tr>\n\t\t\t\t<td>");
            Write(
#nullable restore
#line 24 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
         user.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n\t\t\t\t<td>\n\t\t\t\t\t<ul>\n");
#nullable restore
#line 27 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
       foreach (var value in user.UserValues.Select(uv => uv.UserId))
						{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t<li>");
            Write(
#nullable restore
#line 29 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
            value

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\n");
#nullable restore
#line 30 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
						}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t</ul>\n\t\t\t\t</td>\n\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 594, "\"", 643, 1);
            WriteAttributeValue("", 601, 
#nullable restore
#line 33 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
                  Url.Page("EditUser", new { user.UserId })

#line default
#line hidden
#nullable disable
            , 601, 42, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Edit</a></td>\n\t\t\t</tr>\n");
#nullable restore
#line 35 "/Users/gautamronanki/Desktop/BugFixApp/Bugfixapp/Pages/Index.cshtml"
		}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t</tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
