#pragma checksum "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Shared\TopNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b20936f22ce6c999bbc69a8f66ee10eeadcc0541"
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
    public partial class TopNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "id", "sidebarToggleTop");
            __builder.AddAttribute(5, "class", "btn btn-link rounded-circle mr-3");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Shared\TopNavMenu.razor"
                                                                                     ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <i class=\"fa fa-bars\"></i>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(9, "<form class=\"d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search\">\r\n        <h4 class=\"card-title text-center pt-2\"><strong class=\"border-bottom\">Registration Portal</strong></h4>\r\n    </form>\r\n\r\n    \r\n    ");
            __builder.OpenElement(10, "ul");
            __builder.AddAttribute(11, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(12, "\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(13, @"<li class=""nav-item dropdown no-arrow d-sm-none"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
            </a>
            
            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"" aria-labelledby=""searchDropdown"">
                <form class=""form-inline mr-auto w-100 navbar-search"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"">
                                <i class=""fas fa-search fa-sm""></i>
                            </button>
                        </div>
                    </div>
                </form>
            </div>
        </li>

        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                \r\n                ");
                __builder2.OpenElement(17, "li");
                __builder2.AddAttribute(18, "class", "nav-item dropdown no-arrow");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "class", "nav-link dropdown-toggle");
                __builder2.AddAttribute(22, "href", "#");
                __builder2.AddAttribute(23, "id", "userDropdown");
                __builder2.AddAttribute(24, "role", "button");
                __builder2.AddAttribute(25, "data-toggle", "dropdown");
                __builder2.AddAttribute(26, "aria-haspopup", "true");
                __builder2.AddAttribute(27, "aria-expanded", "false");
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "span");
                __builder2.AddAttribute(30, "class", "mr-2 d-none d-lg-inline text-gray-600 small");
                __builder2.AddContent(31, 
#nullable restore
#line 42 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Shared\TopNavMenu.razor"
                                                                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        <img class=\"img-profile rounded-circle\" src=\"Images/Kumaun-University-job.png\">\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    \r\n                    ");
                __builder2.AddMarkupContent(34, @"<div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                        <a class=""dropdown-item"" href=""ChangePwd"">
                            <i class=""fas fa-key fa-sm fa-fw mr-2 text-gray-400""></i>
                            Change Password
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                            <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                            Logout
                        </a>
                    </div>
                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Shared\TopNavMenu.razor"
      
    private async Task ToggleNavMenu()
    {
        await Js.ShowNavMenu();
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