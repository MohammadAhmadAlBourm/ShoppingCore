using Domain.Abstraction;

namespace Domain.Entities;

public class Category : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

}