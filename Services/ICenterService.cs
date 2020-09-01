using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.Inputs.Internal;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.ViewModels;

namespace uttarakhand_project_front.Services
{
    public interface ICenterService
    {
        Task<string> CheckMobileDuplicacyAsync(string mobile);

        Task<string> CheckEmailDuplicacyAsync(string email);

        void UploadImageFiles(UploadFiles file, string FolderName, string UniqueFileName);

        Task<string> InsertRegistrationFormDataAsync(RegistrationViewModel model);

        Task<string> GenerateUniqueRefNo(string courseName = "Bachelor of Education");

        Task<RegistrationViewModel> GetRegistrationDetailsByUserIdAsync(string Id);
        
        Task<RegistrationViewModel> GetRegistrationDetailsByRefIdAsync(string Id);

        int CalculateYourAge(DateTime dob);

        string GenerateOtp();

        Task<string> SendSmsAsync(string mobileNo, string msg, string email, string otp = null, string sentFlag = null);

        void UploadImagesInTemp(UploadFiles file, string UniqueFileName);

        void DeleteTempFiles(string fileName);

        Task<string> UpdateRegistrationDetailsAsync(RegistrationViewModel model, bool photoFlag, bool signatureFlag);

        Task<string> SendSmsAsync(string mobileNo, string msg);
    }
}
