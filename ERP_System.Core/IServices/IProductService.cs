using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System_Menagment_Core.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductViewModel>> AllProducts();
    }
}
