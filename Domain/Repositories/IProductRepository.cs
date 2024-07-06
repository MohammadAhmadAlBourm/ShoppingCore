using Domain.Entities;

namespace Domain.Repositories;

public interface IProductRepository
{
    Task<bool> Create(Product product, CancellationToken cancellationToken);
    Task<bool> Update(Product product, CancellationToken cancellationToken);
    Task<bool> Delete(Product product, CancellationToken cancellationToken);
    Task<Product> GetById(int id, CancellationToken cancellationToken);
    Task<IEnumerable<Product>> List(CancellationToken cancellationToken);
}