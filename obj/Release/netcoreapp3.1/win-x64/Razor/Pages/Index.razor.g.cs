#pragma checksum "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a552fa20158bf2a9d3adb3e362c7b38608bc7e76"
// <auto-generated/>
#pragma warning disable 1591
namespace uttarakhand_project_front.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using uttarakhand_project_front.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using Syncfusion.Blazor.PdfViewerServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Index.razor"
           [Authorize(Roles = "User, Admin, SuperAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\n    <h1 class=\"h3 mb-0 text-gray-800\">Dashboard</h1>\n</div>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Roles", "Admin");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n    \n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "\n        \n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-4 mb-4 mt-1");
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card border-left-primary shadow h-100 py-2");
                __builder2.AddMarkupContent(13, "\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "card-body");
                __builder2.AddMarkupContent(16, "\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row no-gutters align-items-center");
                __builder2.AddMarkupContent(19, "\n                        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col mr-2");
                __builder2.AddMarkupContent(22, "\n                            ");
                __builder2.AddMarkupContent(23, "<div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Total Users Registered</div>\n                            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "h5 mb-0 font-weight-bold text-gray-800");
                __builder2.AddContent(26, 
#nullable restore
#line 19 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Index.razor"
                                                                                 TotalUserRegistered

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n                        ");
                __builder2.AddMarkupContent(29, "<div class=\"col-auto\">\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\n                        </div>\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n\n        \n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-4 mb-4 mt-1");
                __builder2.AddMarkupContent(36, "\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "card border-left-success shadow h-100 py-2");
                __builder2.AddMarkupContent(39, "\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "card-body");
                __builder2.AddMarkupContent(42, "\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "row no-gutters align-items-center");
                __builder2.AddMarkupContent(45, "\n                        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col mr-2");
                __builder2.AddMarkupContent(48, "\n                            ");
                __builder2.AddMarkupContent(49, "<div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Total Forms Submitted</div>\n                            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "h5 mb-0 font-weight-bold text-gray-800");
                __builder2.AddContent(52, 
#nullable restore
#line 36 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Index.razor"
                                                                                 TotalFormSubmit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n                        ");
                __builder2.AddMarkupContent(55, "<div class=\"col-auto\">\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\n                        </div>\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n\n        \n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-md-4 mb-4 mt-1");
                __builder2.AddMarkupContent(62, "\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "card border-left-primary shadow h-100 py-2");
                __builder2.AddMarkupContent(65, "\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "card-body");
                __builder2.AddMarkupContent(68, "\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row no-gutters align-items-center");
                __builder2.AddMarkupContent(71, "\n                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col mr-2");
                __builder2.AddMarkupContent(74, "\n                            ");
                __builder2.AddMarkupContent(75, "<div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Total Forms Payment</div>\n                            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "h5 mb-0 font-weight-bold text-gray-800");
                __builder2.AddContent(78, 
#nullable restore
#line 53 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Index.razor"
                                                                                 TotalPaymentDone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n                        ");
                __builder2.AddMarkupContent(81, "<div class=\"col-auto\">\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\n                        </div>\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n\n    \n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Pages\Index.razor"
      
    public int TotalUserRegistered { get; set; }
    public int TotalFormSubmit { get; set; }
    public int TotalPaymentDone { get; set; }
    [CascadingParameter]
    public Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var users = await dapperService.GetAllUserListAsync();
        if (users.Any())
            TotalUserRegistered = users.Count();
        else
            TotalUserRegistered = 0;
        var formsSumit = await dapperService.GetAllRegistrationDetailsAsync();
        if (formsSumit.Any())
            TotalFormSubmit = formsSumit.Count();
        else
            TotalFormSubmit = 0;
        var usersCountWithPayment = await dapperService.GetPaymentsDetailsAsync();
        if (usersCountWithPayment.Any())
            TotalPaymentDone = formsSumit.Where(w => w.IsPaymentDone == "Yes").Count();
        else
            TotalPaymentDone = 0;
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
