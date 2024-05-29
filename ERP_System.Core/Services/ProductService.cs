using ERP_System_Menagment.Infrastructure.Data.Common;
using ERP_System_Menagment_Core.IServices;
using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;

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
                Id = x.ID,
                Name = x.Name,
                Quantity = x.Quantity,
                SalePrice = x.SalePrice,
                GoodPrice = x.GoodPrice
            })
            .ToListAsync();
        }

        public async Task<ProductViewModel> CreateProduct(ProductViewModel model)
        {
            var product = new Products
            {
                Name = model.Name,
                Quantity = model.Quantity,
                SalePrice = model.SalePrice,
                GoodPrice = model.GoodPrice
            };

            await repo.AddAsync(product);
            await repo.SaveChangesAsync();

            return model;
        }



        public async Task<ProductViewModel> DeleteProduct(ProductViewModel model)
        {
            var searchItem = repo.GetByIdAsync<Products>(model.Id).Result;

            if (searchItem != null)
            {
                repo.Delete(searchItem);
                await repo.SaveChangesAsync();
            }

            return model;
        }



        public async Task<EditProductViewModel> EditProducts(EditProductViewModel model)
        {

            var searchProduct = repo.All<Products>().FirstOrDefault(p => p.ID == model.Id);


            searchProduct!.Name = model.Name;
            searchProduct.Quantity = model.Quantity;
            searchProduct.SalePrice = model.SalePrice;
            searchProduct.GoodPrice = model.GoodPrice;

            repo.Update(searchProduct);
            await repo.SaveChangesAsync();

            return model;
        }




    }
}
