using Newtonsoft.Json;

namespace XamarinPoc.Models
{
    public class OrderItem
    {
        [JsonProperty("productId")]
        public int Id { get; set; }

        [JsonProperty("productName")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonIgnore]
        public decimal UnitPrice { get; set; }
    }
}
