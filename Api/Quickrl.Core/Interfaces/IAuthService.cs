using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Quickrl.Core.ApiModels;
using Quickrl.Core.ApiModels.AuthModels;

namespace Quickrl.Core.Interfaces
{
    public interface IAuthService
    {
        Task<IdentityResult> Register(RegistrationModel model);
        Task<AuthModel> Login(LoginModel model);
        Task<bool> ChangePassword(ChangePasswordModel model);
        public JwtSecurityToken Decode(AuthModel model);
        public bool Validate(AuthModel model);
    }
}