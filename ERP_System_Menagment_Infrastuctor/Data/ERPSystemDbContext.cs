using ERP_System_Menagment_Infrastuctor.Data.Configuration;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ERP_System_Menagment_Infrastuctor.Data
{

    public class ERPSystemDbContext : IdentityDbContext<Users>
    {
        public ERPSystemDbContext(DbContextOptions<ERPSystemDbContext> option)
            : base(option)
        {
        }

        public DbSet<Invoice> Invoices { get; set; } = null!;

        public DbSet<Products> Products { get; set; } = null!;

        public DbSet<ClientsData> Clients { get; set; } = null!;

        public DbSet<Sale> Sale { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {


            //builder.HasSequence<int>("Products");

            //builder.Entity<Products>()
            //    .Property(o => o.ID)
            //    .HasDefaultValueSql("NEXT VALUE FOR Products");




            builder.ApplyConfiguration(new ProductConfiguration());


            base.OnModelCreating(builder);

        }

    }


}
