#pragma checksum "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\AssignUserRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dbd16421458c89433ad6f81a684499903c633e6"
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
#line 1 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using uttarakhand_project_front.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using Syncfusion.Blazor.PdfViewerServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\AssignUserRoles.razor"
           [Authorize(Roles = "SuperAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/AssignUserRoles")]
    public partial class AssignUserRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\AssignUserRoles.razor"
       
    SfToast ToastAssignObj;
    public IEnumerable<string> usersList { get; set; }
    public string userData { get; set; }
    public IEnumerable<string> rolesList { get; set; }
    public string roleName { get; set; }
    public string Loader { get; set; }

    protected override async Task OnInitializedAsync()
    {
        usersList = new List<string>();
        rolesList = new List<string>();
        await BindUserRoles();
        Loader = "none";
    }

    private async Task BindUserRoles()
    {
        var roles = await UserService.GetRolesListAsync();
        rolesList = roles.Select(s => s.Name).ToList();
        var users = await UserService.GetAllUsersAsync();
        usersList = users.Select(s => s.Email).ToList();
    }

    async Task AssignRemoveUserInRole(string action)
    {
        if (!string.IsNullOrEmpty(userData) && !string.IsNullOrEmpty(roleName))
        {
            Loader = "inline";
            AssignUserRoleViewModel model = new AssignUserRoleViewModel
            {
                Action = action,
                RoleName = roleName,
                Email = userData
            };
            var result = await UserService.AssignRemoveUserInRoleAsync(model);
            if (result == "success")
            {
                Loader = "none";
                string Message = string.Empty;
                if (action == "Assign")
                {
                    Message = $"You have assign {model.RoleName} role to {model.Email} username successfully.";
                }
                else if (action == "Remove")
                {
                    Message = $"You have Remove {model.RoleName} role to {model.Email} username successfully.";
                }
                await ToastAssignObj.Show(new ToastModel {Title = "Success!", Content = Message, CssClass = "e-toast-success", Icon = "e-success toast-icons"});
                NavigationManager.NavigateTo("Account/AssignUserRoles", true);
            }
            else
            {
                Loader = "none";
                await ToastAssignObj.Show(new ToastModel {Title = "Error!", Content = result, CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
                NavigationManager.NavigateTo("Account/AssignUserRoles", true);
            }
        }
        else
        {
            string Message = "Please fill all the fields!";
            await ToastAssignObj.Show(new ToastModel {Title = "Error!", Content = Message, CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
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
