using Domain.Entities;

namespace Domain.Repositories;

public interface IAuthRepository
{
    string GenerateToken(User user);
}