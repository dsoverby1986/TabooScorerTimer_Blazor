#pragma checksum "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b92c2afeca349370a3ba6ab2d7b590cf9d9fe26"
// <auto-generated/>
#pragma warning disable 1591
namespace TabooScorerTimer.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using TabooScorerTimer;

#line default
#line hidden
#line 7 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\_Imports.razor"
using TabooScorerTimer.Shared;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenComponent<TabooScorerTimer.Shared.NavMenu>(3);
            builder.CloseComponent();
            builder.AddMarkupContent(4, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(5, "\r\n\r\n");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "main");
            builder.AddMarkupContent(8, "\r\n    ");
            builder.OpenElement(9, "div");
            builder.AddAttribute(10, "class", "top-row px-4");
            builder.AddMarkupContent(11, "\r\n        ");
            builder.OpenComponent<TabooScorerTimer.Shared.LoginDisplay>(12);
            builder.CloseComponent();
            builder.AddMarkupContent(13, "\r\n        ");
            builder.AddMarkupContent(14, "<a href=\"https://docs.microsoft.com/en-us/aspnet/\" target=\"_blank\">About</a>\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n\r\n    ");
            builder.OpenElement(16, "div");
            builder.AddAttribute(17, "class", "content px-4");
            builder.AddMarkupContent(18, "\r\n        ");
            builder.AddContent(19, 
#line 14 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            builder.AddMarkupContent(20, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(21, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
