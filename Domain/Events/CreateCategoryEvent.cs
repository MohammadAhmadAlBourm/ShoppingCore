using Domain.Entities;
using MediatR;

namespace Domain.Events;

public sealed record CreateCategoryEvent(Category Category) : INotification;