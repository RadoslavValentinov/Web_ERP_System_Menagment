using ERP_System_Menagment.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment.Core.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(GlobalConstant.UserConstant.PassworMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.PassworMinLenght)]
        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; }
    }
}
