using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ProtectedBrowserStorage;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Notifications;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using uttarakhand_project_front.ViewModels;

namespace uttarakhand_project_front.Pages
{
    public class RegistrationEntranceFormBase : ComponentBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly HttpClient _httpClient;
        private readonly DapperService dapperService;
        public IPaymentService _paymentService { get; }
        public ICenterService CenterService { get; }
        public ProtectedSessionStorage ProtectedSessionStorage { get; }
        public UserManager<ApplicationUser> UserManager { get; }
        public IJSRuntime Js { get; }

        public RegistrationEntranceFormBase()
        {
            
        }

        public RegistrationEntranceFormBase(IWebHostEnvironment hostingEnvironment, ICenterService centerService, 
            ProtectedSessionStorage protectedSessionStorage, UserManager<ApplicationUser> userManager, HttpClient httpClient, 
            IJSRuntime js, DapperService dapperService, IPaymentService paymentService )
        {
            _paymentService = paymentService;
            _hostingEnvironment = hostingEnvironment;
            _httpClient = httpClient;
            CenterService = centerService;
            ProtectedSessionStorage = protectedSessionStorage;
            UserManager = userManager;
            Js = js;
            this.dapperService = dapperService;
        }
        
        protected SfToast ToastObjRegistration;
        [CascadingParameter] public Task<AuthenticationState> authenticationStateTask { get; set; }
        [Parameter] public string ShowOptions { get; set; }
        public bool IsM_Ed { get; set; } = false;
        public string HeadingText { get; set; }
        public RegistrationViewModel model { get; set; }
        public string Loader { get; set; }
        public string NewLoader { get; set; }
        public List<string> ExamCenterList { get; set; }
        public List<string> GroupList { get; set; }
        public List<string> MaritalStatusList { get; set; }
        public List<string> NationalityList { get; set; }
        public List<string> DomicileUksList { get; set; }
        public List<string> CategoryList { get; set; }
        public List<string> FreedomFightersList { get; set; }
        public List<string> DefencePersonalList { get; set; }
        public List<string> PhysicallyChallengesList { get; set; }
        public List<string> PhysicallyChallengesTypeList { get; set; }
        public List<string> GendersList { get; set; }
        public List<string> PunishedByCourtList { get; set; }
        public List<string> DabarredCollegeList { get; set; }
        public List<string> StateList { get; set; }
        public List<string> StreamList { get; set; }
        public List<string> CoursesList { get; set; }
        public List<string> PassingYearList { get; set; }
        public List<string> EWS { get; set; } // Economicallly Weaker Section (EWS)
        public List<string> M_EdGraducationRequired { get; set; }
        public bool GraducationReadonly { get; set; } = false;
        public bool PostGraducationReadonly { get; set; } = false;
        public bool IsPhysically { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            Loader = "none";
            NewLoader = "none";
            model = new RegistrationViewModel();
            model.Year = DateTime.Now.Year.ToString();
            model.GradutionName = "Graduation";
            model.PostGradutionName = "Post Graduation";
            if (ShowOptions == "B_Ed")
            {
                model.CourseName = "Bachelor of Education";
                IsM_Ed = false;
                HeadingText = "B.Ed";
            }
            else
            {
                model.CourseName = "Master of Education";
                IsM_Ed = true;
                model.GradutionName = "Bachelor of Education";
                HeadingText = "M.Ed";
            }

            // To get Email and Mobile Number from DB.
            var authState = await authenticationStateTask;
            var user = await UserManager.GetUserAsync(authState.User);
            if (user != null)
            {
                model.EmailAddress = user.Email;
                model.MobileNo = user.PhoneNumber;
            }

            DomicileUksList = new List<string>();
            FreedomFightersList = new List<string>();
            DefencePersonalList = new List<string>();
            PhysicallyChallengesList = new List<string>();
            PunishedByCourtList = new List<string>();
            DabarredCollegeList = new List<string>();
            ExamCenterList = new List<string>();
            GroupList = new List<string>();
            MaritalStatusList = new List<string>();
            NationalityList = new List<string>();
            CategoryList = new List<string>();
            PhysicallyChallengesTypeList = new List<string>();
            GendersList = new List<string>();
            StreamList = new List<string>();
            CoursesList = new List<string>();
            PassingYearList = new List<string>();
            StateList = new List<string>();
            EWS = new List<string>();
            M_EdGraducationRequired = new List<string>();
            await LoadDropDownData();

            await ProtectedSessionStorage.SetAsync("gradu", true);
        }

        async Task LoadDropDownData()
        {
            List<string> liYeaNo = new List<string>();
            liYeaNo.Add("Yes");
            liYeaNo.Add("No");

            DomicileUksList = liYeaNo;
            FreedomFightersList = liYeaNo;
            DefencePersonalList = liYeaNo;
            PhysicallyChallengesList = liYeaNo;
            PunishedByCourtList = liYeaNo;
            DabarredCollegeList = liYeaNo;
            EWS = liYeaNo;

            ExamCenterList.Add("Almora");
            ExamCenterList.Add("Bageshwar");
            ExamCenterList.Add("Haldwani");
            ExamCenterList.Add("Kashipur");
            ExamCenterList.Add("Nainital");
            ExamCenterList.Add("Pithoragarh");
            ExamCenterList.Add("Ram Nagar");
            ExamCenterList.Add("Rudrapur");
            ExamCenterList.Add("Ranikhet");
            ExamCenterList.Add("Khatima");
            ExamCenterList.Add("Dwarahat");
            ExamCenterList.Add("Lohaghat");
            ExamCenterList.Add("Kichha");
            ExamCenterList.Add("Berinag");

            GroupList.Add("Arts");
            GroupList.Add("Commerce");
            GroupList.Add("Science");

            MaritalStatusList.Add("Single");
            MaritalStatusList.Add("Married");

            NationalityList.Add("Indian");
            NationalityList.Add("Others");

            CategoryList.Add("Unreserved General");
            CategoryList.Add("Schedule Cast (SC)");
            CategoryList.Add("Schedule Tribe (ST)");
            CategoryList.Add("Other Backward Class (OBC) - Creamy");
            CategoryList.Add("Other Backward Class (OBC) - Non Creamy");

            PhysicallyChallengesTypeList.Add("Physically Challenged");
            PhysicallyChallengesTypeList.Add("Visually Challenged");
            PhysicallyChallengesTypeList.Add("None");

            GendersList.Add("Male");
            GendersList.Add("Female");
            GendersList.Add("Transgender");

            StreamList.Add("Humanities/Arts");
            StreamList.Add("Commerce");
            StreamList.Add("Science");

            CoursesList.Add("Bachelor of Education");
            CoursesList.Add("Master of Education");

            PassingYearList.Add("Appearing");
            PassingYearList.Add("2020");
            PassingYearList.Add("2019");
            PassingYearList.Add("2018");
            PassingYearList.Add("2017");
            PassingYearList.Add("2016");
            PassingYearList.Add("2015");
            PassingYearList.Add("2014");
            PassingYearList.Add("2013");
            PassingYearList.Add("2012");
            PassingYearList.Add("2011");
            PassingYearList.Add("2010");

            M_EdGraducationRequired.Add("B.Ed. Theory");
            M_EdGraducationRequired.Add("B.T. Theory");
            M_EdGraducationRequired.Add("L.T. Theory");
            M_EdGraducationRequired.Add("B.EI.Ed. Theory");
            M_EdGraducationRequired.Add("D.EI.Ed. Theory");
            M_EdGraducationRequired.Add("B.A B.Ed. Theory");
            M_EdGraducationRequired.Add("B.Sc. B.Ed. Theory");

            var response = await _httpClient.GetAsync("https://api.covidindiatracker.com/state_data.json");
            if (response.IsSuccessStatusCode)
            {
                var result =
                    Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<StateData>>(
                        await response.Content.ReadAsStringAsync());
                foreach (var state in result)
                {
                    StateList.Add(state.state);
                }
            }
        }

        protected void PassingYearGraduChangeEvent(string value)
        {
            if (value.ToUpper() == "Appearing".ToUpper())
            {
                GraducationReadonly = true;
                model.GradutionMaxMarks = "0";
                model.GradutionObtMarks = "0";
                model.GradutionPercentageMarks = "0";
            }
            else
            {
                GraducationReadonly = false;
                model.GradutionMaxMarks = "";
                model.GradutionObtMarks = "";
                model.GradutionPercentageMarks = "";
            }
        }

        protected void PassingYearPostGraduChangeEvent(string value)
        {
            if (value.ToUpper() == "Appearing".ToUpper())
            {
                PostGraducationReadonly = true;
                model.PGradutionMaxMarks = "0";
                model.PGradutionObtMarks = "0";
                model.PGradutionPercentageMarks = "0";
            }
            else
            {
                PostGraducationReadonly = false;
                model.PGradutionMaxMarks = "";
                model.PGradutionObtMarks = "";
                model.PGradutionPercentageMarks = "";
            }
        }

        protected async Task GraduationPercentageCalc()
        {
            if (model.GradutionObtMarks != "")
            {
                if (model.GradutionMaxMarks != "")
                {
                    double percentage = Convert.ToDouble((Convert.ToInt32(model.GradutionObtMarks) * 100) /
                                                         Convert.ToInt32(model.GradutionMaxMarks));
                    model.GradutionPercentageMarks = percentage.ToString();
                    if (model.Category.ToLower() == "Unreserved General".ToLower())
                    {
                        if (percentage > 50)
                        {
                            await ProtectedSessionStorage.SetAsync("gradu", true);
                        }
                        else
                        {
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Error!",
                                Content = "You are not eligible!",
                                CssClass = "e-toast-danger",
                                Icon = "e-error toast-icons"
                            });
                            await ProtectedSessionStorage.SetAsync("gradu", false);
                        }
                    }
                    else
                    {
                        if (percentage > 45)
                        {
                            await ProtectedSessionStorage.SetAsync("gradu", true);
                        }
                        else
                        {
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Error!",
                                Content = "You are not eligible!",
                                CssClass = "e-toast-danger",
                                Icon = "e-error toast-icons"
                            });
                            await ProtectedSessionStorage.SetAsync("gradu", false);
                        }
                    }
                }
                else
                {
                    await ToastObjRegistration.Show(new ToastModel
                    {
                        Title = "Error!",
                        Content = "Please fill graduation maximum marks!",
                        CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                }
            }
            else
            {
                await ToastObjRegistration.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "Please fill graduation obtained marks!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
            }
        }

        protected async Task PostGraduationPercentageCalc()
        {
            if (model.PGradutionObtMarks != "")
            {
                if (model.PGradutionMaxMarks != "")
                {
                    double percentage = Convert.ToDouble((Convert.ToInt32(model.PGradutionObtMarks) * 100) /
                                                         Convert.ToInt32(model.PGradutionMaxMarks));
                    model.PGradutionPercentageMarks = percentage.ToString();
                }
                else
                {
                    await ToastObjRegistration.Show(new ToastModel
                    {
                        Title = "Error!",
                        Content = "Please fill post graduation maximum marks!",
                        CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                }
            }
            else
            {
                await ToastObjRegistration.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "Please fill post graduation maximum marks!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
            }
        }

        protected async Task UploadPhotoAsync(UploadChangeEventArgs args)
        {
            if (args.Files.Any())
            {
                try
                {
                    var file = args.Files.FirstOrDefault();
                    if (file != null)
                    {
                        if (file.FileInfo.Size < 1000 || file.FileInfo.Size > 200000)
                        {
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Error!", Content = "Please upload file in betwen 1 kB to 200 KB!",
                                CssClass = "e-toast-danger", Icon = "e-error toast-icons"
                            });
                        }
                        else
                        {
                            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileInfo.Name;
                            await ProtectedSessionStorage.SetAsync("UniquePhotoName", uniqueFileName);
                            model.PhohoFile = file;
                        }
                    }
                    else
                    {
                        await ToastObjRegistration.Show(new ToastModel
                        {
                            Title = "Error!", Content = "Please upload the file!", CssClass = "e-toast-danger",
                            Icon = "e-error toast-icons"
                        });
                    }
                }
                catch (Exception ex)
                {
                    await ToastObjRegistration.Show(new ToastModel
                    {
                        Title = "Error!", Content = ex.Message, CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                }
            }
        }

        protected async Task UploadSignatureAsync(UploadChangeEventArgs args)
        {
            if (args.Files.Any())
            {
                try
                {
                    var file = args.Files.FirstOrDefault();
                    if (file != null)
                    {
                        if (file.FileInfo.Size < 1000 || file.FileInfo.Size > 200000)
                        {
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Error!", Content = "Please upload file in betwen 1 kB to 200 KB!",
                                CssClass = "e-toast-danger", Icon = "e-error toast-icons"
                            });
                        }
                        else
                        {
                            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileInfo.Name;
                            await ProtectedSessionStorage.SetAsync("UniqueSignatureName", uniqueFileName);
                            model.SignatureFile = file;
                        }
                    }
                    else
                    {
                        await ToastObjRegistration.Show(new ToastModel
                        {
                            Title = "Error!", Content = "Please upload the file!", CssClass = "e-toast-danger",
                            Icon = "e-error toast-icons"
                        });
                    }
                }
                catch (Exception ex)
                {
                    await ToastObjRegistration.Show(new ToastModel
                    {
                        Title = "Error!", Content = ex.Message, CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                }
            }
        }

        protected async Task IsRegistrationConfirmAsync(EditContext editContext)
        {
            Loader = "inline";
            StateHasChanged();
            var IsValid = editContext.Validate();
            if (IsValid)
            {
                var authState = await authenticationStateTask;
                var user = await UserManager.GetUserAsync(authState.User);
                var allRegistrationData = await dapperService.GetAllRegistrationDetailsAsync();
                var checkPreviousRegistration = allRegistrationData.Count(w => w.UserId == user.Id);
                if (checkPreviousRegistration <= 0)
                {
                    Loader = "none";
                    await Js.ShowModel("modalConfirmDelete");
                }
                else
                {
                    Loader = "none";
                    await ToastObjRegistration.Show(new ToastModel
                    {
                        Title = "Error!", Content = "You have already submitted your form!",
                        CssClass = "e-toast-danger", Icon = "e-error toast-icons"
                    });
                }
            }
            else
            {
                Loader = "none";
            }
        }

        protected async Task RegisterNewFormAsync()
        {
            NewLoader = "inline";
            StateHasChanged();
            try
            {
                var changeEventValue = await ProtectedSessionStorage.GetAsync<bool>("gradu");
                if (changeEventValue)
                {
                    var UniqueSignatureName = await ProtectedSessionStorage.GetAsync<string>("UniqueSignatureName");
                    var UniquePhotoName = await ProtectedSessionStorage.GetAsync<string>("UniquePhotoName");
                    if (!string.IsNullOrEmpty(UniqueSignatureName) && !string.IsNullOrEmpty(UniqueSignatureName))
                    {
                        var authState = await authenticationStateTask;
                        var user = await UserManager.GetUserAsync(authState.User);
                        //model.UniqueKey = Guid.NewGuid().ToString().GetHashCode().ToString("x");
                        model.UserId = user.Id;
                        var result = await CenterService.InsertRegistrationFormDataAsync(model);
                        if (result == "success")
                        {
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Success!",
                                Content = "You have submitted your registration form successfully.",
                                CssClass = "e-toast-success",
                                Icon = "e-success toast-icons"
                            });
                            model = new RegistrationViewModel();
                            NewLoader = "none";
                            model.Year = DateTime.Now.Year.ToString();
                            await ProtectedSessionStorage.SetAsync("gradu", true);
                            model.GradutionName = "Graduation";
                            model.PostGradutionName = "Post Graduation";
                            await Js.CloseModel("modalConfirmDelete");
                        }
                        else if (result == "failure")
                        {
                            NewLoader = "none";
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Error!",
                                Content = "You are sending bad request, please try again later!",
                                CssClass = "e-toast-danger",
                                Icon = "e-error toast-icons"
                            });
                            await Js.CloseModel("modalConfirmDelete");
                        }
                        else
                        {
                            NewLoader = "none";
                            await ToastObjRegistration.Show(new ToastModel
                            {
                                Title = "Error!",
                                Content = result,
                                CssClass = "e-toast-danger",
                                Icon = "e-error toast-icons"
                            });
                            await Js.CloseModel("modalConfirmDelete");
                        }
                    }
                    else
                    {
                        NewLoader = "none";
                        await ToastObjRegistration.Show(new ToastModel
                        {
                            Title = "Error!",
                            Content = "Please upload both files then try again!",
                            CssClass = "e-toast-danger",
                            Icon = "e-error toast-icons"
                        });
                        await Js.CloseModel("modalConfirmDelete");
                    }
                }
                else
                {
                    NewLoader = "none";
                    await ToastObjRegistration.Show(new ToastModel
                    {
                        Title = "Error!",
                        Content = "You are not eligible!",
                        CssClass = "e-toast-danger",
                        Icon = "e-error toast-icons"
                    });
                    await Js.CloseModel("modalConfirmDelete");
                }
            }
            catch (Exception ex)
            {
                NewLoader = "none";
                await ToastObjRegistration.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = ex.Message,
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
                await Js.CloseModel("modalConfirmDelete");
            }
        }

        protected void IsPysicallyChallenge(string value)
        {
            if (value == "No")
            {
                IsPhysically = true;
                model.PhysicallyChallengedType = "None";
            }
            else
            {
                IsPhysically = false;
                model.PhysicallyChallengedType = null;
            }
        }

        protected async Task CheckCrimicalRecord(string value)
        {
            if (value == "Yes")
            {
                await ToastObjRegistration.Show(new ToastModel
                {
                    Title = "Error!",
                    Content = "You are not eligible!",
                    CssClass = "e-toast-danger",
                    Icon = "e-error toast-icons"
                });
                await ProtectedSessionStorage.SetAsync("gradu", false);
            }
            else
                await ProtectedSessionStorage.SetAsync("gradu", true);
        }
    }
}