using Domain.Entities;
using MediatR;

namespace Domain.Events;

public sealed record CreateUserEvent(User User) : INotification;