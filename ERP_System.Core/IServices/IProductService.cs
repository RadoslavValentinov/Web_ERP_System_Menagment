using ERP_System_Menagment_Core.ModelView.ProductVievModel;

namespace ERP_System_Menagment_Core.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductViewModel>> AllProducts();

        public Task<ProductViewModel> CreateProduct(ProductViewModel model);

        public Task<EditProductViewModel> EditProducts(EditProductViewModel model);

        public Task<ProductViewModel> DeleteProduct(ProductViewModel model);
    }
}
