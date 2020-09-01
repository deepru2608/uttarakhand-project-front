using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.ViewModels;

namespace uttarakhand_project_front.Services
{
    public interface IUserService
    {
        Task<UserToken> CreateUserAsync(RegisterViewModel model);

        Task<UserToken> LoginUserAsync(LoginViewModel model);

        Task<string> CreateRoleAsync(string roleName);

        Task<IEnumerable<IdentityRole>> GetRolesListAsync();

        Task<string> DeleteRoleAsync(string roleId);

        Task<string> ChangeUserPasswordAsync(ChangePasswordRazorModel model);

        Task<string> AssignRemoveUserInRoleAsync(AssignUserRoleViewModel model);

        Task<IEnumerable<UsersListAssign>> GetAllUsersAsync();
    }
}
