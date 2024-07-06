using Domain.Entities;
using MediatR;

namespace Domain.Events;

public sealed record CreateProductEvent(Product Product) : INotification;