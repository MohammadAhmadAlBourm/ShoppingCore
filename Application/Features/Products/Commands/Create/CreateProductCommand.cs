using MediatR;

namespace Application.Features.Products.Commands.Create;

public sealed record CreateProductCommand(
    string Name,
    string Description,
    decimal Price) : IRequest<CreateProductResponse>;