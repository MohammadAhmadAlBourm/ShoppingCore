using Domain.Abstraction;

namespace Domain.Entities;

internal class OrderItem : Entity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}