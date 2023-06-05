using ProductMicroservice.Models;
namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetProductById(int productid);
        void InsertProduct(Product product);
        void DeleteProduct(int productid);
        void UpdateProduct(Product product);
        void Save();
        object GetProducts();
    }
}
