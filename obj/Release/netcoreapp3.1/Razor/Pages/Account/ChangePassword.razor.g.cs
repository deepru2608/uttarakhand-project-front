#pragma checksum "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a04952b2f46e01462401dad652b90a3b7cfb5ee"
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
#line 3 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
           [Authorize(Roles = "User, Admin, SuperAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChangePwd")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card border-left-primary shadow h-100 py-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                         changePassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                        ChangeUserPassword

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<div class=\"col-sm-12 text-left\">\r\n                    <h4><span class=\"border-bottom\" style=\"color: #3C40C6\">Change Password</span></h4>\r\n                </div>\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-sm-4 mt-3");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(20);
                __builder2.AddAttribute(21, "CssClass", "e-outline");
                __builder2.AddAttribute(22, "Placeholder", "Current Password");
                __builder2.AddAttribute(23, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 14 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                                          Syncfusion.Blazor.Inputs.InputType.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 15 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                                             FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                            changePassword.CurrentPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changePassword.CurrentPassword = __value, changePassword.CurrentPassword))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => changePassword.CurrentPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __Blazor.uttarakhand_project_front.Pages.Account.ChangePassword.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 16 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                              () => changePassword.CurrentPassword

#line default
#line hidden
#nullable disable
                , 31, "color: red");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-sm-4 mt-3");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(37);
                __builder2.AddAttribute(38, "CssClass", "e-outline");
                __builder2.AddAttribute(39, "Placeholder", "New Password");
                __builder2.AddAttribute(40, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 19 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                                      Syncfusion.Blazor.Inputs.InputType.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 20 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                                         FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                            changePassword.NewPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changePassword.NewPassword = __value, changePassword.NewPassword))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => changePassword.NewPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __Blazor.uttarakhand_project_front.Pages.Account.ChangePassword.TypeInference.CreateValidationMessage_1(__builder2, 46, 47, 
#nullable restore
#line 21 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                              () => changePassword.NewPassword

#line default
#line hidden
#nullable disable
                , 48, "color: red");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-sm-4 mt-3");
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(54);
                __builder2.AddAttribute(55, "CssClass", "e-outline");
                __builder2.AddAttribute(56, "Placeholder", "Confirm Password");
                __builder2.AddAttribute(57, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 24 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                                          Syncfusion.Blazor.Inputs.InputType.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 25 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                                             FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                            changePassword.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changePassword.ConfirmPassword = __value, changePassword.ConfirmPassword))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => changePassword.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __Blazor.uttarakhand_project_front.Pages.Account.ChangePassword.TypeInference.CreateValidationMessage_2(__builder2, 63, 64, 
#nullable restore
#line 26 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                              () => changePassword.ConfirmPassword

#line default
#line hidden
#nullable disable
                , 65, "color: red");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-sm-12 mt-3 text-left");
                __builder2.AddMarkupContent(70, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(71);
                __builder2.AddAttribute(72, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(74, "<i class=\"fas fa-plus-circle\"></i>&nbsp;Change Password");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                    &nbsp;");
                __builder2.OpenElement(76, "img");
                __builder2.AddAttribute(77, "src", "Images/BlockLoader.gif");
                __builder2.AddAttribute(78, "alt", "Loader");
                __builder2.AddAttribute(79, "style", "height:" + " 30px;" + " width:" + " 30px;" + " display:" + " " + (
#nullable restore
#line 31 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                                                                           Loader

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(86);
            __builder.AddAttribute(87, "ID", "toast_type");
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(90);
                __builder2.AddAttribute(91, "X", "Right");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(93, (__value) => {
#nullable restore
#line 38 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
                ToastChnagePassObj = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Account\ChangePassword.razor"
       
    SfToast ToastChnagePassObj;
    public ChangePasswordRazorModel changePassword { get; set; }
    public string Loader { get; set; }

    protected override void OnInitialized()
    {
        changePassword = new ChangePasswordRazorModel();
        Loader = "none";
    }

    async Task ChangeUserPassword()
    {
        Loader = "inline";
        if (changePassword != null)
        {
            var authUser = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = await UserManager.GetUserAsync(authUser.User);
            if (user != null)
            {
                changePassword.userId = user.Id;
                var result = await UserService.ChangeUserPasswordAsync(changePassword);
                if (result == "success")
                {
                    Loader = "none";
                    await ToastChnagePassObj.Show(new ToastModel {Title = "Success!", Content = "Password has been changed successfully.", CssClass = "e-toast-success", Icon = "e-success toast-icons"});
                    NavigationManager.NavigateTo("/", true);
                }
                else
                {
                    Loader = "none";
                    changePassword = new ChangePasswordRazorModel();
                    await ToastChnagePassObj.Show(new ToastModel {Title = "Error!", Content = "Something goes wrong, please try again after sometime!", CssClass = "e-toast-danger", Icon = "e-error toast-icons"});
                }
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
namespace __Blazor.uttarakhand_project_front.Pages.Account.ChangePassword
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
