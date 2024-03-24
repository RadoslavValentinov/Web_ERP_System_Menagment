using ERP_System_Menagment.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment.Core.Models
{
    public class RegisterViewModel
    {

        [StringLength(GlobalConstant.UserConstant.FirstNameMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.FirstNameMinLenght)]
        public string FirstName { get; set; } = null!;


        [StringLength(GlobalConstant.UserConstant.LastNameMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.LastNameMinLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(GlobalConstant.UserConstant.PassworMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.PassworMinLenght)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
