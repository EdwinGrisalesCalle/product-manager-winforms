using product_manager_winforms.Domain;
using System.ComponentModel;

namespace product_manager_winforms.Infrastructure.Products
{
    public class ProductService : IProductService
    {
        private BindingList<Product> products = new BindingList<Product>();

        public BindingList<Product> GetAll()
        {
            return products;
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            if (product != null)
                products.Remove(product);
        }
    }
}
