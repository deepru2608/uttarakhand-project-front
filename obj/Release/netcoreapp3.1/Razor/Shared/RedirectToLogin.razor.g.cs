#pragma checksum "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c36f69225f361478e48979e0d77bcbf677621c4"
// <auto-generated/>
#pragma warning disable 1591
namespace uttarakhand_project_front.Shared
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
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Shared\RedirectToLogin.razor"
      

    protected override void OnInitialized()
    {
        NavigationManager.NavigateTo("Login", true);
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
