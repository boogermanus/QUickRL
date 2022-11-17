using System.ComponentModel.DataAnnotations;

namespace Quickrl.Core.ApiModels.AuthModels
{
    public class LoginModel
    {
        [EmailAddress]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}