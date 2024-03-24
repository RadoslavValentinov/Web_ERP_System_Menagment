using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ERP_System_Menagment_Infrastuctor.Data
{
    
    public class ERPSystemDbContext : IdentityDbContext<Users>
    {
        public ERPSystemDbContext(DbContextOptions<ERPSystemDbContext> option)
            : base(option)
        {
        }

        public DbSet<Invoice> Invoices { get; set; } = null!;

        public DbSet<Products> AllProducts { get; set; } = null!;
    }
}
