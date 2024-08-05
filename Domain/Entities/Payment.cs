using Domain.Abstraction;

namespace Domain.Entities;

public class Payment : Entity
{
    public int OrderId { get; set; }
    public int UserId { get; set; }

}