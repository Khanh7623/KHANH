// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.Server.Pages.Khachhang
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
#nullable restore
#line 2 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Pages\Khachhang\KhachhangList.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Pages\Khachhang\KhachhangList.razor"
using ASM.Server.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/khachhanglist")]
    public partial class KhachhangList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\khanh\Documents\Zalo Received Files\Assignment\ASM.Server\ASM.Server\Pages\Khachhang\KhachhangList.razor"
       

    public List<Nguoidung> nguoidungs;
    protected override void OnInitialized()
    {
        nguoidungs = _nguoidungService.GetNguoidungAll();
    }

    private void Delete(int id)
    {
        //_nguoidungService.AddNguoidungDelete(id);
        //employees = _service.GetEmployees();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.INguoidungSvc _nguoidungService { get; set; }
    }
}
#pragma warning restore 1591
