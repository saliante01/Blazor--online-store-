using System;
namespace OnlineStore_Blazor.Models
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new List<Product>();

        public void AddItem(Product product)
        {
            Items.Add(product);
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(item => item.Price);
        }
        public void RemoveItem(Product product)
        {
            Items.Remove(product);
        }

    }
}
