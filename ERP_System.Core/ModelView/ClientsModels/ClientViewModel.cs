using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment_Core.ModelView.ClientsModels
{
    public class ClientViewModel
    {

        [Required]
        [StringLength(200)]
        public string FirmName { get; set; } = null!;

        [Required]
        public int RegistrNumber { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; } = null!;

        [Required]
        public int PhoneNumber { get; set; }


        [Required]
        [StringLength(100)]
        public string AccountablePerson { get; set; } = null!;
    }
}
