using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_System_Menagment_Infrastuctor.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(AllProducts());
        }

        private List<Products> AllProducts()
        {
            return new List<Products>()
            {
                new Products {ID=1, Name= "Piston",Quantity = 12,SalePrice = 25.00m,GoodPrice = 20.00m},
                new Products {ID=2, Name= "Reel",Quantity = 32,SalePrice = 48.00m,GoodPrice = 40.00m},
                new Products {ID=3, Name= "Shaft",Quantity = 10,SalePrice = 75.00m,GoodPrice = 67.00m},
                new Products {ID=4, Name= "Transition",Quantity = 12,SalePrice = 20.00m,GoodPrice = 17.00m},
                new Products {ID=5, Name= "Safety Cover",Quantity = 15,SalePrice = 21.00m,GoodPrice = 18.00m},
                new Products {ID=6, Name= "Strap",Quantity = 2,SalePrice = 17.00m,GoodPrice = 14.00m},
                new Products {ID=7, Name= "Piston H345",Quantity = 34,SalePrice = 25.00m,GoodPrice = 20.00m},
                new Products {ID=8, Name= "Piston 265",Quantity = 3,SalePrice = 35.00m,GoodPrice = 30.00m},
            };
        }
    }
}
