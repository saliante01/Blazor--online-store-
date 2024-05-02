using OnlineStore_Blazor.Models;

namespace OnlineStore_Blazor.Services
{
    public class ShippingInfoService
    {
        private List<ShippingData> shippingData = new List<ShippingData>();

        public void SaveShippingInfo(ShippingData info)
        {
            shippingData.Add(info);
        }

        public List<ShippingData> GetAllShippingData()
        {
            return shippingData;
        }
        public bool HasShippingInfo()
        {
            return shippingData.Any(); // Devuelve verdadero si ya hay información almacenada
        }


    }
}
