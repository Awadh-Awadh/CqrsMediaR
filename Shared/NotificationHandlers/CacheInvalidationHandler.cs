using MediatR;
using Shared.Infra;
using Shared.Models;
using Shared.Notifications;

namespace Shared.NotificationHandlers;

public class CacheInvalidationHandler : INotificationHandler<PersonCreatedNotification>
{
    private readonly IDataAccess _dataAccess;

    public CacheInvalidationHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public async Task Handle(PersonCreatedNotification notification, CancellationToken cancellationToken)
    {
        Person person = new()
        {
            FirstName = notification.FirstName,
            LastName = notification.LastName
        };

        await _dataAccess.EventOccured(person, "Cache Invalidated");
        await Task.CompletedTask;

    }
}