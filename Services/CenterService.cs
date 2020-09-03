using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uttarakhand_project_front.Data;
using uttarakhand_project_front.ViewModels;
using uttarakhand_project_front.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Syncfusion.Blazor.Inputs.Internal;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Net.Http;
using BlazorInputFile;
using System.IO.Pipelines;

namespace uttarakhand_project_front.Services
{
    public class CenterService : ICenterService
    {
        private readonly FrontAppDbContext dbContext;
        private readonly DapperService dapperService;
        private readonly HttpClient httpClient;

        private IWebHostEnvironment hostingEnvironment { get; }

        public CenterService(FrontAppDbContext dbContext, IWebHostEnvironment hostingEnvironment, DapperService dapperService, HttpClient httpClient)
        {
            this.dbContext = dbContext;
            this.hostingEnvironment = hostingEnvironment;
            this.dapperService = dapperService;
            this.httpClient = httpClient;
        }

        public async Task<string> CheckEmailDuplicacyAsync(string emailAddress)
        {
            string email = string.Empty;
            try
            {
                //var result = await dbContext.Users.FirstOrDefaultAsync(f => f.Email.ToLower() == emailAddress.ToLower());
                var result = await dapperService.CheckEmailDuplicacyAsync(emailAddress);
                if (result != null)
                {
                    email = result.Email;
                }

                if (string.IsNullOrEmpty(email))
                {
                    email = "NotFound";
                }
            }
            catch (Exception)
            {

                email = "NotFound";
            }
            return email;
        }

        public async Task<string> CheckMobileDuplicacyAsync(string mobileNumber)
        {
            string mobile = string.Empty;
            try
            {
                //var result = await dbContext.Users.FirstOrDefaultAsync(f => f.PhoneNumber == mobileNumber);
                var result = await dapperService.CheckMobileDuplicacyAsync(mobileNumber);
                if (result != null)
                {
                    mobile = result.PhoneNumber;
                }

                if (string.IsNullOrEmpty(mobile))
                {
                    mobile = "NotFound";
                }
            }
            catch (Exception)
            {

                mobile = "NotFound";
            }
            return mobile;
        }

        public void UploadImageFiles(UploadFiles file, string FolderName, string UniqueFileName)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "upload", "uploadku", FolderName);
            if (Directory.Exists(uploadsFolder))
            {
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    file.Stream.WriteTo(fileStream);
                }   
            }
            else
            {
                Directory.CreateDirectory(uploadsFolder);
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    file.Stream.WriteTo(fileStream);
                }
            }
        }
        
        public async Task UploadImageFilesUsingInput(IFileListEntry file, string FolderName, string UniqueFileName)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "upload", "uploadku", FolderName);
            if (Directory.Exists(uploadsFolder))
            {
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                var ms = new MemoryStream();
                file.Data.CopyTo(ms);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fileStream);
                }
            }
            else
            {
                Directory.CreateDirectory(uploadsFolder);
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fileStream);
                }
            }
        }

        public async Task<string> GenerateUniqueRefNo(string courseName)
        {
            string refNo = string.Empty;
            try
            {
                string query = string.Empty;
                if (courseName == "B.Ed")
                {
                    query = @"select '777' + (select RIGHT( '000000' + CONVERT(VARCHAR(6), isnull(max(RIGHT(left(LTRIM(Str(refno, 9, 5)),11),5)),0)+1),5) as maxno ) as ReferenceNo
                                    From RegistrationMaster where CourseName='B.Ed'";
                }
                else if (courseName == "M.Ed")
                {
                    query = @"select '888' + (select RIGHT( '000000' + CONVERT(VARCHAR(6), isnull(max(RIGHT(left(LTRIM(Str(refno, 9, 5)),11),5)),0)+1),5) as maxno ) as ReferenceNo
                                From RegistrationMaster where CourseName='M.Ed'";
                }

                using (var command = dbContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;

                    dbContext.Database.OpenConnection();
                    var result = await command.ExecuteScalarAsync();
                    refNo = result.ToString();
                }
            }
            catch (Exception ex)
            {
                return "";
                //return ex.Message;
            }
            return refNo;
        }

        public async Task<string> InsertRegistrationFormDataAsync(RegistrationViewModel model)
        {
            if (model != null)
            {
                var Course = await dbContext.CourseMaster.FirstOrDefaultAsync(f => f.CourseName == model.CourseName);
                var refNo = await GenerateUniqueRefNo(Course.Id);
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        model.RefNo = refNo;
                        //model.UniqueKey = Guid.NewGuid().ToString().GetHashCode().ToString("x");
                        string[] photoFileExt = model.PhohoFile.FileInfo.Name.Split('.');
                        string UniquePhotoName = $"{refNo}P.{photoFileExt[1]}";

                        string[] signatureFileExt = model.SignatureFile.FileInfo.Name.Split('.');
                        string UniqueSignatureName = $"{refNo}S.{signatureFileExt[1]}";
                        var registrationData = new Registration
                        {
                            UniqueKey = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                            UserId = model.UserId,
                            Name = model.Name,
                            FatherName = model.FatherName,
                            MotherName = model.MotherName,
                            Dob = model.Dob,
                            MobileNo = model.MobileNo,
                            EmailAddress = model.EmailAddress,
                            Gender = model.Gender,
                            Year = model.Year,
                            ExamCenter = model.ExamCenter,
                            CourseName = Course.Id,
                            StudentGroup = model.StudentGroup,
                            MaritalStatus = model.MaritalStatus,
                            Nationality = model.Nationality,
                            IsDomicileOfUttarakhand = model.IsDomicileOfUttarakhand,
                            Category = model.Category,
                            IsFreedomFighter = model.IsFreedomFighter,
                            IsDefencePersonal = model.IsDefencePersonal,
                            IsPhysicallyChallenged = model.IsPhysicallyChallenged,
                            PhysicallyChallengedType = model.PhysicallyChallengedType,
                            IsPunishedByCourt = model.IsPunishedByCourt,
                            IsDebarredByUniversity = model.IsDebarredByUniversity,
                            StateName = model.StateName,
                            Address = model.Address,
                            City = model.City,
                            Pincode = model.Pincode,
                            PhotoPath = UniquePhotoName,
                            SignaturePath = UniqueSignatureName,
                            IsEconomicallyWeakerSection = model.IsEconomicallyWeakerSection,
                            RefNo = refNo,
                            CreatedBy = model.UserId,
                            CreatedTimeStamp = DateTime.Now,
                            IsAppearing = model.IsAppearing,
                            IsKumaunUniversity = model.IsKumaunUniversity
                        };

                        var allQualifyingType = await dbContext.QualifyingTypeMaster.ToListAsync();
                        List<QualifyingExam> liQualifyingExam = new List<QualifyingExam>();
                        QualifyingType qualifyingType = new QualifyingType();
                        if (Course.Id == "B.Ed")
                        {
                            if (!string.IsNullOrEmpty(model.GradutionName))
                            {
                                qualifyingType = allQualifyingType.FirstOrDefault(f => f.QualifyingTypeName == "Graduation");
                                liQualifyingExam.Add(new QualifyingExam
                                {
                                    UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                                    RefNo = refNo,
                                    CourseName = Course.Id,
                                    QualifyingType = qualifyingType.Id.ToString(),
                                    Name = model.GradutionName,
                                    Stream = model.GradutionStream,
                                    University = model.GradutionUniversity,
                                    PassingYear = model.GradutionPassingYear,
                                    MaxMarks = model.GradutionMaxMarks,
                                    ObtMarks = model.GradutionObtMarks,
                                    PercentageMarks = model.GradutionPercentageMarks,
                                    TimeStamp = DateTime.Now
                                });
                            }

                            if (!string.IsNullOrEmpty(model.PGradutionUniversity))
                            {
                                qualifyingType = allQualifyingType.FirstOrDefault(f => f.QualifyingTypeName == "Post Graduation");
                                liQualifyingExam.Add(new QualifyingExam
                                {
                                    UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                                    RefNo = refNo,
                                    CourseName = Course.Id,
                                    QualifyingType = qualifyingType.Id.ToString(),
                                    Name = model.PostGradutionName,
                                    Stream = model.PGradutionStream,
                                    University = model.PGradutionUniversity,
                                    PassingYear = model.PGradutionPassingYear,
                                    MaxMarks = model.PGradutionMaxMarks,
                                    ObtMarks = model.PGradutionObtMarks,
                                    PercentageMarks = model.PGradutionPercentageMarks,
                                    TimeStamp = DateTime.Now
                                });
                            }
                        }
                        else
                        {
                            qualifyingType = allQualifyingType.FirstOrDefault(f => f.QualifyingTypeName == "Theory Exam");
                            liQualifyingExam.Add(new QualifyingExam
                            {
                                UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                                RefNo = refNo,
                                CourseName = Course.Id,
                                QualifyingType = qualifyingType.Id.ToString(),
                                Name = model.TheoryExamName,
                                Stream = string.Empty,
                                University = model.M_EdExamUniversity,
                                PassingYear = model.M_EdExamPassingYear,
                                MaxMarks = model.TheoryExamMaxMarks,
                                ObtMarks = model.TheoryExamObtMarks,
                                PercentageMarks = model.M_EdTotalPercentage,    // This Column for this condition (Percentage should be calculate to addition of Both Theory & Practical Exam Marks)
                                TimeStamp = DateTime.Now
                            });

                            qualifyingType = allQualifyingType.FirstOrDefault(f => f.QualifyingTypeName == "Practical Exam");
                            liQualifyingExam.Add(new QualifyingExam
                            {
                                UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                                RefNo = refNo,
                                CourseName = Course.Id,
                                QualifyingType = qualifyingType.Id.ToString(),
                                Name = model.PracticalExamName,
                                Stream = string.Empty,
                                University = model.M_EdExamUniversity,
                                PassingYear = model.M_EdExamPassingYear,
                                MaxMarks = model.PracticalExamMaxMarks,
                                ObtMarks = model.PracticalExamObtMarks,
                                PercentageMarks = model.M_EdTotalPercentage,    // This Column for this condition (Percentage should be calculate to addition of Both Theory & Practical Exam Marks)
                                TimeStamp = DateTime.Now
                            });
                        }

                        await dbContext.RegistrationMaster.AddAsync(registrationData);
                        var result = await dbContext.SaveChangesAsync();
                        if (result > 0)
                        {
                            int counter = 0;
                            foreach (var examDetails in liQualifyingExam)
                            {
                                await dbContext.QualifyingExamMaster.AddAsync(examDetails);
                                var returnData = await dbContext.SaveChangesAsync();
                                if (returnData > 0)
                                {
                                    counter = counter + 1;
                                }
                            }

                            if (counter == liQualifyingExam.Count)
                            {
                                // Upload Phote
                                UploadImageFiles(model.PhohoFile, "Photos", UniquePhotoName);

                                // Upload Signature
                                UploadImageFiles(model.SignatureFile, "Signature", UniqueSignatureName);
                                await transaction.CommitAsync();
                                return "success";
                            }
                        }
                        else
                        {
                            await transaction.RollbackAsync();
                            return "failure";
                        }
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return "failure";
                        //return ex.Message;
                    }
                }
            }

            return "failure";
        }

        public async Task<RegistrationViewModel> GetRegistrationDetailsByUserIdAsync(string Id)
        {
            RegistrationViewModel model;
            var registrationMasterData = (await dapperService.GetAllRegistrationDetailsAsync()).FirstOrDefault(f => f.UserId == Id);
            var QualifyingExamData = (await dapperService.GetQualifyingExamsAsync()).Where(w => w.RefNo == registrationMasterData.RefNo);
            if (registrationMasterData != null && QualifyingExamData != null)
            {
                model = new RegistrationViewModel
                {
                    UserId = registrationMasterData.UserId,
                    Name = registrationMasterData.Name,
                    FatherName = registrationMasterData.FatherName,
                    MotherName = registrationMasterData.MotherName,
                    Dob = registrationMasterData.Dob,
                    MobileNo = registrationMasterData.MobileNo,
                    EmailAddress = registrationMasterData.EmailAddress,
                    Gender = registrationMasterData.Gender,
                    Year = registrationMasterData.Year,
                    ExamCenter = registrationMasterData.ExamCenter,
                    CourseName = registrationMasterData.CourseName,
                    StudentGroup = registrationMasterData.StudentGroup,
                    MaritalStatus = registrationMasterData.MaritalStatus,
                    Nationality = registrationMasterData.Nationality,
                    IsDomicileOfUttarakhand = registrationMasterData.IsDomicileOfUttarakhand,
                    Category = registrationMasterData.Category,
                    IsFreedomFighter = registrationMasterData.IsFreedomFighter,
                    IsDefencePersonal = registrationMasterData.IsDefencePersonal,
                    IsPhysicallyChallenged = registrationMasterData.IsPhysicallyChallenged,
                    PhysicallyChallengedType = registrationMasterData.PhysicallyChallengedType,
                    IsPunishedByCourt = registrationMasterData.IsPunishedByCourt,
                    IsDebarredByUniversity = registrationMasterData.IsDebarredByUniversity,
                    StateName = registrationMasterData.StateName,
                    Address = registrationMasterData.Address,
                    City = registrationMasterData.City,
                    Pincode = registrationMasterData.Pincode,
                    PhotoPath = registrationMasterData.PhotoPath,
                    SignaturePath = registrationMasterData.SignaturePath,
                    IsEconomicallyWeakerSection = registrationMasterData.IsEconomicallyWeakerSection,
                    RefNo = registrationMasterData.RefNo,
                    IsAppearing = registrationMasterData.IsAppearing,
                    IsKumaunUniversity = registrationMasterData.IsKumaunUniversity
                };

                foreach (var item in QualifyingExamData)
                {
                    if (item.CourseName.Trim() == "B.Ed")
                    {
                        if (item.QualifyingType == "1")
                        {
                            model.GradutionName = item.Name;
                            model.GradutionStream = item.Stream;
                            model.GradutionUniversity = item.University;
                            model.GradutionPassingYear = item.PassingYear;
                            model.GradutionMaxMarks = item.MaxMarks;
                            model.GradutionObtMarks = item.ObtMarks;
                            model.GradutionPercentageMarks = item.PercentageMarks;
                        }
                        else if (item.QualifyingType == "2")
                        {
                            model.PostGradutionName = item.Name;
                            model.PGradutionStream = item.Stream;
                            model.PGradutionUniversity = item.University;
                            model.PGradutionPassingYear = item.PassingYear;
                            model.PGradutionMaxMarks = item.MaxMarks;
                            model.PGradutionObtMarks = item.ObtMarks;
                            model.PGradutionPercentageMarks = item.PercentageMarks;
                        }
                    }
                    else
                    {
                        if (item.QualifyingType == "3")
                        {
                            model.TheoryExamName = item.Name;
                            model.TheoryExamMaxMarks = item.MaxMarks;
                            model.TheoryExamObtMarks = item.ObtMarks;

                        }
                        else if (item.QualifyingType == "4")
                        {
                            model.PracticalExamName = item.Name;
                            model.PracticalExamMaxMarks = item.MaxMarks;
                            model.PracticalExamObtMarks = item.ObtMarks;
                        }

                        model.M_EdExamUniversity = item.University;
                        model.M_EdExamPassingYear = item.PassingYear;
                        model.M_EdTotalPercentage = item.PercentageMarks;
                    }
                }

                return model;
            }

            model = new RegistrationViewModel();

            return model;
        }
        
        public async Task<RegistrationViewModel> GetRegistrationDetailsByRefIdAsync(string Id)
        {
            RegistrationViewModel model;
            var registrationMasterData = (await dapperService.GetAllRegistrationDetailsAsync()).FirstOrDefault(f => f.RefNo == Id);
            var QualifyingExamData = (await dapperService.GetQualifyingExamsAsync()).Where(w => w.RefNo == registrationMasterData.RefNo);
            if (registrationMasterData != null && QualifyingExamData != null)
            {
                model = new RegistrationViewModel
                {
                    UserId = registrationMasterData.UserId,
                    Name = registrationMasterData.Name,
                    FatherName = registrationMasterData.FatherName,
                    MotherName = registrationMasterData.MotherName,
                    Dob = registrationMasterData.Dob,
                    MobileNo = registrationMasterData.MobileNo,
                    EmailAddress = registrationMasterData.EmailAddress,
                    Gender = registrationMasterData.Gender,
                    Year = registrationMasterData.Year,
                    ExamCenter = registrationMasterData.ExamCenter,
                    CourseName = registrationMasterData.CourseName,
                    StudentGroup = registrationMasterData.StudentGroup,
                    MaritalStatus = registrationMasterData.MaritalStatus,
                    Nationality = registrationMasterData.Nationality,
                    IsDomicileOfUttarakhand = registrationMasterData.IsDomicileOfUttarakhand,
                    Category = registrationMasterData.Category,
                    IsFreedomFighter = registrationMasterData.IsFreedomFighter,
                    IsDefencePersonal = registrationMasterData.IsDefencePersonal,
                    IsPhysicallyChallenged = registrationMasterData.IsPhysicallyChallenged,
                    PhysicallyChallengedType = registrationMasterData.PhysicallyChallengedType,
                    IsPunishedByCourt = registrationMasterData.IsPunishedByCourt,
                    IsDebarredByUniversity = registrationMasterData.IsDebarredByUniversity,
                    StateName = registrationMasterData.StateName,
                    Address = registrationMasterData.Address,
                    City = registrationMasterData.City,
                    Pincode = registrationMasterData.Pincode,
                    PhotoPath = registrationMasterData.PhotoPath,
                    SignaturePath = registrationMasterData.SignaturePath,
                    IsEconomicallyWeakerSection = registrationMasterData.IsEconomicallyWeakerSection,
                    RefNo = registrationMasterData.RefNo,
                    IsAppearing = registrationMasterData.IsAppearing,
                    IsKumaunUniversity = registrationMasterData.IsKumaunUniversity
                };

                foreach (var item in QualifyingExamData)
                {
                    if (item.CourseName.Trim() == "B.Ed")
                    {
                        if (item.QualifyingType == "1")
                        {
                            model.GradutionName = item.Name;
                            model.GradutionStream = item.Stream;
                            model.GradutionUniversity = item.University;
                            model.GradutionPassingYear = item.PassingYear;
                            model.GradutionMaxMarks = item.MaxMarks;
                            model.GradutionObtMarks = item.ObtMarks;
                            model.GradutionPercentageMarks = item.PercentageMarks;
                        }
                        else if (item.QualifyingType == "2")
                        {
                            model.PostGradutionName = item.Name;
                            model.PGradutionStream = item.Stream;
                            model.PGradutionUniversity = item.University;
                            model.PGradutionPassingYear = item.PassingYear;
                            model.PGradutionMaxMarks = item.MaxMarks;
                            model.PGradutionObtMarks = item.ObtMarks;
                            model.PGradutionPercentageMarks = item.PercentageMarks;
                        }
                    }
                    else
                    {
                        if (item.QualifyingType == "3")
                        {
                            model.TheoryExamName = item.Name;
                            model.TheoryExamMaxMarks = item.MaxMarks;
                            model.TheoryExamObtMarks = item.ObtMarks;

                        }
                        else if (item.QualifyingType == "4")
                        {
                            model.PracticalExamName = item.Name;
                            model.PracticalExamMaxMarks = item.MaxMarks;
                            model.PracticalExamObtMarks = item.ObtMarks;
                        }

                        model.M_EdExamUniversity = item.University;
                        model.M_EdExamPassingYear = item.PassingYear;
                        model.M_EdTotalPercentage = item.PercentageMarks;
                    }
                }

                return model;
            }

            model = new RegistrationViewModel();

            return model;
        }

        public int CalculateYourAge(DateTime dob)
        {
            int Years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            return Years;
        }

        public string GenerateOtp()
        {
            int iOTPLength = 6;
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string sOTP = String.Empty;
            string sTempChars = String.Empty;
            Random rand = new Random();
            for (int i = 0; i < iOTPLength; i++)
            {
                int p = rand.Next(0, saAllowedCharacters.Length);
                sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];
                sOTP += sTempChars;
            }
            return sOTP;
        }

        public async Task<string> SendSmsAsync(string mobileNo, string msg, string email, string otp = null, string sentFlag = null)
        {
            string returnValue;
            string weblink = $"http://80.241.215.220/sendsms/sendsms.php?username=EIkumuni&password=tech321&type=TEXT&sender=KUMUNI&mobile={mobileNo}&message={msg}";
            try
            {
                var response = await httpClient.GetAsync(weblink);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    string[] messageContent = content.Split('|');
                    if (sentFlag.ToLower() == "resend")
                    {
                        returnValue = "success";
                    }
                    else
                    {
                        var allOtpData = await dapperService.GetOtpDetailsAsync();
                        var otpData = allOtpData.FirstOrDefault(f => f.Email.ToLower() == email.ToLower() && f.IsValid == false);
                        if (otpData == null)
                        {
                            var otpModel = new OtpTable()
                            {
                                UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                                Email = email,
                                Message = messageContent[0].Trim(),
                                Otp = string.IsNullOrEmpty(otp) ? string.Empty : otp
                            };
                            returnValue = await dapperService.InsertOtpDetailsAsync(otpModel);
                        }
                        else
                        {
                            returnValue = "success";
                        }
                    }

                    return returnValue;
                }
            }
            catch (Exception ex)
            {
                return "failure";
                //  return ex.Message;
            }

            return "failure";
        }

        public void UploadImagesInTemp(UploadFiles file, string UniqueFileName)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "upload", "uploadku", "TempStorage");
            if (Directory.Exists(uploadsFolder))
            {
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    file.Stream.WriteTo(fileStream);
                }
            }
            else
            {
                Directory.CreateDirectory(uploadsFolder);
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    file.Stream.WriteTo(fileStream);
                }
            }
        }

        public async Task UploadImagesInTempUsingInput(IFileListEntry file, string UniqueFileName)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "upload", "uploadku", "TempStorage");
            if (Directory.Exists(uploadsFolder))
            {
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fileStream);
                }
            }
            else
            {
                Directory.CreateDirectory(uploadsFolder);
                string filePath = Path.Combine(uploadsFolder, UniqueFileName);
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fileStream);
                }
            }
        }

        public void DeleteTempFiles(string fileName)
        {
            string filePath = Path.Combine(hostingEnvironment.WebRootPath, "upload", "uploadku", "TempStorage", fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public async Task<string> UpdateRegistrationDetailsAsync(RegistrationViewModel model, bool photoFlag, bool signatureFlag)
        {
            var returnValue = string.Empty;
            try
            {
                string[] photoFileExt = new string[] {};
                string UniquePhotoName = string.Empty;
                string[] signatureFileExt = new string[] {};
                string UniqueSignatureName = string.Empty;
                if (photoFlag)
                {
                    photoFileExt = model.PhohoFile.FileInfo.Name.Split('.');
                    UniquePhotoName = $"{model.RefNo}P.{photoFileExt[1]}";
                    model.PhotoPath = UniquePhotoName;
                }

                if (signatureFlag)
                {
                    signatureFileExt = model.SignatureFile.FileInfo.Name.Split('.');
                    UniqueSignatureName = $"{model.RefNo}S.{signatureFileExt[1]}";
                    model.SignaturePath = UniqueSignatureName;
                }

                var result = await dapperService.UpdateRegistrationFormDetailsAsync(model);
                if (result == "success")
                {
                    if (photoFlag)
                    {
                        string[] onlyPhotoName = UniquePhotoName.Split('.');
                        string photoUploadPath = Path.Combine(hostingEnvironment.WebRootPath, "UploadDocs", "Photos", onlyPhotoName[0]);
                        if (File.Exists(File.Exists(photoUploadPath + ".jpg") ? photoUploadPath + ".jpg" :
                            File.Exists(photoUploadPath + ".png") ? photoUploadPath + ".png" :
                            File.Exists(photoUploadPath + ".jpeg") ? photoUploadPath + ".jpeg" : null))
                        {
                            File.Delete(File.Exists(photoUploadPath + ".jpg") ? photoUploadPath + ".jpg" :
                                File.Exists(photoUploadPath + ".png") ? photoUploadPath + ".png" :
                                File.Exists(photoUploadPath + ".jpeg") ? photoUploadPath + ".jpeg" : null);
                            // Upload Photo
                            UploadImageFiles(model.PhohoFile, "Photos", UniquePhotoName);   
                        }
                        else
                        {
                            // Upload Photo
                            UploadImageFiles(model.PhohoFile, "Photos", UniquePhotoName);
                        }
                    }

                    if (signatureFlag)
                    {
                        string[] onlySignatureName = UniqueSignatureName.Split('.');
                        string singatureUploadPath = Path.Combine(hostingEnvironment.WebRootPath, "UploadDocs", "Signature", onlySignatureName[0]);
                        if (File.Exists(File.Exists(singatureUploadPath + ".jpg") ? singatureUploadPath + ".jpg": File.Exists(singatureUploadPath + ".png") ? 
                            singatureUploadPath + ".png" : File.Exists(singatureUploadPath + ".jpeg") ? singatureUploadPath + ".jpeg" : null))
                        {
                            File.Delete(File.Exists(singatureUploadPath + ".jpg") ? singatureUploadPath + ".jpg" :
                                File.Exists(singatureUploadPath + ".png") ? singatureUploadPath + ".png" :
                                File.Exists(singatureUploadPath + ".jpeg") ? singatureUploadPath + ".jpeg" : null);
                            // Upload Signature
                            UploadImageFiles(model.SignatureFile, "Signature", UniqueSignatureName);
                        }
                        else
                        {
                            // Upload Signature
                            UploadImageFiles(model.SignatureFile, "Signature", UniqueSignatureName);
                        }
                    }
                    return "success";
                    
                }
            }
            catch (Exception e)
            {

                returnValue =  "failure";
                //returnValue = e.Message;
            }

            return returnValue;
        }

        public async Task<string> SendSmsAsync(string mobileNo, string msg)
        {
            string returnValue;
            string weblink = $"http://80.241.215.220/sendsms/sendsms.php?username=EIkumuni&password=tech321&type=TEXT&sender=KUMUNI&mobile={mobileNo}&message={msg}";
            try
            {
                var response = await httpClient.GetAsync(weblink);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    string[] messageContent = content.Split('|');
                    if (messageContent[0].Trim() == "SUBMIT_SUCCESS")
                    {
                        returnValue = "success";
                    }
                    else
                    {
                        returnValue = "failure";
                    }
                }
            }
            catch (Exception ex)
            {
                returnValue = "failure";
              //  returnValue = ex.Message;
            }

            returnValue = "failure";
            return returnValue;
        }
    }
}
