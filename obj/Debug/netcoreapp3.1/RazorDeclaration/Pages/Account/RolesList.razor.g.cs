#pragma checksum "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Account\RolesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d7a9aff8be65c389618e97c0cf901149dbb897"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace uttarakhand_project_front.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.PdfViewerServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Account\RolesList.razor"
           [Authorize(Roles = "SuperAdmin")]

#line default
#line hidden
#nullable disable
    public partial class RolesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\deepa\Desktop\Blazor\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Account\RolesList.razor"
       
    SfToast ToastRolesListObj;
    public IEnumerable<IdentityRole> Roles { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Roles = new List<IdentityRole>();
        await LoadRolesList();
    }

    private async Task LoadRolesList()
    {
        Roles = await UserService.GetRolesListAsync();
    }

    void RouteToRole()
    {
        NavigationManager.NavigateTo("Roles", true);
    }

    async Task DeleteRole(string roleId, bool visibility)
    {
        await Js.InvokeVoidAsync("confirmDelete", roleId, visibility);
    }

    async Task ConfirmDelete(string roleId)
    {
        if (string.IsNullOrEmpty(roleId))
        {
            await ToastRolesListObj.Show(new ToastModel {Title = "Error!", Content = "Please send the valid request!", CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
        }
        else
        {
            var result = await UserService.DeleteRoleAsync(roleId);
            if (result == "success")
            {
                await ToastRolesListObj.Show(new ToastModel {Title = "Success!", Content = "You have deleted this role successfully.", CssClass = "e-toast-success", Icon = "e-success toast-icons"});
                NavigationManager.NavigateTo("Account/Roles", true);
            }
            else
            {
                await ToastRolesListObj.Show(new ToastModel {Title = "Error!", Content = result, CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
                NavigationManager.NavigateTo("Account/Roles", true);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPaymentService paymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DapperService dapperService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CaptchaService captchaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment hostingEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICenterService CenterService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
