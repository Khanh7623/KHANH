#pragma checksum "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b108d716cf03565b05676652fda8b8540ae0628a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Đăng ký</h1>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 14 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                          khachhang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                                     SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label class=\"control-label\">Khách hàng</label>\r\n                ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.FullName = __value, khachhang.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                ");
                global::__Blazor.ASM.Client.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 20 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                          () => khachhang.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label class=\"control-label\">Ngày sinh</label>\r\n                ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "type", "date");
                __builder2.AddAttribute(28, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.Ngaysinh

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(29, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Ngaysinh = __value, khachhang.Ngaysinh, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                global::__Blazor.ASM.Client.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 31, 32, 
#nullable restore
#line 25 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                          () => khachhang.Ngaysinh

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "<label class=\"control-label\">Phone</label>\r\n                ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "type", "tel");
                __builder2.AddAttribute(40, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.PhoneNumber = __value, khachhang.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                global::__Blazor.ASM.Client.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 43, 44, 
#nullable restore
#line 30 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                          () => khachhang.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "<label asp-for=\"EmailAddress\" class=\"control-label\">Email</label>\r\n                ");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "type", "email");
                __builder2.AddAttribute(52, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.EmailAddress = __value, khachhang.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                ");
                global::__Blazor.ASM.Client.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 55, 56, 
#nullable restore
#line 35 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                          () => khachhang.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label class=\"control-label\">Mật khẩu</label>\r\n                ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Password = __value, khachhang.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                global::__Blazor.ASM.Client.Pages.Register.TypeInference.CreateValidationMessage_4(__builder2, 66, 67, 
#nullable restore
#line 40 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                          () => khachhang.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "<label class=\"control-label\">Mật khẩu (lần 2)</label>\r\n                ");
                __builder2.OpenElement(72, "input");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.ConfirmPassword = __value, khachhang.ConfirmPassword));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                ");
                global::__Blazor.ASM.Client.Pages.Register.TypeInference.CreateValidationMessage_5(__builder2, 77, 78, 
#nullable restore
#line 45 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                                          () => khachhang.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "<label asp-for=\"Mota\" class=\"control-label\"></label>\r\n                ");
                __builder2.OpenElement(83, "input");
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
                              khachhang.Mota

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Mota = __value, khachhang.Mota));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.AddMarkupContent(88, "<div class=\"form-group\"><input type=\"submit\" value=\"Create\" class=\"btn btn-primary\"></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.AddMarkupContent(90, "<div><a href=\"/Index\">Trang chủ</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Client\Pages\Register.razor"
       
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
namespace __Blazor.ASM.Client.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
