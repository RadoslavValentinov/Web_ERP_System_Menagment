using ERP_System_Menagment_Infrastuctor.Data.Configuration;
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

        public DbSet<ClientsData> Clients { get; set; } = null!;

        public DbSet<Sale> Sale { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Products>(b =>
            {
                b.HasKey(e => e.ID);
                b.Property(e => e.ID).ValueGeneratedOnAdd();
            });



            builder.ApplyConfiguration(new ProductConfiguration());


            base.OnModelCreating(builder);

        }

    }


}
