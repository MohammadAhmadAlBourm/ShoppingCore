using Domain.Entities;
using Domain.Repositories;
using MapsterMapper;
using MediatR;

namespace Application.Features.Products.Commands.Create;

internal sealed class CreateProductHandler(IUnitOfWork _unitOfWork, IMapper _mapper) : IRequestHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Product>(request);

        await _unitOfWork.ProductRepository.Create(product, cancellationToken);
        await _unitOfWork.CompleteAsync(cancellationToken);

        return _mapper.Map<CreateProductResponse>(product);
    }
}