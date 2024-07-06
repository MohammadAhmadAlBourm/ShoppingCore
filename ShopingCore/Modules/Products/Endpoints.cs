using Application.Features.Products.Commands.Create;
using Asp.Versioning;
using Asp.Versioning.Builder;
using Carter;
using MediatR;

namespace ShoppingCore.Modules.Products;

public class Endpoints : CarterModule
{
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        ApiVersionSet apiVersionSet = app.NewApiVersionSet()
            .HasApiVersion(new ApiVersion(1))
            .HasApiVersion(new ApiVersion(2))
            .ReportApiVersions()
            .Build();

        app.MapPost("product", async (CreateProductCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var response = await sender.Send(request, cancellationToken);
            return Results.Ok(response);
        })
        .WithApiVersionSet(apiVersionSet)
        .MapToApiVersion(1);



    }
}