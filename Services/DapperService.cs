using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.ViewModels;
using Z.Dapper.Plus;

namespace uttarakhand_project_front.Services
{
    public class DapperService
    {
        private readonly IConfiguration configuration;

        public DapperService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<ApplicationUser> CustomFindByEmailAsync(string emailAddress)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                string sql = @"Select * From AspNetUsers where LOWER(Email) = @email";
                var result = await connection.QueryFirstOrDefaultAsync<ApplicationUser>(sql, new {email = emailAddress.ToLower()});
                return result;
            }
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUserListAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<ApplicationUser>("Select * From AspNetUsers");
            }
        }

        public async Task<IEnumerable<Registration>> GetAllRegistrationDetailsAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<Registration>("Select * From RegistrationMaster");
            }
        }

        public async Task<IEnumerable<QualifyingExam>> GetQualifyingExamsAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<QualifyingExam>("Select * From QualifyingExamMaster");
            }
        }

        public async Task<IEnumerable<ExamCenter>> GetExamCenterList()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<ExamCenter>("Select * From ExamCenterMaster");
            }
        }

        public async Task<IEnumerable<QualifyingExamDetails>> GetAllQualifyingExamDetails()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<QualifyingExamDetails>("Select * From QualifyingExamDetailsMaster");
            }
        }

        public async Task<IEnumerable<Pincode>> GetAllPincodeAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<Pincode>("Select * From PincodeMaster");
            }
        }

        public async Task<IEnumerable<State>> GetAllStatesListAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<State>("Select * From StateMaster");
            }
        }

        public async Task<IEnumerable<Course>> GetAllCourseListAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<Course>("Select * From CourseMaster");
            }
        }

        public async Task<ApplicationUser> CheckMobileDuplicacyAsync(string mobileNumber)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Select * from AspNetUsers where PhoneNumber = @mobile";
                var user = await connection.QueryFirstOrDefaultAsync<ApplicationUser>(query,
                    new {mobile = mobileNumber});
                return user;
            }
        }

        public async Task<ApplicationUser> CheckEmailDuplicacyAsync(string emailAddress)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Select * from AspNetUsers where Lower(Email) = @email";
                var user = await connection.QueryFirstOrDefaultAsync<ApplicationUser>(query,
                    new {email = emailAddress.ToLower()});
                return user;
            }
        }

        public async Task<string> UpdateRegistrationFormDetailsAsync(RegistrationViewModel model)
        {
            string resultStatus = string.Empty;
            int result;
            var courseList = await GetAllCourseListAsync();
            var courseData = courseList.FirstOrDefault(f => f.CourseName == model.CourseName);
            var registrationModel = new
            {
                name = model.Name,
                fName = model.FatherName,
                mName = model.MotherName,
                dob = model.Dob,
                mobile = model.MobileNo,
                email = model.EmailAddress,
                gen = model.Gender,
                year = model.Year,
                examCenter = model.ExamCenter,
                course = courseData.Id,
                group = model.StudentGroup,
                marital = model.MaritalStatus,
                national = model.Nationality,
                isDomicile = model.IsDomicileOfUttarakhand,
                category = model.Category,
                freedom = model.IsFreedomFighter,
                defence = model.IsDefencePersonal,
                ph = model.IsPhysicallyChallenged,
                phType = model.PhysicallyChallengedType,
                punish = model.IsPunishedByCourt,
                debarred = model.IsDebarredByUniversity,
                state = model.StateName,
                address = model.Address,
                city = model.City,
                pin = model.Pincode,
                photo = model.PhotoPath,
                signature = model.SignaturePath,
                ews = model.IsEconomicallyWeakerSection,
                update = model.UserId,
                appearing = model.IsAppearing,
                isKumaun = model.IsKumaunUniversity,
                refNo = model.RefNo
            };
            string query =
                @"Update RegistrationMaster set Name=@name, FatherName=@fName, MotherName=@mName, Dob=@dob, MobileNo=@mobile, 
            EmailAddress=@email, Gender=@gen, Year=@year, ExamCenter=@examCenter, CourseName=@course, StudentGroup=@group, MaritalStatus=@marital, 
            Nationality=@national, IsDomicileOfUttarakhand=@isDomicile, Category=@category, IsFreedomFighter=@freedom, IsDefencePersonal=@defence, 
            IsPhysicallyChallenged=@ph, PhysicallyChallengedType=@phType, IsPunishedByCourt=@punish, IsDebarredByUniversity=@debarred, StateName=@state, 
            Address=@address, CIty=@city, Pincode=@pin, PhotoPath=@photo, SignaturePath=@signature, IsEconomicallyWeakerSection=@ews, UpdatedBy=@update, 
            UpdatedTimeStamp=GETDATE(), IsAppearing=@appearing, IsKumaunUniversity=@isKumaun where RefNo=@refNo;";

            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        result = await connection.ExecuteAsync(query, registrationModel, transaction);
                        if (result > 0)
                        {
                            var allQualificationDetails = await GetQualifyingExamsAsync();
                            var actualQualification = allQualificationDetails.Where(w => w.RefNo == model.RefNo);
                            foreach (var item in actualQualification)
                            {
                                if (item.CourseName.Trim() == "B.Ed")
                                {
                                    if (item.QualifyingType == "1")
                                    {
                                        var gradutionModel = new
                                        {
                                            course = item.CourseName,
                                            name = model.GradutionName,
                                            stream = model.GradutionStream,
                                            university = model.GradutionUniversity,
                                            pYear = model.GradutionPassingYear,
                                            mMarks = model.GradutionMaxMarks,
                                            obtMarks = model.GradutionObtMarks,
                                            percentage = model.GradutionPercentageMarks,
                                            refNo = model.RefNo
                                        };
                                        string query2 =
                                            @"Update QualifyingExamMaster set CourseName=@course, Name=@name, Stream=@stream, University=@university, 
                                    PassingYear=@pYear, MaxMarks=@mMarks, ObtMarks=@obtMarks, PercentageMarks=@percentage where RefNo=@refNo";
                                        result = await connection.ExecuteAsync(query2, gradutionModel, transaction);
                                    }
                                    else if (item.QualifyingType == "2")
                                    {
                                        var postGradutionModel = new
                                        {
                                            course = item.CourseName,
                                            name = model.PostGradutionName,
                                            stream = model.PGradutionStream,
                                            university = model.PGradutionUniversity,
                                            pYear = model.PGradutionPassingYear,
                                            mMarks = model.PGradutionMaxMarks,
                                            obtMarks = model.PGradutionObtMarks,
                                            percentage = model.PGradutionPercentageMarks,
                                            refNo = model.RefNo
                                        };
                                        string query3 =
                                            @"Update QualifyingExamMaster set CourseName=@course, Name=@name, Stream=@stream, University=@university, 
                                    PassingYear=@pYear, MaxMarks=@mMarks, ObtMarks=@obtMarks, PercentageMarks=@percentage where RefNo=@refNo";
                                        result = await connection.ExecuteAsync(query3, postGradutionModel, transaction);
                                    }
                                }
                                else
                                {
                                    if (item.QualifyingType == "3")
                                    {
                                        var m_EdTheoryModel = new
                                        {
                                            course = item.CourseName,
                                            name = model.TheoryExamName,
                                            stream = string.Empty,
                                            university = model.M_EdExamUniversity,
                                            pYear = model.M_EdExamPassingYear,
                                            mMarks = model.TheoryExamMaxMarks,
                                            obtMarks = model.TheoryExamObtMarks,
                                            percentage = model.M_EdTotalPercentage,
                                            refNo = model.RefNo
                                        };
                                        string query4 =
                                            @"Update QualifyingExamMaster set CourseName=@course, Name=@name, Stream=@stream, University=@university, 
                                    PassingYear=@pYear, MaxMarks=@mMarks, ObtMarks=@obtMarks, PercentageMarks=@percentage where RefNo=@refNo";
                                        result = await connection.ExecuteAsync(query4, m_EdTheoryModel, transaction);
                                    }
                                    else if (item.QualifyingType == "4")
                                    {
                                        model.PracticalExamName = item.Name;
                                        model.PracticalExamMaxMarks = item.MaxMarks;
                                        model.PracticalExamObtMarks = item.ObtMarks;

                                        var m_EdPracticalModel = new
                                        {
                                            course = item.CourseName,
                                            name = model.PracticalExamName,
                                            stream = string.Empty,
                                            university = model.M_EdExamUniversity,
                                            pYear = model.M_EdExamPassingYear,
                                            mMarks = model.PracticalExamMaxMarks,
                                            obtMarks = model.PracticalExamObtMarks,
                                            percentage = model.M_EdTotalPercentage,
                                            refNo = model.RefNo
                                        };
                                        string query5 =
                                            @"Update QualifyingExamMaster set CourseName=@course, Name=@name, Stream=@stream, University=@university, 
                                    PassingYear=@pYear, MaxMarks=@mMarks, ObtMarks=@obtMarks, PercentageMarks=@percentage where RefNo=@refNo";
                                        result = await connection.ExecuteAsync(query5, m_EdPracticalModel, transaction);
                                    }
                                }
                            }

                            if (result > 0)
                            {
                                transaction.Commit();
                                return "success";
                            }
                            else
                            {
                                transaction.Rollback();
                                return "failure";
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        resultStatus = e.Message;
                        transaction.Rollback();
                    }
                }
            }

            return resultStatus;
        }

        public async Task<string> InsertOtpDetailsAsync(OtpTable otpTable)
        {
            string returnValue;
            var otpModel = new
            {
                uniueId = otpTable.UniqueId,
                otp = otpTable.Otp,
                email = otpTable.Email,
                message = otpTable.Message
            };
            string sql =
                @"Insert into OtpTableMaster(UniqueId, Otp, Email, Message, TimeStamp) values(@uniueId, @otp, @email, @message, GetDate())";


            using (IDbConnection connection =
                new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var result = await connection.ExecuteAsync(sql, otpModel, transaction);
                        if (result > 0)
                        {
                            returnValue = "success";
                            transaction.Commit();
                        }
                        else
                        {
                            returnValue = "failure";
                            transaction.Rollback();
                        }
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        returnValue = e.Message;
                    }
                }
            }
            return returnValue;
        }

        public async Task<IEnumerable<OtpTable>> GetOtpDetailsAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<OtpTable>("Select * From OtpTableMaster");
            }
        }

        public async Task<string> UpdateOtpDetailsAsync(string uniqueId)
        {
            string result;
            string sql = @"Update OtpTableMaster set IsValid = 1 where UniqueId = @unique";
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var resultSet = await connection.ExecuteAsync(sql, new {unique = uniqueId}, transaction);
                        if (resultSet > 0)
                        {
                            result = "success";
                            transaction.Commit();
                        }
                        else
                        {
                            result = "failure";
                            transaction.Rollback();
                        }
                    }
                    catch (Exception e)
                    {
                        result = e.Message;
                        transaction.Rollback();
                    }
                }
            }

            return result;
        }
        
        public async Task<IEnumerable<Payment>> GetPaymentsDetailsAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<Payment>("Select * From PaymentMaster");
            }
        }

        public async Task<string> GetUserRolesByUserIdAsync(string userId)
        {
            string sql = @"Select roles.Name From AspNetRoles roles inner join AspNetUserRoles userRoles 
                            on roles.Id = userRoles.RoleId
                            where userRoles.UserId = @id";
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                return await connection.QuerySingleAsync<string>(sql, new {id = userId});
            }
        }

        public async Task<Payment> CheckPaymentPaidAgainstRefNo(string refId)
        {
            string sql = @"Select * From PaymentMaster where UPPER(RefNo) = @refId and PaidStatus = 1";
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                return await connection.QueryFirstOrDefaultAsync<Payment>(sql, new {refId = refId});
            }
        }
    }
}