using product_manager_winforms.Domain;
using System.ComponentModel;

namespace product_manager_winforms.Infrastructure.Products
{
    public interface IProductService
    {
        BindingList<Product> GetAll();
        void Add(Product product);
        void Remove(Product product);
    }
}
