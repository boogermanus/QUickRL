using Microsoft.AspNetCore.Identity;
using Quickrl.Core.ApiModels.AuthModels;

namespace Quickrl.Core.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public UserModel ToApiModel()
        {
            return new UserModel
            {
                Id = Id,
                Username = UserName,
                Email = Email,
            };
        }
    }
}