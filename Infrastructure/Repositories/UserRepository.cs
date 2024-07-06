using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Database;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

internal class UserRepository(
    ShoppingCoreDbContext _context,
    ILogger _logger) : IUserRepository
{
    public Task<bool> Create(User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> List(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
