using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using uttarakhand_project_front.Auth;
using uttarakhand_project_front.Data;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.ViewModels;

namespace uttarakhand_project_front.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly FrontAppDbContext _dbContext;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        private readonly ICenterService _centerService;
        private readonly ITokenService _tokenService;
        private readonly DapperService _dapperService;
        private readonly IDataProtector _dataProtector;

        public UserService(UserManager<ApplicationUser> userManager,
            IConfiguration configuration, IDataProtectionProvider dataProtectionProvider, DataProtectionPurposeStrings dataProtectionPurposeStrings,
            IHttpContextAccessor httpContextAccessor, FrontAppDbContext dbContext, SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager, AuthenticationStateProvider authenticationStateProvider,
            IPasswordHasher<ApplicationUser> passwordHasher, ICenterService centerService, ITokenService tokenService, 
            DapperService dapperService)
        {
            _userManager = userManager;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _authenticationStateProvider = authenticationStateProvider;
            _passwordHasher = passwordHasher;
            _centerService = centerService;
            _tokenService = tokenService;
            _dapperService = dapperService;
            _dataProtector = dataProtectionProvider.CreateProtector(dataProtectionPurposeStrings.RouteValue);
        }

        public async Task<UserToken> CreateUserAsync(RegisterViewModel model)
        {
            UserToken userToken = new UserToken();
            try
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.MobileNo,
                    RegistrationTime = DateTime.Now
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var roles = await _roleManager.Roles.CountAsync();
                    if (roles > 0)
                    {
                        var roleAssignResult = await _userManager.AddToRoleAsync(user, "User");
                        if (roleAssignResult.Succeeded)
                        {
                            var role = await _userManager.GetRolesAsync(user);
                            var userInfo = new UserInfo
                            {
                                Email = model.Email,
                                Name = $"{model.FirstName} {model.LastName}",
                                Username = model.Email,
                                Roles = role,
                                UserId = user.Id
                            };
                            userToken = _tokenService.BuildToken(userInfo);
                            userToken.Status = "success";
                            return userToken;
                        }
                    }
                    else
                    {
                        IdentityRole role = new IdentityRole
                        {
                            Name = "User"
                        };
                        var resultRole = await _roleManager.CreateAsync(role);
                        if (resultRole.Succeeded)
                        {
                            var roleAssignResult = await _userManager.AddToRoleAsync(user, "User");
                            if (roleAssignResult.Succeeded)
                            {
                                var roleElse = await _userManager.GetRolesAsync(user);
                                var userInfo = new UserInfo
                                {
                                    Email = model.Email,
                                    Name = $"{model.FirstName} {model.LastName}",
                                    Username = model.Email,
                                    Roles = roleElse,
                                    UserId = user.Id
                                };
                                userToken = _tokenService.BuildToken(userInfo);
                                userToken.Status = "success";
                                return userToken;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                userToken.Status = ex.Message;
                return userToken;
            }

            userToken.Status = "failed";
            return userToken;
        }

        public async Task<UserToken> LoginUserAsync(LoginViewModel model)
        {
            UserToken userToken = new UserToken();
            //var user = await _userManager.FindByEmailAsync(model.Email);
            var user = await _dapperService.CustomFindByEmailAsync(model.Email);
            if (user != null)
            {
                try
                {
                    var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, true);
                    if (result.Succeeded)
                    {
                        var role = await _userManager.GetRolesAsync(user);
                        var userInfo = new UserInfo
                        {
                            Email = model.Email,
                            Name = $"{user.FirstName} {user.LastName}",
                            Username = model.Email,
                            Roles = role,
                            UserId = user.Id
                        };
                        userToken = _tokenService.BuildToken(userInfo);
                        userToken.Status = "success";
                        return userToken;
                    }
                    else
                    {
                        userToken.Status = "Invalid Login Credentials";
                    }

                    //if (result.IsLockedOut)
                    //{
                    //    //string message = "Your account is locked, please try again after sometime or you may reset your password.";
                    //    string message = "";
                    //    userToken.Status = message;
                    //}
                }
                catch (Exception e)
                {
                    userToken.Status = "Invalid Login";
                   // userToken.Status = e.Message;
                }
            }
            else
            {
                userToken.Status = "You have to register yourself with us!";
            }

            return userToken;
        }

        public async Task<string> CreateRoleAsync(string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
            {
                return "Your request is not valid, please resend it.";
            }

            var checkExisting = await _roleManager.FindByNameAsync(roleName);
            if (checkExisting != null)
            {
                return "You have already created this role!";
            }

            IdentityRole role = new IdentityRole
            {
                Name = roleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return "success";
            }

            string errorData = string.Empty;
            List<IdentityError> li = new List<IdentityError>();
            foreach (var error in result.Errors)
            {
                errorData = error.Description;
                li.Add(new IdentityError
                {
                    Code = error.Code,
                    Description = error.Description
                });
            }

            return errorData;
        }

        public async Task<IEnumerable<IdentityRole>> GetRolesListAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<string> DeleteRoleAsync(string roleId)
        {
            if (string.IsNullOrEmpty(roleId))
            {
                return "Your request is not valid, please resend it.";
            }

            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                return $"Role with Name = {role.Name} cannot be found";
            }

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return "success";
            }

            string errorData = string.Empty;
            List<IdentityError> li = new List<IdentityError>();
            foreach (var error in result.Errors)
            {
                errorData = error.Description;
                li.Add(new IdentityError
                {
                    Code = error.Code,
                    Description = error.Description
                });
            }

            return errorData;
        }

        public async Task<string> ChangeUserPasswordAsync(ChangePasswordRazorModel model)
        {
            try
            {
                if (model != null)
                {
                    var user = await _userManager.FindByIdAsync(model.userId);
                    if (user != null)
                    {
                        var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                        if (result.Succeeded)
                        {
                            return "success";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return "failure";
                // return e.Message;
            }

            return "failure";
        }

        public async Task<string> AssignRemoveUserInRoleAsync(AssignUserRoleViewModel model)
        {
            if (model.Action == "Assign")
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    return $"User with user name = {model.Email} cannot be found";
                }

                var role = await _roleManager.FindByNameAsync(model.RoleName);
                if (role == null)
                {
                    return $"Role with name = {model.RoleName} cannot be found";
                }

                var result = await _userManager.AddToRoleAsync(user, role.Name);
                if (result.Succeeded)
                {
                    return "success";
                }

                string errorData = string.Empty;
                List<IdentityError> li = new List<IdentityError>();
                foreach (var error in result.Errors)
                {
                    errorData = error.Description;
                    li.Add(new IdentityError
                    {
                        Code = error.Code,
                        Description = error.Description
                    });
                }

                return errorData;
            }
            else if (model.Action == "Remove")
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    return $"User with user name = {model.Email} cannot be found";
                }

                var role = await _roleManager.FindByNameAsync(model.RoleName);
                if (role == null)
                {
                    return $"Role with name = {model.RoleName} cannot be found";
                }

                var result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                if (result.Succeeded)
                {
                    return "success";
                }

                string errorData = string.Empty;
                List<IdentityError> li = new List<IdentityError>();
                foreach (var error in result.Errors)
                {
                    errorData = error.Description;
                    li.Add(new IdentityError
                    {
                        Code = error.Code,
                        Description = error.Description
                    });
                }

                return errorData;
            }
            else
            {
                return "You have sent invalid request, please try again!!";
            }
        }

        public async Task<IEnumerable<UsersListAssign>> GetAllUsersAsync()
        {
            List<UsersListAssign> usersListAssigns = new List<UsersListAssign>();
            foreach (var user in await _dbContext.Users.ToListAsync())
            {
                usersListAssigns.Add(new UsersListAssign
                {
                    UserName = user.UserName,
                    Email = user.Email
                });
            }
            return usersListAssigns;
        }
    }
}
