namespace Basket.Api.Entities
{
    public class ShoppingCartItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string ProductId { get; set; }
    }
}