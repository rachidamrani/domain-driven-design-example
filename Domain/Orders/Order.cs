using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

public class Order
{
    public readonly HashSet<LineItem> _lineItems = new(); // Hashset is a collection that stores unique elements => prevents duplicate elements
    public Guid Id { get; set; }
    public Guid CustomerId { get; private set; }
    
    public static Order Create(Customer customer)
    {
        var order = new Order { Id = Guid.NewGuid(), CustomerId = customer.Id };
        return order;
    }

    public void Add(Product product)
    {
        var lineItem = LineItem.Create(Id, product.Id, product.Price);
        _lineItems.Add(lineItem);
    }
}