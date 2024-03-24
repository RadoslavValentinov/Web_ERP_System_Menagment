using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System_Menagment_Infrastuctor.Data.Models
{
    public class Files
    {
        [Key]
        public int id { get; set; }

        [Required]
        public DateTime uploadTime { get; set; }

        [Required]
        public string FileNames { get; set; } = null!;

        [Required]
        public byte[]? FilesbyUser { get; set; }

        [Required]
        public string UserName { get; set; } = null!;
    }
}
