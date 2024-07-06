using Domain.Entities;

namespace Domain.Repositories;

public interface IUserRepository
{
    Task<bool> Create(User user, CancellationToken cancellationToken);
    Task<bool> Update(User user, CancellationToken cancellationToken);
    Task<bool> Delete(User user, CancellationToken cancellationToken);
    Task<User> GetById(int id, CancellationToken cancellationToken);
    Task<IEnumerable<User>> List(CancellationToken cancellationToken);
}