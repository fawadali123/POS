// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Softanize.POZ.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Softanize.POZ.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Softanize.POZ.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\_Imports.razor"
using Softanize.POZ.Web.Pages.Item;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\Pages\Items - Copy.razor"
using Softanize.POZ.DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\Pages\Items - Copy.razor"
using Softanize.POZ.Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/items")]
    public partial class Items___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Softanize\Softanize.POS\Softanize.POZ.Web\Pages\Items - Copy.razor"
       
    private List<Category> categories = new List<Category>();

    protected override async Task OnInitializedAsync()
    {
        GetAllCategory();
    }
    private List<Category> GetAllCategory()
    {
        categories = CategoryRepositry.GetCategory();
        return categories;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar Snakebar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Softanize.POZ.Service.Service.My_Item.CategoryInterface CategoryRepositry { get; set; }
    }
}
#pragma warning restore 1591