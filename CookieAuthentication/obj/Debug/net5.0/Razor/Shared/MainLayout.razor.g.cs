#pragma checksum "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9f5dbebf94a1d62914112e597663186865a5ab"
// <auto-generated/>
#pragma warning disable 1591
namespace CookieAuthentication.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using CookieAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\_Imports.razor"
using CookieAuthentication.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-xfzadweeqc");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-xfzadweeqc");
            __builder.OpenComponent<CookieAuthentication.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-xfzadweeqc");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-xfzadweeqc");
            __builder.OpenComponent<CookieAuthentication.Shared.LoginControl>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddAttribute(18, "b-xfzadweeqc");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\rdeleon\RiderProjects\CookieAuthentication\CookieAuthentication\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
