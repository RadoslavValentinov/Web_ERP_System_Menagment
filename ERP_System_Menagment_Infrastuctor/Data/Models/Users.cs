using Microsoft.AspNetCore.Identity;

namespace ERP_System_Menagment_Infrastuctor.Data.Models
{
    public class Users : IdentityUser
    {
        public string? Avatar { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public List<Invoice> UserFiles { get; set; } = new List<Invoice>();
    }
}
