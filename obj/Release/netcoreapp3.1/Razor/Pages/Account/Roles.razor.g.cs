#pragma checksum "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6464b56c2abf7b006d2979840d2640a9141af204"
// <auto-generated/>
#pragma warning disable 1591
namespace uttarakhand_project_front.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using uttarakhand_project_front.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using Syncfusion.Blazor.PdfViewerServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
           [Authorize(Roles = "SuperAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Roles")]
    public partial class Roles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card border-left-primary shadow h-100 py-2");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
                         roleName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
                                                  CreateRole

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.AddMarkupContent(16, "<div class=\"col-sm-12 text-left\">\n                    <h4><span class=\"border-bottom\" style=\"color: #3C40C6\">Create New Role</span></h4>\n                </div>\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-sm-12 mt-2");
                __builder2.AddMarkupContent(19, "\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(20);
                __builder2.AddAttribute(21, "CssClass", "e-outline");
                __builder2.AddAttribute(22, "Placeholder", "Role Name");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
                                            roleName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => roleName = __value, roleName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => roleName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-12 mt-2 text-left");
                __builder2.AddMarkupContent(30, "\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(31);
                __builder2.AddAttribute(32, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "<i class=\"fas fa-plus-circle\"></i>&nbsp;Create Role");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n                    &nbsp;");
                __builder2.OpenElement(36, "img");
                __builder2.AddAttribute(37, "src", "Images/BlockLoader.gif");
                __builder2.AddAttribute(38, "alt", "Loader");
                __builder2.AddAttribute(39, "style", "height:" + " 30px;" + " width:" + " 30px;" + " display:" + " " + (
#nullable restore
#line 20 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
                                                                           Loader

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\n\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row mt-4");
            __builder.AddMarkupContent(46, "\n            ");
            __builder.AddMarkupContent(47, "<div class=\"col-sm-12 text-left\">\n                <h4><span class=\"border-bottom\" style=\"color: #3C40C6\">Roles List</span></h4>\n            </div>\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-12 mt-2");
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenComponent<uttarakhand_project_front.Pages.Account.RolesList>(51);
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n\n");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(57);
            __builder.AddAttribute(58, "ID", "toast_type");
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(61);
                __builder2.AddAttribute(62, "X", "Right");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n");
            }
            ));
            __builder.AddComponentReferenceCapture(64, (__value) => {
#nullable restore
#line 36 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
                ToastRolesObj = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Pages\Account\Roles.razor"
       
    SfToast ToastRolesObj;
    public string Loader { get; set; }
    public string roleName { get; set; } = string.Empty;

    protected override void OnInitialized()
    {
        Loader = "none";
    }

    async Task CreateRole()
    {
        Loader = "inline";
        if (string.IsNullOrEmpty(roleName))
        {
            Loader = "none";
            await ToastRolesObj.Show(new ToastModel {Title = "Error!", Content = "Please enter the Role Name!", CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
        }
        else
        {
            var result = await UserService.CreateRoleAsync(roleName);
            if (result == "success")
            {
                Loader = "none";
                roleName = string.Empty;
                await ToastRolesObj.Show(new ToastModel {Title = "Success!", Content = "You have created new role successfully.", CssClass = "e-toast-success", Icon = "e-success toast-icons"});
                NavigationManager.NavigateTo("Account/Roles", true);
            }
            else
            {
                Loader = "none";
                roleName = string.Empty;
                await ToastRolesObj.Show(new ToastModel {Title = "Error!", Content = result, CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
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