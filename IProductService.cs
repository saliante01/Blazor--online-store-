using OnlineStore_Blazor.Models;

namespace OnlineStore_Blazor.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
    }
}
