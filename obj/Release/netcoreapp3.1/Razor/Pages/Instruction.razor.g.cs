#pragma checksum "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9367c2cad84f7352517f428fb7b216967ff43fc0"
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
#line 3 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
           [Authorize(Roles = "User")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Instruction/{PdfShowOptions}")]
    public partial class Instruction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n    <h1 class=\"h3 mb-0 text-gray-800\">Form Instruction</h1>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card border-left-primary shadow h-100 py-2");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-12 mb-2");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.PdfViewerServer.SfPdfViewerServer>(13);
            __builder.AddAttribute(14, "DocumentPath", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                                  DocumentPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Height", "500px");
            __builder.AddAttribute(16, "Width", "100%");
            __builder.AddAttribute(17, "EnableToolbar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                                                                                           false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm-12 mb-2 text-center");
            __builder.AddMarkupContent(22, "\r\n                ");
            __Blazor.uttarakhand_project_front.Pages.Instruction.TypeInference.CreateSfCheckBox_0(__builder, 23, 24, 
#nullable restore
#line 17 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                                                $"I have read all the instructions carefully and accept the terms and conditions of {IsM_EdOrB_Ed} Entrance Examination."

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 17 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                            isChecked

#line default
#line hidden
#nullable disable
            , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => isChecked = __value, isChecked)), 27, () => isChecked);
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-12 mb-2 text-center");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(33);
            __builder.AddAttribute(34, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                                     AgreedToSend

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "<i class=\"fas fa-check-circle\"></i>&nbsp;Agree");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                &nbsp;");
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "src", "Images/BlockLoader.gif");
            __builder.AddAttribute(41, "alt", "Loader");
            __builder.AddAttribute(42, "style", "height:" + " 30px;" + " width:" + " 30px;" + " display:" + " " + (
#nullable restore
#line 22 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                                                                Loader

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(48);
            __builder.AddAttribute(49, "ID", "toast_type");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(52);
                __builder2.AddAttribute(53, "X", "Right");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(55, (__value) => {
#nullable restore
#line 28 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
                ToastObjInstruction = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Instruction.razor"
      
    [CascadingParameter]
    public Task<AuthenticationState> authenticationStateTask { get; set; }
    SfToast ToastObjInstruction;
    [Parameter]
    public string PdfShowOptions { get; set; }
    public bool isChecked { get; set; }
    private string DocumentPath { get; set; }
    public string Loader { get; set; }
    public string IsM_EdOrB_Ed { get; set; }  

    protected override void OnInitialized()
    {
        Loader = "none";
        if (PdfShowOptions == "B_Ed")
        {
            IsM_EdOrB_Ed = "B.Ed";
            DocumentPath = "wwwroot/UploadDocs/B_EdFormInstructions.pdf";
        }
        else if (PdfShowOptions == "M_Ed")
        {
            IsM_EdOrB_Ed = "M.Ed";
            DocumentPath = "wwwroot/UploadDocs/M_EdFormInstructions.pdf";
        }
        else
        {
            NavigationManager.NavigateTo("/", true);
        }
    }

    async Task AgreedToSend()
    {
        Loader = "inline";
        StateHasChanged();
        if (isChecked)
        {
            var refNo = await CheckPaymentStatus();
            if (!string.IsNullOrEmpty(refNo))
            {
                NavigationManager.NavigateTo($"ViewApplication/{refNo}", true);
            }
            else
            {
                NavigationManager.NavigateTo($"RegistrationForm/{PdfShowOptions}", true);
            }
        }
        else
        {
            await ToastObjInstruction.Show(new ToastModel
            {
                Title = "Error!",
                Content = "Please agree all the terms & condition first!",
                CssClass = "e-toast-danger",
                Icon = "e-error toast-icons"
            });
            Loader = "none";
        }
    }

    async Task<string> CheckPaymentStatus()
    {
        string result = string.Empty;
        var authState = await authenticationStateTask;
        var user = await UserManager.GetUserAsync(authState.User);
        if (user != null)
        {
            var infoDetails = await CenterService.GetRegistrationDetailsByUserIdAsync(user.Id);
            if (infoDetails != null)
            {
                var payStatus = await dapperService.CheckPaymentPaidAgainstRefNo(infoDetails.RefNo);
                if (payStatus != null)
                {
                    result = payStatus.RefNo;
                    return result;
                }
            }
        }

        return result;
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
namespace __Blazor.uttarakhand_project_front.Pages.Instruction
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfCheckBox_0<TChecked>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TChecked __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TChecked> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TChecked>> __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Buttons.SfCheckBox<TChecked>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Checked", __arg1);
        __builder.AddAttribute(__seq2, "CheckedChanged", __arg2);
        __builder.AddAttribute(__seq3, "CheckedExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
