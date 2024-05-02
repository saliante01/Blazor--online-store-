using OnlineStore_Blazor.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

namespace OnlineStore_Blazor.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            string url = "https://fakestoreapi.com/products";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var productsJson = await response.Content.ReadAsStringAsync();
                var products = JsonSerializer.Deserialize<List<Product>>(productsJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return products;
            }
            else
            {
                throw new HttpRequestException("No se pudo obtener los productos de la Fake Store API.");
            }
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            string url = $"https://fakestoreapi.com/products/{productId}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var productJson = await response.Content.ReadAsStringAsync();
                var product = JsonSerializer.Deserialize<Product>(productJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return product;
            }
            else
            {
                throw new HttpRequestException($"No se pudo obtener el producto con ID {productId} de la Fake Store API.");
            }
        }
    }
}
