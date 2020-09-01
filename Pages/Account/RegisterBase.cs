using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Notifications;
using uttarakhand_project_front.Auth;
using uttarakhand_project_front.Services;
using uttarakhand_project_front.ViewModels;

namespace uttarakhand_project_front.Pages.Account
{
    public class RegisterBase : ComponentBase
    {
        public RegisterBase()
        {
            
        }

        public RegisterBase(UserService userService, ILoginService loginService, NavigationManager navigationManager, 
            ICenterService centerService, IJSRuntime jsRuntime)
        {
            this.userService = userService;
            this.loginService = loginService;
            this.navigationManager = navigationManager;
            this.centerService = centerService;
            this.jsRuntime = jsRuntime;
        }


        public SfToast ToastObjRegister;
        public DateTime dobData { get; set; } = DateTime.Now;
        public RegisterViewModel registerModel { get; set; }
        private bool UniqueMobile = true;
        private bool UniqueEmail = true;
        public bool IsEnable { get; set; } = false;
        public string UserOtp { get; set; }
        public TimeSpan TimerMessage = new TimeSpan();
        public readonly UserService userService;
        public readonly ILoginService loginService;
        public readonly NavigationManager navigationManager;
        public readonly ICenterService centerService;
        public readonly IJSRuntime jsRuntime;

        public bool IsStop { get; set; } = false;

        public string Loader { get; set; }
        public string OtpLoader { get; set; }

        protected override void OnInitialized()
        {
            registerModel = new RegisterViewModel();
            UserOtp = string.Empty;
            Loader = "none";
            OtpLoader = "none";
        }

        protected async Task CreateUserAsync()
        {
            Loader = "inline";
            IsEnable = true;
            StateHasChanged();
            if (UniqueMobile)
            {
                if (UniqueEmail)
                {
                    if (!string.IsNullOrEmpty(UserOtp))
                    {
                        var userToken = await userService.CreateUserAsync(registerModel);
                        if (userToken.Status.ToLower() == "success")
                        {
                            await loginService.Login(userToken.Token);
                            Loader = "none";
                            IsEnable = false;
                            navigationManager.NavigateTo("/", true);
                        }
                        else
                        {
                            await ToastObjRegister.Show(new ToastModel
                            {
                                Title = "Error!",
                                Content = "You are not send proper request, please try again!",
                                CssClass = "e-toast-danger",
                                Icon = "e-error toast-icons"
                            });
                            Loader = "none";
                            IsEnable = false;
                        }
                    }
                    else
                    {
                        await ToastObjRegister.Show(new ToastModel
                        {
                            Title = "Error!",
                            Content = "You are not send proper request, please try again!",
                            CssClass = "e-toast-danger",
                            Icon = "e-error toast-icons"
                        });
                        Loader = "none";
                        IsEnable = false;
                    }
                }
                else
                {
                    await ToastObjRegister.Show(new ToastModel
                    {
                        Title = "Error!",
                        Content = "Email address should be unique!",
                        CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                    Loader = "none";
                    IsEnable = false;
                    navigationManager.NavigateTo("Register", true);
                }
            }
            else
            {
                await ToastObjRegister.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "Mobile number should be unique!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
                Loader = "none";
                IsEnable = false;
                navigationManager.NavigateTo("Register", true);
            }
        }

        protected async Task CheckMobileAsync(string mobileNumber)
        {
            string mobile = await centerService.CheckMobileDuplicacyAsync(mobileNumber);
            if (mobile.ToLower() != "notfound")
            {
                await ToastObjRegister.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "Mobile number should be unique, please enter unique number!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
                UniqueMobile = false;
            }
        }

        protected async Task CheckEmailAsync(string emailAddress)
        {
            string email = await centerService.CheckEmailDuplicacyAsync(emailAddress);
            if (email.ToLower() != "notfound")
            {
                await ToastObjRegister.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "Email address should be unique, please enter unique email!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
                UniqueEmail = false;
            }
        }

        protected async Task ShowOptBox()
        {
            OtpLoader = "inline";
            StateHasChanged();
            if (UniqueMobile)
            {
                if (UniqueEmail)
                {
                    Loader = "none";
                    //await StartTimer();
                    await jsRuntime.InvokeVoidAsync("global.openModal", "modalOtp");
                }
                else
                {
                    await ToastObjRegister.Show(new ToastModel
                    {
                        Title = "Error!",
                        Content = "Email address should be unique!",
                        CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                    Loader = "none";
                    navigationManager.NavigateTo("Register", true);
                }
            }
            else
            {
                await ToastObjRegister.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "Mobile number should be unique!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
                Loader = "none";
                IsEnable = false;
                navigationManager.NavigateTo("Register", true);
            }
        }

        async Task StartTimer()
        {
            IsStop = true;
            while (IsStop)
            {
                await Task.Delay(1000);
                if (IsStop)
                {
                    TimerMessage = TimerMessage.Add(new TimeSpan(0, 0, 1));
                    StateHasChanged();
                }
            }
        }
    }
}