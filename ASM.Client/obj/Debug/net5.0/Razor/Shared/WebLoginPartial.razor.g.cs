#pragma checksum "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5979357d602aecc2d6c81d46b58d84f75a51ef8"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using ASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using ASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\_Imports.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    public partial class WebLoginPartial : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "navbar-nav");
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "nav-item");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "class", "nav-link text-dark");
            __builder.AddAttribute(6, "id", "cart");
            __builder.AddAttribute(7, "href", "/Cart");
#nullable restore
#line 6 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
             if (cart != null && cart != "")
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<img id=\"imgCart\" src=\"images/cartA.png\" style=\"width:30px\">");
#nullable restore
#line 9 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<img id=\"imgCart\" src=\"images/cart.png\" style=\"width:30px\">");
#nullable restore
#line 13 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "navbar-nav");
            __builder.AddAttribute(13, "id", "navLogin");
#nullable restore
#line 18 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
     if (emailAddress != null && emailAddress != "")
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "nav-item");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "nav-link text-dark");
            __builder.AddAttribute(18, "id", "information");
            __builder.AddAttribute(19, "href", "/Info");
            __builder.AddContent(20, "Hello ");
#nullable restore
#line 21 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
__builder.AddContent(21, emailAddress);

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "! | ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<li class=\"nav-item\"><a class=\"nav-link text-dark\" id=\"history\" href=\"/History\">Đơn hàng | </a></li>\r\n        ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "id", "logout");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
                                                        Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "nav-link btn btn-link text-dark");
            __builder.AddContent(32, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<li class=\"nav-item\"><a class=\"nav-link text-dark\" id=\"register\" href=\"/Register\">Đăng ký</a></li>\r\n        ");
            __builder.AddMarkupContent(34, "<li class=\"nav-item\"><a class=\"nav-link text-dark\" id=\"login\" href=\"/Login\">Đăng nhập</a></li>");
#nullable restore
#line 38 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Shared\WebLoginPartial.razor"
      
    string emailAddress;
    string cart;
    protected override async Task OnInitializedAsync()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        cart = sessionStorage.GetItem<string>("cart");
    }

    protected void o()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        cart = sessionStorage.GetItem<string>("cart");
    }

    protected void Logout()
    {
        sessionStorage.RemoveItem("AccessToken");
        sessionStorage.RemoveItem("Email");
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
