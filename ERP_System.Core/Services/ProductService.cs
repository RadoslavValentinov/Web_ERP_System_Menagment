using ERP_System_Menagment.Infrastructure.Data.Common;
using ERP_System_Menagment_Core.IServices;
using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System_Menagment_Core.Services
{
    public class ProductService : IProductService
    {

        private readonly IRepository repo;

        public ProductService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<ProductViewModel>> AllProducts()
        {
            return await repo.All<Products>().Select(x => new ProductViewModel()
            {
                Name = x.Name,
                Quantity = x.Quantity,
                SalePrice = x.SalePrice
            })
            .ToListAsync();
        }
    }
}
