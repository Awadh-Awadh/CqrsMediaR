using MediatR;
using Shared.Infra;
using Shared.Models;
using Shared.Notifications;

namespace Shared.NotificationHandlers;

public class EmailHandler: INotificationHandler<PersonCreatedNotification>

{
    private readonly IDataAccess _dataAccess;

    public EmailHandler(IDataAccess dataAccess)
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
        
        // event occured can be a service for example send email service
        
       await  _dataAccess.EventOccured(person, "Email Sent");
    }
}