using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

internal sealed class ProductRepository(
    ShoppingCoreDbContext _context,
    ILogger _logger) : IProductRepository
{
    public async Task<bool> Create(Product product, CancellationToken cancellationToken)
    {
        try
        {
            await _context.Products.AddAsync(product, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Exception Occurred {Message}", ex.Message);
            throw;
        }
    }

    public async Task<bool> Delete(Product product, CancellationToken cancellationToken)
    {
        try
        {
            int count = await _context.Products
                .Where(x => x.Id == product.Id)
                .ExecuteDeleteAsync(cancellationToken);

            return count > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Exception Occurred {Message}", ex.Message);
            throw;
        }
    }

    public async Task<Product> GetById(int id, CancellationToken cancellationToken)
    {
        try
        {
            return await _context.Products
                .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Exception Occurred {Message}", ex.Message);
            throw;
        }
    }

    public async Task<IEnumerable<Product>> List(CancellationToken cancellationToken)
    {
        try
        {
            return await _context.Products
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Exception Occurred {Message}", ex.Message);
            throw;
        }
    }

    public async Task<bool> Update(Product product, CancellationToken cancellationToken)
    {
        try
        {
            int count = await _context.Products
                .Where(x => x.Id == product.Id)
                .ExecuteUpdateAsync(updates => updates
                    .SetProperty(p => p.Name, product.Name)
                    .SetProperty(p => p.Description, product.Description)
                    .SetProperty(p => p.Price, product.Price), cancellationToken);

            return count > 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Exception Occurred {Message}", ex.Message);
            throw;
        }
    }
}