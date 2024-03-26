using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System_Menagment_Core.ModelView.ClientsModels
{
    public class EditClientsViewModel
    {
        public int ID { get; set; }

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
