using Domain.Products;

namespace Domain.Orders;

public class LineItem
{
    public Guid Id { get; private set; }
    public Guid OrderId { get; private set; }
    public Guid ProductId { get; private set; }
    public Money Price { get; private set; }
    public static LineItem Create(Guid orderId, Guid productId, Money price)
    {
        return new LineItem { Id = Guid.NewGuid(), OrderId = orderId, ProductId = productId, Price = price };
    }
}