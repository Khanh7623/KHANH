// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.Server.Pages.MonAn
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\Pages\MonAn\MonAnDialog1.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MonAndialog/{id}")]
    public partial class MonAnDialog1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\Poly\C6\ASM\ASM\ASM.Server\ASM.Server\Pages\MonAn\MonAnDialog1.razor"
       
    [Parameter]
    public string id { get; set; }

    //public string id { get; set; }
    private ASM.Share.Models.Nguoidung nguoidung { get; set; }
    private string Tieude = "";

    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {

            Tieude = "Thêm người dùng";
            nguoidung = new ASM.Share.Models.Nguoidung();
        }
        else
        {
            Tieude = "Sửa người dùng";
            nguoidung = _nguoidungService.GetNguoidung(int.Parse(id));
        }

    }

    private void SubmitForm()
    {
        if (nguoidung.NguoidungID == 0)
        {
            _nguoidungService.AddNguoidung(nguoidung);
        }
        else
        {
            _nguoidungService.EditNguoidung(nguoidung.NguoidungID, nguoidung);
        }

        navigation.NavigateTo("NguoidungList");
    }

    private void Cancel()
    {
        navigation.NavigateTo("NguoidungList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.IMonAnSvc _monAnService { get; set; }
    }
}
#pragma warning restore 1591
