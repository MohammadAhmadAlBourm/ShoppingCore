namespace Domain.Repositories;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    IUserRepository UserRepository { get; }


    Task CompleteAsync(CancellationToken cancellationToken);
}