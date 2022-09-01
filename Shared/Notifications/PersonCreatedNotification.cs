using MediatR;
using Shared.DTOs;

namespace Shared.Notifications;

public record PersonCreatedNotification (string FirstName, string LastName): INotification;