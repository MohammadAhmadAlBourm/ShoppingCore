using Domain.Events;
using MediatR;

namespace Application.EventsHandler;

internal sealed class CreateUserEventHandler : INotificationHandler<CreateUserEvent>
{
    public Task Handle(CreateUserEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}