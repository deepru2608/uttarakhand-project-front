using System.Threading.Tasks;
using uttarakhand_project_front.Models;
using System;

namespace uttarakhand_project_front.Services
{
    public interface ITokenService
    {
        UserCredential GetCredential();

        Task<string> GetToken(UserCredential userData);

        UserToken BuildToken(UserInfo userInfo);

        DateTime GetExpiryTimestamp(string accessToken);
    }
}