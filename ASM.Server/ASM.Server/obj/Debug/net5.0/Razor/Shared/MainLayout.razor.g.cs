#pragma checksum "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ffd9f0ed2d9f2b178f3089f7c63c8955690904"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-mchd10g218");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-mchd10g218");
            __builder.OpenComponent<global::ASM.Server.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-mchd10g218");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-mchd10g218");
            __builder.OpenComponent<global::ASM.Server.Shared.LoginControl>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-mchd10g218>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-mchd10g218");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(21);
            __builder.AddAttribute(22, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 16 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Shared\MainLayout.razor"
__builder2.AddContent(23, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(24, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 20 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Shared\MainLayout.razor"
__builder2.AddContent(25, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Shared\MainLayout.razor"
      
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    private string name;

    protected async override Task OnInitializedAsync()
    {
        //context.User.Identity.Name
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        //await sessionStorage.SetItemAsync("name", "John Smith");
        //var name = await sessionStorage.GetItemAsync<string>("name");
        //if (string.IsNullOrEmpty(name))
        //{
        //    NavigationManager.NavigateTo("login");
        //}
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
