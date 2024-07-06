using Domain.Repositories;
using Infrastructure.Database;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

internal sealed class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ILogger _logger;
    private readonly ShoppingCoreDbContext _context;

    public IProductRepository ProductRepository { get; private set; }

    public IUserRepository UserRepository { get; private set; }


    public UnitOfWork(ILoggerFactory logger, ShoppingCoreDbContext context)
    {
        _logger = logger.CreateLogger("Logs");
        _context = context;

        ProductRepository = new ProductRepository(_context, _logger);
        UserRepository = new UserRepository(_context, _logger);

    }


    public async Task CompleteAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}