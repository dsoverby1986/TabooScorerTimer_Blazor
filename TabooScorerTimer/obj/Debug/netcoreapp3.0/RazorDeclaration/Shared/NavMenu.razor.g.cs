#pragma checksum "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fe0486b1b5c047e9f5575ae9bee53872ad11eee"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 18 "C:\Users\soverby\source\repos\TabooScorerTimer\TabooScorerTimer\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
