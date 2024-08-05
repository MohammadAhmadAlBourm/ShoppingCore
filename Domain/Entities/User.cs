using Domain.Abstraction;

namespace Domain.Entities;

public class User : Entity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Salt { get; set; }
    public required string Username { get; set; }
    public List<string> Roles { get; set; } = [];
}