#pragma checksum "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4654ea6821ff6f5848e72b1e530e5d01585ab030"
// <auto-generated/>
#pragma warning disable 1591
namespace uttarakhand_project_front.Pages.Admin
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
#line 3 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAllApplication")]
    public partial class ViewAllApplication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n    <h1 class=\"h3 mb-0 text-gray-800\">All Application Details</h1>\r\n</div>\r\n\r\n");
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
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 13 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                 if (registrationList != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                     if (registrationList.Any())
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                        ");
            __Blazor.uttarakhand_project_front.Pages.Admin.ViewAllApplication.TypeInference.CreateSfGrid_0(__builder, 14, 15, 
#nullable restore
#line 17 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                             registrationList

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 17 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 17 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                             new List<string>() { "Search", "Print" }

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 18 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                             true

#line default
#line hidden
#nullable disable
            , 19, (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(21);
                __builder2.AddAttribute(22, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                         10

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(27);
                    __builder3.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.SerialNo)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "HeaderText", "Id");
                    __builder3.AddAttribute(30, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 21 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                            TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Width", "50");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(33);
                    __builder3.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.RefNo)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "HeaderText", "Ref. No");
                    __builder3.AddAttribute(36, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 22 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                              TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(39);
                    __builder3.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "HeaderText", "Name");
                    __builder3.AddAttribute(42, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 23 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                          TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(45);
                    __builder3.AddAttribute(46, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.Dob)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "HeaderText", "Dob");
                    __builder3.AddAttribute(48, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 24 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Width", "120");
                    __builder3.AddAttribute(50, "Format", "dd/MM/yyyy");
                    __builder3.AddAttribute(51, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 24 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                                                                                ColumnType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(53);
                    __builder3.AddAttribute(54, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.Year)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "HeaderText", "Year");
                    __builder3.AddAttribute(56, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 25 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                          TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Width", "60");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(59);
                    __builder3.AddAttribute(60, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.ExamCenter)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "HeaderText", "Exam Center");
                    __builder3.AddAttribute(62, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 26 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                                  ColumnType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 26 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                                                               TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(66);
                    __builder3.AddAttribute(67, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.CourseName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "HeaderText", "Course Name");
                    __builder3.AddAttribute(69, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 27 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(72);
                    __builder3.AddAttribute(73, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                   nameof(ViewAllApplicationViewModel.IsPaymentDone)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "HeaderText", "Payment Status");
                    __builder3.AddAttribute(75, "Width", "100");
                    __builder3.AddAttribute(76, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 28 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                                                                                                         TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(78);
                    __builder3.AddAttribute(79, "HeaderText", "Action");
                    __builder3.AddAttribute(80, "Width", "200");
                    __builder3.AddAttribute(81, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(82, "\r\n");
#nullable restore
#line 31 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                          
                                            var registrationData = (context as ViewAllApplicationViewModel);
                                        

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(83, "                                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(84);
                        __builder4.AddAttribute(85, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                              e => ViewApplication(registrationData.RefNo)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(88, "<i class=\"fas fa-eye\"></i>&nbsp;View");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(89, "\r\n                                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(90);
                        __builder4.AddAttribute(91, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(92, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                                                                              e => EditApplication(registrationData.RefNo)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(94, "<i class=\"fas fa-edit\"></i>&nbsp;Edit");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\r\n                                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                        ");
            }
            );
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 40 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "                        ");
            __builder.AddMarkupContent(100, "<label>No data available.</label>\r\n");
#nullable restore
#line 44 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Deepanshu Projects\KuEntranceProject\uttarakhand-project-front\Pages\Admin\ViewAllApplication.razor"
 
    public IEnumerable<ViewAllApplicationViewModel> registrationList { get; set; }
    [CascadingParameter]
    public Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        registrationList = new List<ViewAllApplicationViewModel>();
        await LoadApplications();
    }

    async Task LoadApplications()
    {
        var allList = await dapperService.GetAllRegistrationDetailsAsync();
        int counter = 0;
        List<ViewAllApplicationViewModel> liList = new List<ViewAllApplicationViewModel>();
        foreach (var item in allList)
        {
            var model = new ViewAllApplicationViewModel()
            {
                SerialNo = ++counter,
                Name = item.Name,
                RefNo = item.RefNo,
                Dob = item.Dob.Value,
                CourseName = item.CourseName,
                ExamCenter = item.ExamCenter,
                IsPaymentDone = item.IsPaymentDone,
                Year = item.Year
            };

            if (model.IsPaymentDone == "Yes")
                model.IsPaymentDone = "Payment Done";
            else
                model.IsPaymentDone = "Payment Pending";

            liList.Add(model);
        }

        registrationList = liList;
    }

    async Task ViewApplication(string refNo)
    {
        var authState = await authenticationStateTask;
        var user = await UserManager.GetUserAsync(authState.User);
        if (user != null)
        {
            NavigationManager.NavigateTo($"ViewApplication/{refNo}/{user.Id}", true);
        }
    }

    void EditApplication(string refNo)
    {
        NavigationManager.NavigateTo($"EditRegistration/{refNo}", true);
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
namespace __Blazor.uttarakhand_project_front.Pages.Admin.ViewAllApplication
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "Toolbar", __arg2);
        __builder.AddAttribute(__seq3, "EnableHover", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591