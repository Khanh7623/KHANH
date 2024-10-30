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
#line 1 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using ASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Poly\C6\ASM\ASM\ASM.Client\_Imports.razor"
using ASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Poly\C6\ASM\ASM\ASM.Client\Pages\Register - Copy.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Poly\C6\ASM\ASM\ASM.Client\Pages\Register - Copy.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\Poly\C6\ASM\ASM\ASM.Client\Pages\Register - Copy.razor"
       
    //[Parameter]
    //public string id { get; set; }
    ASM.Share.Models.Khachhang khachhang = new ASM.Share.Models.Khachhang();
    //public string id { get; set; }
    //private ASM.Share.Models.MonAn monAn { get; set; }
    private string Tieude = "Đăng ký";
    //IReadOnlyList<IBrowserFile> selectedFiles;
    protected override void OnInitialized()
    {
    }

    private async void SubmitForm()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();        
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        //var khachhangId = sessionStorage.GetItem<int>("KhachhangId");

        //giohang.KhanghangId = khachhangId;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(khachhang), 
                System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Khachhang", content);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                //error += (error == "" ? "" : "<br/>") + " - Lỗi khi gọi API.";
                //xu ly loi
                //return Content(response.ToString());
            }
            else
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                if (apiResponse == "-1")
                {

                }
                else // luu thanh cong
                {
                    //sessionStorage.RemoveItem("cart");
                    //await JSRuntime.InvokeAsync<object>("clearCart", "");
                    NavigationManager.NavigateTo("/");
                }
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
