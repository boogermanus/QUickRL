using System.ComponentModel.DataAnnotations;

namespace Quickrl.Core.ApiModels.AuthModels
{
    public class ChangePasswordModel : LoginModel
    {
        [Required]
        public string ConfirmPassword { get; set; }
    }
}