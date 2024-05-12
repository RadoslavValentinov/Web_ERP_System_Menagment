using ERP_System_Menagment_Core.ModelView.ProductVievModel;

namespace ERP_System_Menagment_Core.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductViewModel>> AllProducts();
    }
}
