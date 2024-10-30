// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.Client.Pages
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
#line 2 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\History.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\History.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\History.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\History.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/History")]
    public partial class History : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\History.razor"
       
    private string emailAddress;
    public List<Donhang> donHangs = new List<Donhang>();

    public ASM.Share.Models.Cart giohang;
    private double total = 0;
    protected string imgUrl = "";
    protected string temp = "";

    protected override async Task OnInitializedAsync()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");//get key cart
        int khachhangId = sessionStorage.GetItem<int>("KhachhangId");//get key cart

        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        donHangs = new List<Donhang>();
        using (var client = new HttpClient())
        {
            Dictionary<string, string> query = new Dictionary<string, string>();
            client.DefaultRequestHeaders.Authorization = new
                    System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);

            using (var response = await client.GetAsync("Donhang/?id=" + khachhangId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                donHangs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Donhang>>(apiResponse);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
