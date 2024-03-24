using ERP_System_Menagment.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment.Core.Models
{
    public class UserManegePageViewModel
    {
        public string? Avatar { get; set; }

        [StringLength(GlobalConstant.UserConstant.FirstNameMaxLenght,
          MinimumLength = GlobalConstant.UserConstant.FirstNameMinLenght)]
        public string? UserName { get; set; }

        public string? OldPassword { get; set; }

        [StringLength(GlobalConstant.UserConstant.PassworMaxLenght,
           MinimumLength = GlobalConstant.UserConstant.PassworMinLenght)]
        
        public string? newPassword { get; set; }

        [StringLength(GlobalConstant.UserConstant.PassworMaxLenght,
           MinimumLength = GlobalConstant.UserConstant.PassworMinLenght)]
        
        public string? ConfirmPassword { get; set; }

       
        [StringLength(GlobalConstant.UserConstant.FirstNameMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.FirstNameMinLenght)]
        public string? FirstName { get; set; }

        
        [StringLength(GlobalConstant.UserConstant.LastNameMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.LastNameMinLenght)]
        public string? LastName { get; set; }

       
        [EmailAddress]
        public string? Email { get; set; }

    }
}
