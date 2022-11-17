using System.ComponentModel.DataAnnotations;
using Quickrl.Core.Models;

namespace Quickrl.Core.ApiModels.AuthModels
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }

        public User ToDomainModel()
        {
            return new User
            {
                UserName = Username,
                Name = Name,
                Email = Username
            };
        }
    }
}