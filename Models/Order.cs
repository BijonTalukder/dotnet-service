namespace dotnet_service.Models
{
    public class Order
    {
    public Guid Id { get; set; } // Maps to `_id` in MongoDB
    public string OrderId { get; set; } = string.Empty;
    public Guid UserId { get; set; } // Maps to `userId`
    public Guid StoreId { get; set; } // Maps to `storeId`
    // public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    // public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
    // public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
    // public PaymentMethod PaymentMethod { get; set; }
    public decimal SubTotal { get; set; }
    public decimal DeliveryFee { get; set; } = 0;
    public decimal Discount { get; set; } = 0;
    public decimal TotalAmount { get; set; }
    public string DeliveryAddress { get; set; } = string.Empty;
    public DateTime? EstimatedDeliveryTime { get; set; }
    public DateTime PlacedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
    }
}